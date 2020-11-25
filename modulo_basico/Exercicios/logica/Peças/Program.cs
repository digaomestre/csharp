using System;

namespace Peças
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorTotal = 0;
            for (int i = 0; i < 2; i++){
                Console.WriteLine("Digite o código:");
                int codigo = Console.Read();
                Console.WriteLine("Digite a quantidade:");
                int qtde = Console.Read();
                Console.WriteLine("Digite o valor:");
                double valor = double.Parse(Console.ReadLine());

                valorTotal += valor;
            }

            Console.WriteLine("Valor a pagar:"+valorTotal);
        }
    }
}
