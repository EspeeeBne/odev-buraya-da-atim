using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b, xorSonuc, andSonuc, orSonuc, sagaKaydir;

        Console.Write("Birinci sayiyi giriniz: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Ikinci sayiyi giriniz: ");
        b = int.Parse(Console.ReadLine());

        xorSonuc = a ^ b;
        andSonuc = a & b;
        orSonuc = a | b;
        sagaKaydir = a >> 1;

        Console.WriteLine("XOR Sonucu: " + xorSonuc);
        Console.WriteLine("AND Sonucu: " + andSonuc);
        Console.WriteLine("OR Sonucu: " + orSonuc);
        Console.WriteLine("Saga Kaydirma Sonucu: " + sagaKaydir);
    }
}
