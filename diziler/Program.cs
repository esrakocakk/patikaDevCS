using System;
namespace diziler
{
    class Program
{
    static void Main(string[] args)
    {
        //Dizi tanımlama
        string[] renkler= new string [5];

        string[] hayvanlar={"Kedi", "Köpek", "Kuş", "inek"};

        int[] dizi;
        dizi= new int[5];

        //dizilere değer atama ve erişim
        renkler[0]="mavi";
        dizi[3]=10;

        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        //Döngülerle dizi kullanımı
        //klavyeden giirlen n tane sayının ortalamsını alan program
        Console.Write("Lütfen dizinin eleman sayısını giriniz:");
        int diziUzunluğu=int.Parse(Console.ReadLine());
        int[] sayıDizisi=new int[diziUzunluğu];

        for (int i = 0; i < diziUzunluğu; i++)
        {
            Console.Write("Lütfen {0}, sayısı giriniz", i+1);
            sayıDizisi[i] =int.Parse(Console.ReadLine());
        }
        int toplam=0;

        foreach (var sayi in diziUzunluğu)
        {
            toplam+=sayi;
        }
        Console.WriteLine("Ortalam:"+ toplam/diziUzunluğu);


    }
}
}
