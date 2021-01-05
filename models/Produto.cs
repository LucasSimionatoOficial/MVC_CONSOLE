using System.Collections.Generic;
using System.IO;

namespace MVC_CONSOLE.models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preço { get; set; }

        private const string PATH = "Database/Produto.csv";

        public Produto(){
            string pasta = PATH.Split("/")[0];
            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }
            if(!File.Exists(PATH)){
                File.Create(PATH);
            }
        }

        public List<Produto> Ler(){
            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach(string item in linhas){
                string[] atributos = item.Split(";");

                Produto produtoNovo = new Produto();

                produtoNovo.Codigo = int.Parse(atributos[0]);
                produtoNovo.Nome = atributos[1];
                produtoNovo.Preço = float.Parse(atributos[2]);

                produtos.Add(produtoNovo);
            }

            return produtos;
        }
    }
}