using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c;

        Console.Write("Birinci sayiyi giriniz: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Ikinci sayiyi giriniz: ");
        b = int.Parse(Console.ReadLine());

        Console.Write("Ucuncu sayiyi giriniz: ");
        c = int.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("En buyuk sayi: " + a);
        }
        else if (b > c)
        {
            Console.WriteLine("En buyuk sayi: " + b);
        }
        else
        {
            Console.WriteLine("En buyuk sayi: " + c);
        }
    }
}
