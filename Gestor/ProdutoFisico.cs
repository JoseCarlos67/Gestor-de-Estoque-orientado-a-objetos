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

        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;        
        }

        public void Adcionar_Saida()
        {
        }

        public void Adicionar_Entrada()
        {
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
