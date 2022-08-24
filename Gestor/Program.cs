using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestor
{
    class Program
    {
        static List<IEstoque> produtos = new List<IEstoque>();
        enum Menu { Listar = 1, Adicionar, Remover, Entrada, Saida, Fechar = 0 }
        enum MenuCadastro { ProdutoF = 1, Ebook, Curso }

        static void Main(string[] args)
        {

            bool escolheuSair = false;

            while (escolheuSair == false)
            {
                Console.WriteLine("Sistema de Estoque");
                Console.WriteLine("\n1 - Listar\n2 - Adicionar\n3 - Remover\n4 - Entrada\n5 - Saída\n0 - Fechar");
                int opt = int.Parse(Console.ReadLine());
                Menu escolha = (Menu)opt;


                if (opt >= 0 && opt < 6)
                {
                    switch (escolha)
                    {
                        case Menu.Listar:
                            break;
                        case Menu.Adicionar:
                            Cadastro();
                            break;
                        case Menu.Remover:
                            break;
                        case Menu.Entrada:
                            break;
                        case Menu.Saida:
                            break;
                        case Menu.Fechar:
                            escolheuSair = true;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Erro: Opção inválida!");
                    Console.Clear();
                }
                Console.Clear();
            }

            Console.WriteLine("Sistema de Estoque");
            Console.WriteLine("\n1 - Listar\n2 - Adicionar\n3 - Remover\n4 - Entrada\n5 - Saída\n0 - Fechar");
        }

        static void Cadastro()
        {
            Console.WriteLine("Cadastro de Produto");
            Console.WriteLine("\n1 - Produto Físico\n2 - Ebook\n3 - Curso");
            int opt = int.Parse(Console.ReadLine());
            MenuCadastro escolha = (MenuCadastro)opt;

            if (opt >= 1 && opt <= 3)
            {
                switch (escolha)
                {
                    case MenuCadastro.ProdutoF:
                        CadastrarPFisico();
                        break;
                    case MenuCadastro.Ebook:
                        CadastrarEbook();
                        break;
                    case MenuCadastro.Curso:
                        CadastrarCurso();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Erro: Opção inválida!");
                Console.Clear();
            }
            Console.Clear();
        }

        static void CadastrarPFisico()
        {
            Console.WriteLine("Cadastrando produto físico: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Frete: ");
            float frete = float.Parse(Console.ReadLine());
            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
            produtos.Add(pf);
        }

        static void CadastrarEbook()
        {
            Console.WriteLine("Cadastrando produto físico: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();

            EBook eb = new EBook(nome, autor, preco);
            produtos.Add(eb);
        }

        static void CadastrarCurso()
        {
            Console.WriteLine("Cadastrando produto físico: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();
            Console.WriteLine("Quantidade de vagas: ");
            int nVagas = int.Parse(Console.ReadLine());

            Curso cs = new Curso(autor, nVagas, nome, preco);
            produtos.Add(cs);
        }

    }
}
