using System;

class Program
{
    static void Main(string[] args)
    {
        int sayi;

        Console.Write("Bir sayi giriniz: ");
        sayi = int.Parse(Console.ReadLine());

        if (sayi % 2 == 0)
        {
            Console.WriteLine("Sayiniz cifttir.");
        }
        else
        {
            Console.WriteLine("Sayiniz tektir.");
        }
    }
}
