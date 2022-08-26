using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor
{
    [System.Serializable]
    internal class ProdutoFisico : Produto, IEstoque
    {

        public float frete;
        private int estoque;

        public ProdutoFisico(string nome, float preco, float frete, int estoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
            this.estoque = estoque;
        }

        public void Adcionar_Saida()
        {
        }

        public void Adicionar_Entrada()
        {
            Console.WriteLine($"Adicionar entrada no estoque do produto {nome}");
            Console.WriteLine("Digite a quantidade que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque += entrada;
            Console.WriteLine("Entrada registrada!");
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine($"Quantidade em estoque: {estoque}");
            Console.WriteLine("====================================");
        }
    }
}
