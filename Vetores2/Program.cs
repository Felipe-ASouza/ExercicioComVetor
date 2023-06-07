using System;
using System.Globalization;

namespace Vetores2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produtos diferentes: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];
            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Preco;
            }

            double media = soma / n;
            Console.WriteLine("Preco médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}