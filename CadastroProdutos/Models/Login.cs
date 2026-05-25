using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroProdutos.Models;

   public class Login
{
    [Required(ErrorMessage ="O campo nome é obrigatório")]
    [StringLength(50, ErrorMessage ="O  nomo pode ter no maximo 50 caracteres")]
    public string? Usuario { get; set; }

    [Required(ErrorMessage = "O campo senha é obrigatório")]
    [StringLength(4, ErrorMessage = "a senha deve ter ao menos 4 caracteres.")]
    public string? Senha { get; set; }
}
