using System;
namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // atama işlemleri
            int x=3;
            int y=3;
            y=y+2;

            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            //mantıksal operatorler
            // ||, &&, !

            bool isSuccess= true;
            bool isCompleted= false;

            if(isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect");
            }
            if(isSuccess || isCompleted)
            {
                Console.WriteLine("Great!..");
            }
            if(isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }

            //ilişkisel operatorler
            // <, >, <=, >=, ==, !=

            int a=3;
            int b=4;
            bool sonuc=a<b;
            Console.WriteLine(sonuc);

            sonuc=a>b;
            Console.WriteLine(sonuc);

            sonuc=a>=b;
            Console.WriteLine(sonuc);

            sonuc=a<=b;
            Console.WriteLine(sonuc);

            sonuc=a==b;
            Console.WriteLine(sonuc);

            sonuc=a!=b;
            Console.WriteLine(sonuc);

            // aaritmetik operatorler
            //  /, *, +, -

            int say1=10;
            int say2=5;
            int sonuc1= say1/say2;
            Console.WriteLine(sonuc1);

            sonuc1= say1*say2;
            Console.WriteLine(sonuc1);

            sonuc1= say1+say2;
            Console.WriteLine(sonuc1);

            sonuc1= say1-say2;
            Console.WriteLine(sonuc1);

            //mod alma % --> böldükten sonra kalanı getiren ifade
            int sonuc2=20%3;
            Console.WriteLine(sonuc2);




        }
    }


}

