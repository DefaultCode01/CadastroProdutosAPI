using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
using CadastroProdutos;
using CadastroProdutos.DataBase;
using CadastroProdutos.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using CadastroProdutos.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


builder.Services.AddOpenApi();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen( x =>
{
    x.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
    {
        Description = @"Insira o JWT no campo abaixo usando o seguinte formato: Bearer {seu_token}.",
        Name = "Authorization",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    x.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement()
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = Microsoft.OpenApi.Models.ParameterLocation.Header
            },
            new List<String>()
        }
    });


});

//builder.Services.AddScoped<IProdutosService, ProdutosService>();
builder.Services.AddScoped<IProdutosService, ProdutosDatabaseService>();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var jwtConfig = builder.Configuration.GetSection("Jwt");
var key = Encoding.ASCII.GetBytes(jwtConfig["Key"]); 
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
       ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true,

        ValidIssuer = jwtConfig["Issuer"],
        ValidAudience = jwtConfig["Audience"],

        IssuerSigningKey = new SymmetricSecurityKey(key),
    };
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

var produtos = new List<Produto>()
    {
        new Produto() { Id = 1, Nome="Mouse com fio",Preco=29.0M,Estoque=100},
        new Produto() { Id = 2, Nome="Mouse sem fio",Preco=99.0M,Estoque=25}
    };

app.MapControllers();
app.MapGet("/produtos", () =>
{
    return produtos;
});


app.MapGet("/produto/{Id}", (int Id) =>
{
    var produto = produtos.FirstOrDefault (x=> x.Id == Id);
    return  produtos is not null
    ? Results.Ok(produto)
    : Results.NotFound($"O porduto com o id {Id}, nao foi encontrado");
   
});

app.MapPost("/produtos", (Produto novoProduto) =>
{
    produtos.Add(novoProduto);
    return Results.Created();
});


app.MapPut("/produtos/{Id}", (int Id, Produto produtoAtualizado)=>
{
    var produto = produtos.FirstOrDefault(x=> x.Id ==Id);
    if (produtos is null)
    {
        return Results.NotFound($"produto com id {Id} não encontrado");
    }
    return Results.Ok(produto);
});

app.MapDelete("/produto/{Id}",(int Id) =>
{
    var produto = produtos.FirstOrDefault(x=> x.Id ==Id);
    if(produto is null )
    {
        return Results.NotFound($"produto com id {Id} não encontrado");
    } 
    produtos.Remove(produto);
    return Results.NoContent();
});



app.Run();



