using MVC_CONSOLE.models;
using MVC_CONSOLE.Views;

namespace MVC_CONSOLE.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();
        public void ListarProdutos(){
            produtoView.Listar(produto.Ler());
        }
    }
}