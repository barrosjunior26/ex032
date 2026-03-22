using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ex032
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis locais
            byte opcao;

            Console.Write("Digite 1 para ir ao menu principal ou 0 para sair: ");

            opcao = Convert.ToByte(Console.ReadLine());

            while (opcao != 1 && opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("Opção inválida!\nTente novamente digitando o número correto.");

                Thread.Sleep(2000);
                Console.Clear();
                Console.Write("Digite 1 para ir ao menu principal ou 0 para sair: ");

                opcao = Convert.ToByte(Console.ReadLine());
            }

            switch (opcao)
            {
                case 0:
                    Sair();
                    break;
                case 1:
                    Menu();
                    break;
            }
        }

        public static void Menu()
        {
            //Variáveis locais
            byte opcao;

            Console.Clear();

            Console.Write("Digite o número deseja para realizar uma das operações disponíveis.\n2 - Criar uma lista de compras\n3 - Realizar um cálculo de adição;\n4 - Realizar um cálculo de subtração;\n5 - Realizar um cálculo de multiplicação;\n6 - Realizar um cálculo de divisão;\n0 - sair do sistema;\n\nDigite a opção desejada: ");

            opcao = Convert.ToByte(Console.ReadLine());

            while (opcao != 0 && opcao != 2 && opcao != 3 && opcao != 4 && opcao != 5 && opcao != 6)
            {
                Console.Clear();
                Console.WriteLine("Opção inválida!\nTente novamente digitando o número correto.");

                Thread.Sleep(2000);
                Console.Clear();
                Console.Write("Digite o número deseja para realizar uma das operações disponíveis.\n2 - Criar uma lista de compras\n3 - Realizar um cálculo de adição;\n4 - Realizar um cálculo de subtração;\n5 - Realizar um cálculo de multiplicação;\n6 - Realizar um cálculo de divisão;\n0 - sair do sistema;\n\nDigite a opção desejada: ");

                opcao = Convert.ToByte(Console.ReadLine());
            }

            switch (opcao)
            {
                case 0:
                    Sair();
                    break;
                case 1:
                    Menu();
                    break;
                case 2:
                    Lista();
                    break;
                case 3:
                    Adicao();
                    break;
                case 4:
                    Subtracao();
                    break;
                case 5:
                    Multiplicacao();
                    break;
                case 6:
                    Divisao();
                    break;
            }
        }

        public static void Lista()
        {
            //Variáveis locais
            int quantidade = 0;
            string[] lista;

            Console.Clear();
            Console.WriteLine("\n\n========== Lista de compras ==========\n");

            Console.Write("Informe a quantidade de itens que deseja incluir na lista: ");
            quantidade = Convert.ToInt16(Console.ReadLine());

            lista = new string[quantidade];

            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write($"Informe o {i + 1}º item: ");
                lista[i] = Console.ReadLine();
            }

            Console.WriteLine("\n\n========== Estes são os itens da suas lista de compras ==========\n");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\nDigite qualquer número para voltar a tela inicial");
            Console.ReadKey();

            Menu();
        }

        public static double Adicao()
        {
            //Variáveis locais
            byte quantidade;
            double[] adicao;
            double resultado;

            Console.Clear();
            Console.WriteLine("\n\n========== Cálculo de adição ==========\n");

            Console.Write("Informe a quantidade de valores que deseja somar: ");
            quantidade = Convert.ToByte(Console.ReadLine());

            adicao = new double[quantidade];

            for (int i = 0; i < adicao.Length; i++)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                adicao[i] = Convert.ToDouble(Console.ReadLine());
            }

            resultado = adicao.Sum();

            Console.WriteLine("\n\n========== Resultado do cálculo ==========\n");
            Console.WriteLine($"O cálculo é = {Math.Round(resultado, 2)}");

            Console.WriteLine("\n\nDigite qualquer número para voltar a tela inicial");
            Console.ReadKey();

            Menu();

            return resultado;
        }

        public static double Subtracao()
        {
            //Variáveis locais
            byte quantidade;
            double[] subtracao;
            double resultado;

            Console.Clear();
            Console.WriteLine("\n\n========== Cálculo de subtração ==========\n");

            Console.Write("Informe a quantidade de valores que deseja ir subtraindo: ");
            quantidade = Convert.ToByte(Console.ReadLine());

            subtracao = new double[quantidade];

            for (int i = 0; i < subtracao.Length; i++)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                subtracao[i] = Convert.ToDouble(Console.ReadLine());
            }

            resultado = subtracao.Aggregate((valor1, valor2) => valor1 - valor2);

            Console.WriteLine("\n\n========== Resultado do cálculo ==========\n");
            Console.WriteLine($"O resultado do cálculo = {Math.Round(resultado, 2)}");

            Console.WriteLine("\n\nDigite qualquer número para voltar a tela inicial");
            Console.ReadKey();

            Menu();

            return resultado;
        }

        public static double Multiplicacao()
        {
            //Variáveis locais
            byte quantidade;
            double[] multiplicacao;
            double resultado;

            Console.Clear();
            Console.WriteLine("\n\n========== Cálculo de multiplicação ==========\n");

            Console.Write("Informe a quantidade de valores que deseja ir multiplicando: ");
            quantidade = Convert.ToByte(Console.ReadLine());

            multiplicacao = new double[quantidade];

            for (int i = 0; i < multiplicacao.Length; i++)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                multiplicacao[i] = Convert.ToDouble(Console.ReadLine());
            }

            resultado = multiplicacao.Aggregate((mult1, mult2) => mult1 * mult2);

            Console.WriteLine("\n\n========== Resultado do cálculo ==========\n");
            Console.WriteLine($"O resultado do cálculo = {Math.Round(resultado, 2)}");

            Console.WriteLine("\n\nDigite qualquer número para voltar a tela inicial");
            Console.ReadKey();

            Menu();

            return resultado;
        }

        public static double Divisao()
        {
            //Variáveis locais
            double valor1, valor2, resultado;

            Console.Clear();
            Console.WriteLine("\n\n========== Cálculo de divisão ==========\n");

            Console.Write("Informe o dividendo: ");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o divisor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());

            resultado = valor1 / valor2;

            Console.WriteLine("\n\n========== Resultado do cálculo ==========\n");
            Console.WriteLine($"O resultado do cálculo = {Math.Round(resultado, 2)}");

            Console.WriteLine("\n\nDigite qualquer número para voltar a tela inicial");
            Console.ReadKey();

            Menu();

            return resultado;
        }

        public static void Sair()
        {
            Console.Clear();
            Console.Write("Saindo");

            for (int i = 5; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("\n\nAté logo!\n");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}