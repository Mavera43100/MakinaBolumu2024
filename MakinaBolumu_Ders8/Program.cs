using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MakinaBolumu_Ders8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 artırma ve 1 eksiltme operatörleri
            //  artırma operatörü :  ++
            //  eksiltme operatörü : --
            // bu operatör değişkenin solunda veya sağında olmasına göre farklı çalışır.

            int value1 = 25;
            //value1 = value1 + 1;
            //Console.WriteLine(value1);
            //value1++;  // değeri 1 artırır
            //Console.WriteLine(value1);
            //++value1;  // değeri 1 artırır
            //Console.WriteLine(value1);
            //Console.ReadLine();
            // ++ operatörü değişkenin sağında ise, değişken işlem görür sonra artırırlır.
            Console.WriteLine(value1++);
            Console.WriteLine(++value1);
            //aşağıdaki ReadLine() metodu çıktı ekranını bekletmek için kullanıldı.

            int x = 10;
            int y = 0;
            y = x++; 
            Console.WriteLine($"x değişkeninin değeri : {x}\ty değişkeninin değeri : {y}");
            Console.WriteLine("--------------------------");
            int i = 5;
            int b = i--;
            int c = 10;
            int d = c--;
            Console.WriteLine($"b : {b}, c : {c}, d : {d}");
            int z = 9;

            Console.WriteLine("--------------");
            int val1 = 15;
            int val2 = 5;
            long result = 0;
           // result = val1++ * val2;
            result = ++val1 * val2;

            Console.ReadLine();








          

        }
    }
}
