using System;
using System.Collections.Generic;

namespace Aula26Interface
{
    public class Carrinho : ICarrinho
    {
        List<Produto> carrinho = new List<Produto>();
        public float ValorTotal {get; set;}
        public void Adicionar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Alterar(int _codigo, Produto _produtoAlterado)
        {
            carrinho.Find(x => x.Codigo == _codigo).Preco = _produtoAlterado.Preco;
            carrinho.Find(x => x.Codigo == _codigo).Nome = _produtoAlterado.Nome;
        }

        public void Ler()
        {
            foreach (Produto item in carrinho){
                System.Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }
        public void MostrarTotal(){
            foreach (Produto item in carrinho){
                ValorTotal += item.Preco;
            }
            System.Console.WriteLine($"Valor total do carrinho: R${ValorTotal}");
        }
    }
}