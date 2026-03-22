using System;
using System.Linq;

namespace ex032
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void Lista()
        {
            //Variáveis locais
            int quantidade = 0;
            string[] lista;

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
        }

        public static double Adicao()
        {
            //Variáveis locais
            byte quantidade;
            double[] adicao;
            double resultado;

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

            return resultado;
        }
    }
}
