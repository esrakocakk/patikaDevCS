using System;
namespace metotlar_overloading
{
    class Program
{
    static void Main(string[] args)
    {
        //out parametreler

        string sayi="999";
        int outsayi;

        bool sonuc=int.TryParse(sayi, out outsayi);
        if (sonuc)
        {
            Console.WriteLine("Başarılı");
            Console.WriteLine(outsayi);
        }
        else
        {
            Console.WriteLine("Başarısız");
        }

        Metotlar Instance=new Metotlar();
        Instance.Topla(4,5, out int toplamSonucu);
        Console.WriteLine(toplamSonucu);

        //Metot Aşırı Yükleme - Overloading

        int ifade=999;
        Instance.EkranaYazdir(Convert.ToString(ifade));
        Instance.EkranaYazdir(ifade);
        Instance.EkranaYazdir("Esra Koçak");

    }
}
    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam=a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
         public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
         public void EkranaYazdir(int veri1, string veri2)
        {
            Console.WriteLine(veri1+ veri2);
        }
    }
}
