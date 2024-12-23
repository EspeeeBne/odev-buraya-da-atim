using System;

class Program
{
    static void Main(string[] args)
    {
        int a;

        Console.Write("Bir sayi giriniz: ");
        a = int.Parse(Console.ReadLine());

        a += 10;
        Console.WriteLine("a += 10 Sonucu: " + a);

        a /= 2;
        Console.WriteLine("a /= 2 Sonucu: " + a);
    }
}
