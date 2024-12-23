using System;

class Program
{
    static void Main(string[] args)
    {
        int ay;

        Console.Write("Bir ay numarasi giriniz (1-12): ");
        ay = int.Parse(Console.ReadLine());

        if (ay >= 3 && ay <= 5)
        {
            Console.WriteLine("Ilkbahar");
        }
        else if (ay >= 6 && ay <= 8)
        {
            Console.WriteLine("Yaz");
        }
        else if (ay >= 9 && ay <= 11)
        {
            Console.WriteLine("Sonbahar");
        }
        else
        {
            Console.WriteLine("Kis");
        }
    }
}
