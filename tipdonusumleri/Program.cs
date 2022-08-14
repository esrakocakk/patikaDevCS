using System;
namespace tipdonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            console.writeline("******Implicit Conversion*****")

            //Implicit Conversion (bilinçsiz dönüşüm)

            byte a= 5;
            sbyte b=30;
            short c=10;

            int d=a+b+c;
            console.writeline("d:"+d);

             long h=d;
             console.writeline(h);

             float i=h;
             console.writeline("i:"+i);

             string e="esra";
             char f='k';
             object g=e+f+g;
             console.writeline("g:"+g);

            //Explicit Conversion (bilinçli dönüşüm)

            console.writeline("******Explicit Conversion*****")

            int x=4;
            byte y=(byte)x;
            console.writeline("y:"+y);

            int z=100;
            byte t=(byte)z;
            console.writeline("t:"+t);

            float w=10.3f;
            byte v=(byte)w;
            console.writeline("v:"+v);


            // to.String Methodu
            console.writeline("******to.String Methodu*****")

            int xx=6;
            string yy=xx.ToString();
            console.writeline("yy:"+yy);

            string zz=12,5f.ToString();
            console.writeline("zz:"+zz);


            //system.convert
            console.writeline("******system.convert*****")

            string s1="10", s2="20";
            int say1, say2;
            int toplam;

            say1=convert.ToInt32(s1);
            say2=convert.ToInt32(s2);
            toplam=say1+say2;
            console.writeline("toplam:"+toplam);

            //Parse
            console.writeline("******Parse*****")
            ParseMethod();

        }

        public static void ParseMethod()
        {
            string metin1="10";
            string metin2="10.25";
            int rakam1;
            double double1;
            rakam1=Int32.Parse(metin1);
            double1=double.Parse(metin2);

            console.writeline(rakam1);
            console.writeline(double1);
        }
    }
}

