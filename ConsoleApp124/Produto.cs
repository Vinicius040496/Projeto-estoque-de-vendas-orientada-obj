using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp124
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double EstoqueAtual()
        {

            return Preco * Quantidade;

        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProduto(int remover)
        {
            Quantidade = Quantidade - remover;
        }
        public override string ToString()
        {
            return Nome + " R$ " + Preco.ToString("f2") + " , " + Quantidade + " Unidades, Total: R$ " + EstoqueAtual().ToString("f2");
        }
    }
}
