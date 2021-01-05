using System;
using MVC_CONSOLE.Controllers;
using MVC_CONSOLE.models;

namespace MVC_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtoController = new ProdutoController();
            produtoController.ListarProdutos();
        }
    }
}
