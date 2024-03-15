using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakinaBolumu_Ders9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atama operatörleri  (bileşik atama operatörleri)
            // normal atama operatörü eşittir simgesi =
            int sayi1 = 10;
            sayi1 = 15; //atama işlemi. önceki 10 değeri değişir ve son değer 15 olur.
            sayi1 = sayi1 + 15;

            int sayi2 = 10;
            sayi2 += 15;   //sayi2 = sayi2 + 15;
            sayi2 += sayi1;
            sayi2 += (sayi1*15);//aritmatiksel işlem sonucu sayi2 değişkenine ilave ediyoruz

            sayi2 = sayi2 - 15;
            sayi2 -= 15;

            double bolme = 15;
            bolme = bolme / 5;
            bolme /= 5;  //üst satırın yerine bu satır yazılabilir.

            long carpma = 5;
            //carpma = carpma * 5;
            carpma *= 5;//üst satırın yerine bu satır yazılabilir. yani carpma değişkenin kendisi ile 5 i çarptık. yine kendisine atadık.




        }
    }
}
