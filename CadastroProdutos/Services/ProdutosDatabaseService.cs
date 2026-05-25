using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using CadastroProdutos.DataBase;
using CadastroProdutos.Services;
using Microsoft.EntityFrameworkCore;
using CadastroProdutos.Models;

namespace CadastroProdutos.Services 
{
        // Essa classe é o serviço que vai trabalhar com o banco de dados.
        // Ela implementa a interface IProdutosService.
    public class ProdutosDatabaseService : IProdutosService
    {
        // Variável que guarda a conexão/contexto do banco. O context é usado para acessar tabelas e salvar dados.
        private ApplicationDbContext context;

        // Construtor da classe. O ASP.NET envia automaticamente o ApplicationDbContext através da Injeção de Dependência.
        public ProdutosDatabaseService(ApplicationDbContext context)
        {
            // Guarda o contexto recebido na variável da classe.
            // Assim os métodos poderão usar o banco de dados.
            this.context = context;
        }
        
        public void Adicionar(Produto novoProduto)
        {
            ValidarProduto(novoProduto);
            context.Produtos.Add(novoProduto);
            context.SaveChangesAsync();
        }

        public async Task<Produto> Atualizar(int id, Produto produtoAtualizado)
        {  
           ValidarProduto(produtoAtualizado);
           var produto = context.Produtos.FirstOrDefault( x => x.Id == id);
            if (produto is null)
            {
                return null;
            }

            produto.Nome = produtoAtualizado.Nome;
            produto.Preco = produtoAtualizado.Preco;
            produto.Estoque = produtoAtualizado.Estoque;
            context.SaveChanges();

            return produto;



        }

        public Produto ObterPorId(int id)
        {
             return context.Produtos.FirstOrDefault( x => x.Id == id);
        }

        public List<Produto> ObterTodos()
        {
           return context.Produtos.ToList ();
        }

        public bool Remover(int id)
        {
            var produto = context.Produtos.FirstOrDefault(x => x.Id == id);
                
            if(produto is null)
            {
                return false;   
            }

            context.Produtos.Remove(produto);
            context.SaveChanges();
            
            return true;
        }

        Produto IProdutosService.Atualizar(int id, Produto produtoAtualizado)
        {
            throw new NotImplementedException();
        }
    

    private void ValidarProduto(Produto produto)
        {
            if(produto.Nome =="Produto Padrão")
            {
                throw new Exception("Não é permitido cadastrar um produto com o Nome: Nome Padrâo");
            }

            if(produto.Estoque >1000)
            {
                throw new Exception("O estoque não pode ser maior que 1000");
            }
        } 


    }
}

