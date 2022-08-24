using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
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
            //Carrega o meu arquivo com a lista de produtos 
            Carrgar();    

            bool escolheuSair = false;

            while (escolheuSair == false)
            {
                Console.WriteLine("Sistema de Estoque");
                Console.WriteLine("\n1 - Listar\n2 - Adicionar\n3 - Remover\n4 - Entrada\n5 - Saída\n0 - Fechar");
                int opt = int.Parse(Console.ReadLine());
                Menu escolha = (Menu)opt;


                if (opt >= 0 && opt < 6)
                {
                    Console.Clear();
                    switch (escolha)
                    {
                        case Menu.Listar:
                            Listagem();
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

        static void Listagem()
        {
            Console.WriteLine("Lista de produtos:");
            foreach(IEstoque produto in produtos)
            {
                produto.Exibir();
            }
            Console.Write("Aperte qualquer tecla para sair.");
            Console.ReadKey();
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
            Salvar();
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
            Salvar();
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
            Salvar();
        }

        //Salva os produtos adicionado ou modificados.
        static void Salvar()
        {
            FileStream stream = new FileStream("produtos.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();
            encoder.Serialize(stream, produtos);
            stream.Close();
        }

        static void Carrgar()
        {
            FileStream stream = new FileStream("produtos.dat", FileMode.OpenOrCreate);
            BinaryFormatter decoder = new BinaryFormatter();

            try
            {

                produtos = (List<IEstoque>)decoder.Deserialize(stream);

                if(produtos == null)
                {
                    produtos = new List<IEstoque>();
                }

            } 
            catch(Exception e)
            {

                produtos = new List<IEstoque>();

            }

            stream.Close();
        }

    }
}
