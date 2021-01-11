using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {


            string nome1;
            int quartos;
            double preco;


            Console.WriteLine("Entre com seu nome completo:");
            nome1 = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto");
            preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu ultimo nome, idade e altura(mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string nome2 = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);
            




            Console.WriteLine("-----------------------------------");

            Console.WriteLine(nome1);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine(altura);




        }
    }
}
