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
    }
}