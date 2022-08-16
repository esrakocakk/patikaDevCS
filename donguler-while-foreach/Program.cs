using System;
namespace donguler_whilw_foreach
{
class Program
{
    static void Main(string[] args)
    {
        //while
        //1den başlayarak consoldan girilen sayıya kadar sayı dahil ortalama hesaplayıp consola yazdıran program
        Console.WriteLine("lütfen bir sayı giriniz:");
        int say=int.Parse(Console.ReadLine());
        int sayac=1;
        int toplam=0;
        while (sayac<=say)
        {
            toplam+=sayac;
            sayac ++;
        }
        Console.WriteLine(toplam/say);

        //adan zye kadar tüm harfleri cosole yazdır

        char karakter='a';
        while (karakter<'z')
        {
            Console.WriteLine(karakter);
            karakter ++;
            
        }

        Console.WriteLine("*****Foreach******");
        string[] cars={"BMW", "Ford", "Toyota", "Nissan"};

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
}