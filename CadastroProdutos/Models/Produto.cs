using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CadastroProdutos.Models;
public class Produto
{



    public int Id{ get; set;}

    //Data Annotations Nome 
    [Required(ErrorMessage ="O campo nome é obrigatório")]
    [StringLength(100, ErrorMessage ="O  nomo pode ter no maximo 100 caracteres")]
    public string? Nome { get; set; }


    [Range(0.01, double.MaxValue, ErrorMessage ="O preço não pode ser menor que zero.")]
    public decimal Preco { get; set; }


    [Range(0, int.MaxValue, ErrorMessage ="O Estoque não pode ser negativo.")]
    public int Estoque { get; set; }
}