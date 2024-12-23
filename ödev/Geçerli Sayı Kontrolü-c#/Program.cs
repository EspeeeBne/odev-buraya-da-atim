using System;

class Program
{
    static void Main(string[] args)
    {
        int sayi;

        Console.Write("Bir sayi giriniz: ");
        sayi = int.Parse(Console.ReadLine());

        if (sayi >= 0 && sayi <= 100)
        {
            Console.WriteLine("Gecerli bir sayi girdiniz.");
        }
        else
        {
            Console.WriteLine("Gecersiz bir sayi girdiniz.");
        }
    }
}
