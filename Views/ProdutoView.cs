using System;
using System.Collections.Generic;
using MVC_CONSOLE.models;

namespace MVC_CONSOLE.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos){
            foreach (var item in produtos)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Produto: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");
            }
        }
        public Produto CadastrarProduto(){
            Produto produto = new Produto();
            Console.WriteLine($"Digite um código");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do produto");
            produto.Nome = Console.ReadLine();
            
            Console.WriteLine($"Digite o preço do produto");
            produto.Preco = float.Parse(Console.ReadLine());

            return produto;
        }
    }
}