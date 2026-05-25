using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroProdutos.Models;

namespace CadastroProdutos
{
    public interface IProdutosService
    {
        public List<Produto>ObterTodos();
        public Produto ObterPorId(int id);
        public void Adicionar(Produto novoProduto);
        public Produto Atualizar(int id, Produto produtoAtualizado);
        public bool Remover(int id);
    }
}