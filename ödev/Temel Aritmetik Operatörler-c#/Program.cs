using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b, toplam, fark, carpim, bolum;

        Console.Write("Birinci sayiyi giriniz: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Ikinci sayiyi giriniz: ");
        b = int.Parse(Console.ReadLine());

        toplam = a + b;
        fark = a - b;
        carpim = a * b;
        bolum = a / b;

        Console.WriteLine("Toplam: " + toplam);
        Console.WriteLine("Fark: " + fark);
        Console.WriteLine("Carpim: " + carpim);
        Console.WriteLine("Bolum: " + bolum);
    }
}
