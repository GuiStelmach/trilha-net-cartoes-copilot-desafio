using System;
using CardBrandDetector;

namespace CardBrandDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do cartão:");
            string cardNumber = Console.ReadLine();

            string brand = CardDetector.DetectBrand(cardNumber);

            Console.WriteLine($"Bandeira identificada: {brand}");
        }
    }
}