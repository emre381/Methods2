using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
     class Program
    {
        static void Main(string[] args)
        {
            int toplam;
           toplam= hesapla(5, 6);
            Console.WriteLine(hesapla(8,6));
            string isim = "Emre";
            string soyisim="Çınar";
            Console.WriteLine(bilgileriHesapla(isim,soyisim));
            double x=12.5;
            Console.WriteLine(x + " sayısının karesi : "+kareAl(x));
            double sayi1 = 28, sayi2 = 34;

            Console.WriteLine(buyukSayiBul(sayi1,sayi2));
            //Console.WriteLine(buyukSayiBul(25,65)); same thing but ı put the integer inside the method

            string kullaniciIfadesi;
            Console.WriteLine("Sizde anahtar var mı ? varsa Var yazın :");
            kullaniciIfadesi=Console.ReadLine(); 
            if(anahtarVarMi(kullaniciIfadesi))
            {
                Console.WriteLine("İçeri girebilrisiniz");
            }
            else
            {
                Console.WriteLine("İçeri giremezsiniz");
            }
            
        }

        static int hesapla(int x, int y)
        {
            

            return x+y;
        }
        static string bilgileriHesapla(string isim, string soyisim)
        {
            return isim + " " + soyisim;
        }

        static double kareAl(double x) 
        {
            
            return x*x;
        }

        static double buyukSayiBul(double sayi1, double sayi2) 
        {
            if (sayi1 > sayi2)
            {
                return sayi1;
            }
            else 
            {
                return sayi2;
            }
        }

         static bool anahtarVarMi(string ifade)
        {
            if (ifade == "Var")
            {
                return true; 
            }
            else 
            {
                return false; 
            }
        }
    }
}
