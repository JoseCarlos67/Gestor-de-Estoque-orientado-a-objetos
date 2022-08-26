using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor
{
    [System.Serializable]
    class Curso : Produto, IEstoque
    {
        public string autor;
        private int vagas;

        public Curso(string autor, int vagas, string nome, float preco)
        {
            this.autor = autor;
            this.vagas = vagas;
            this.nome = nome;
            this.preco = preco;
        }

        public void Adcionar_Saida()
        {
        }

        public void Adicionar_Entrada()
        {
            Console.WriteLine($"Adicionar vagas no curso de {nome}");
            Console.WriteLine("Digite a quantidade vagas: ");
            int entrada = int.Parse(Console.ReadLine());
            vagas += entrada;
            Console.WriteLine("Entrada registrada!");
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Número de vagas restantes: {vagas}");
            Console.WriteLine("====================================");
        }
    }
}
