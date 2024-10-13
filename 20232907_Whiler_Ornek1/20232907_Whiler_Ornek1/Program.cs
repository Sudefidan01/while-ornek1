using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20232907_Whiler_Ornek1
{
    internal class Program
    {
        //1-100 arasındaki sayıların 2'ye tam bölünenlerini ekrana yazdıralım ek olarak bu sayıların
        //toplamını yazdıralım
        static void Main(string[] args)
        {
            int sayac = 1, hedef = 100, toplam = 0;
            while (sayac<=hedef)
            {
                if (sayac%2==0)
                {
                    Console.WriteLine(sayac);
                    toplam += sayac; // toplam = toplam + sayac;
                }
                sayac++;

               
            }
            Console.Write("1-100 arası 2'ye bölünen sayıların toplamı : "+toplam);
            Console.ReadKey();
        }
    }
}
