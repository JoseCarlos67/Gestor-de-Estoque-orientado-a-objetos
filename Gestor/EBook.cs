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
            Console.WriteLine($"Adicionar vendas no Ebook {nome}");
            Console.WriteLine("Digite a quantidade vendas: ");
            int entrada = int.Parse(Console.ReadLine());
            num_vendas += entrada;
            Console.WriteLine("Venda(s) registrada!");
            Console.ReadKey();
        }

        public void Adicionar_Entrada()
        {
            Console.WriteLine("Não é possível dar entrada em um produto digital! Aperte qualquer tecla para sair.");
            Console.ReadKey();
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
