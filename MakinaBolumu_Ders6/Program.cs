using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakinaBolumu_Ders6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bu code'lar fiyat ve indirim oranı girilen bir ürününde indirimli fiyatı bulur.
            float indirimliFiyat = 0, indirimTutari;
            Console.Write("Ürünün Fiyatı Nedir :");
            float fiyat = float.Parse(Console.ReadLine());
            Console.Write("İndirim Oranı :");
            float oran = float.Parse(Console.ReadLine());
            indirimTutari = (fiyat * oran/100);
            indirimliFiyat = fiyat - indirimTutari;

            //Console.WriteLine("tamsayi değişkeninin ilk değeri:{0} ", indirimliFiyat);
            //Console.WriteLine($"İndirim Tutarı : {indirimTutari}");
            //Console.WriteLine($"İndirimli Fiyat : {indirimliFiyat}");
            Console.WriteLine($"İndirim Tutarı : {indirimTutari:N2}\nİnirimli Fiyat : {indirimliFiyat:N2}");

            //ctrl + shift + b = projeyi derler.(hatalara karşı denetler)
            //  \n enter tuşu gibi davranır.   \t ise tab tuşu gibi davranır.
            // {indirimliFiyat:N2} burada N2 binlik ayıracı olacak şekilde ve 2 hane ondalık olacak şekilde yazmasını sağlar.

            Console.ReadKey();

        }
    }
}
