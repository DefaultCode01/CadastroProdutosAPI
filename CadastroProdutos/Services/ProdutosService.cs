using System;
using CadastroProdutos.Models;

namespace CadastroProdutos.Services


{
    public class ProdutosService : IProdutosService
    {
        private static List<Produto> produtos  = new List<Produto>()
        {
            new Produto() { Id = 1, Nome="Mouse com fio",Preco=29.0M,Estoque=100},
            new Produto() { Id = 2, Nome="Mouse sem fio",Preco=99.0M,Estoque=25}
        };


   
        public List<Produto>ObterTodos()
        {
            return produtos;
        }

        public Produto ObterPorId(int id)
        {
            return produtos.FirstOrDefault(x => x.Id == id);
        }

        public void Adicionar(Produto novoProduto)
        {
            produtos.Add(novoProduto);
        }


        public Produto Atualizar(int id, Produto produtoAtualizado)
        {
            var produto = produtos.FirstOrDefault(x => x.Id == id);
            if (produtos is null)
            {
                return null;
            }

            produto.Nome = produtoAtualizado.Nome;
            produto.Preco = produtoAtualizado.Preco;
            produto.Estoque = produtoAtualizado.Estoque;
            
            return produto;
        }

        public bool Remover(int id)
        {
            var produto = produtos.FirstOrDefault(x => x.Id == id);
                    
            if(produto is null)
            {
                return false;   
            }
            produtos.Remove(produto);
            return true;

        }
    }
}