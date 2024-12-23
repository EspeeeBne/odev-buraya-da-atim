using System;

class Program
{
    static void Main(string[] args)
    {
        int a;

        Console.Write("Bir sayi giriniz: ");
        a = int.Parse(Console.ReadLine());

        if (a < 0)
        {
            a = -a;
        }

        Console.WriteLine("Sayinin mutlak degeri: " + a);
    }
}
