using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto P = new Produto();
         

            Console.WriteLine("Entre com dados do produto: ");
            Console.WriteLine("Nome do produto: ");
            P.Nome = Console.ReadLine();
            Console.WriteLine("Valor do produto: ");
            P.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade atual no estoque: ");
            P.Quantidade = int.Parse(Console.ReadLine());
           

            Console.WriteLine("Dados do produto: " + P);
            Console.WriteLine();

            Console.WriteLine("Digite numero de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            P.AdicionarProduto(qtd);
            Console.WriteLine("Dados atualizados: " + P);

            Console.WriteLine();
            Console.WriteLine("Digite numero de produtos a ser removidos ao estoque: ");
            int rmv = int.Parse(Console.ReadLine());
            P.RemoverProduto(rmv);
            Console.WriteLine("Dados atualizados: " + P);
            Console.ReadLine();
        }
    }
}
