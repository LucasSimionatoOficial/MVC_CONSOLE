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
                Console.WriteLine($"Text");
                Console.WriteLine($"Text");
                Console.WriteLine($"Text");
            }
        }
    }
}