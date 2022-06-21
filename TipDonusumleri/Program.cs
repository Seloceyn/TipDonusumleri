using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bilinçsiz Dönüşüm implicit

            byte a = 5;
            sbyte b = 10;
            short c = 8;
            int x = a * b;

            int d = a + b + c +x;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:"+h);

            string e = "Selami";
            char f = 'C';
            object g = e + f;
            Console.WriteLine(g);


            //Bilinçli Dönüşüm  explicit

            int z = 4;
            byte y = (byte)z;
            Console.WriteLine("y:" + y);

            int k = 100;
            byte i = (byte)k;
            Console.WriteLine("i:" + i);

            float w = 20.8f;
            byte s = (byte)w;
            Console.WriteLine("s:" + s);

            //To String Metodu //
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            string zz = 12.8.ToString();
            Console.WriteLine("zz:" + zz);

            //System.convert

            string s1 = "15", s2 = "35";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + Toplam);

            //Parse


            ParseMethod();



        }

        public static void ParseMethod()



        {
            string metin1 = "10";
            string metin2 = "25";
            int rakam1;
            double double1;
            

            rakam1 = Int32.Parse(metin1);
            double1 = Int32.Parse(metin2);
           

            Console.WriteLine("Rakam1:" + rakam1);
            Console.WriteLine("Double1:" + double1);

        }


    }
}
