using System;
using System.Globalization;

namespace VetoresUtilizandoReferencias
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n;
            Console.Write("Quantos Produtos serão cadastrados? ");
            n = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[n];

            for (int i = 0; i<n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Digite os Dados do "+ (i+1) + "o produto: ");
                Console.WriteLine();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Quantidade: ");
                int qtd = int.Parse(Console.ReadLine());
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CI);

                vet[i] = new Produto(nome, qtd, preco);
            }

            Console.WriteLine();
            Console.WriteLine("Produtos Cadastrados: ");
            for(int i =0; i<n; i++)
            {
                Console.WriteLine(vet[i]);
            }
            
        }
    }
}
