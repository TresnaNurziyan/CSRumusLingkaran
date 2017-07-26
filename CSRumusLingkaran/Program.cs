using System;

namespace CSRumusLingkaran
{
    class Program
    {
        static void Main(string[] args)
        {
            int jari;

            Console.Write("Masukan jari-jari lingkaran : ");
            jari = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Luas Lingkaran       : " + 22 / 7 * (jari * jari));
            Console.WriteLine("Keliling Lingkaran   : " + 2 * 22 / 7 * jari);
            Console.WriteLine("-----------------------------------");

            Console.ReadLine();
        }
    }
}
