using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakinaBolumu_Ders7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ToString()
            int sayi = 55;  int sayi2 = 10;
            string str = sayi.ToString();
            Console.WriteLine(sayi + str);  // sonuc : 5555
            int topla = sayi + sayi2;
            //int topla2 = int.Parse(str) + sayi + 15 + 28;
            //bir ifadenin içinde bir tane string değişken olması diğerlerini de stringe dönüştürür.
            // ayrıca ToString() metodu kullanmamıza gerek kalmaz.
            //string topla2 = str + sayi.ToString() + 15.ToString() + 28.ToString();
            string topla2 = str + sayi + 15 + 28;// + operatörleri bir tane string(str) olmasından dolayı birleştirme operatörüne dönüştü.
            Console.WriteLine($"Topla 2 değişkeninin değeri : { topla2}");
            string str2 = 1234.68f.ToString();
            Console.WriteLine(str+sayi+15+28);

          
            


         




        }
    }
}
