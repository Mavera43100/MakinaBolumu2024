using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakinaBolumu_Ders10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //karşılaştırma operatörleri

            // < küçüktür
            // > büyüktür
            // >= büyük yada eşit
            // <= küçük yada eşit 
            // != farklıdır
            // == eşit midir
            //Not : mantıksal karşılaştırmaların sonucunda TRUE yada FALSE sonucu döner.
            // mantıksal sonuçları bool isimli değişken tipinde saklarız.

            Console.WriteLine(15 < 18);
            Console.WriteLine(15 > 18);
            Console.WriteLine(15 >= 18);
            Console.WriteLine(15 <= 18);
            Console.WriteLine(15 != 18);
            Console.WriteLine(15 == 18);
            Console.WriteLine(15+3 == 18);


            //bool tipi değişkenlerin varsayılan değeri false'dur.
            int x = 19;
            int y = 18;
            bool sonuc = (x != y);
            sonuc = 10 * 2 >= 20;
            sonuc = !(5 < 4);

            sonuc = false;
            // && ve operatörü. mantıksal sınamalarda birden fazla koşulu değerlendirmek için kullanılır.koşulların tamamının true olması durumunda sonuç true olur. Aksi halde sonuç false olur.
            sonuc = (x>y) && (y+4>y) && (25==25);

            // || (alt gr tuşu ile z harfinin yanındaki dik çizgi olan tuş)
            // veya operatörü. mantıksal sınamalarda birden fazla koşulu değerlendirmek için kullanılır. koşullardan bir tanesi true olursa sonuç true'dur. tüm sonuçlar false olursa sonuç false olur.
            sonuc = false;
            sonuc =  (x > y) || (y + 4 < y) || (25 != 25);
            sonuc = !(x > y) || (y + 4 < y) || (25 != 25);
        }

        //karar yapıları ile ilgili bir video paylaşacağım.


    }
}
