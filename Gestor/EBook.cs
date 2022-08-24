using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor
{
    [System.Serializable]
    class EBook : Produto, IEstoque
    {

        public string autor;
        private int num_vendas;

        public EBook(string autor, string nome, float preco)
        {
            this.autor = autor;
            this.nome = nome;
            this.preco = preco;
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
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Quantidade de cópias vendidas: {num_vendas}");
            Console.WriteLine("====================================");
        }
    }
}
