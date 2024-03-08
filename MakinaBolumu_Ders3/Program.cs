
using System;

namespace MakinaBolumu_Ders3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //değişken tanımla

            int val1=0; //değişken tanımlandı

            val1 = 15; //değişken başlatıldı

            // sonuc = val1 + 10; // bu satır hatalı. Çünkü sonuc değişkeni tanımlanmamış.
            // Console.WriteLine(val1);
            int val2 = 20;  //değişken tanımlanırken aynı zamanda değeri atanarak başlatılmış oldu.
            int val3 = (int)20.5565;  // bu satır hatalı. Çünkü ondalık bir değeri tamsayı değişkenine aktarmaya çalışıyoruz.
            val1 = val2 * val3;
            val1 = val1 * 10;

           // Console.WriteLine("Val1 değişkeninin son değeri : " + val1);

            //int 1value = 100; // değişken adı rakamla başlayamaz.
            //int birinci.value = 200;// değişken adı nokta içeremez.
            //string ad soyad = "Şenol Demirci"; // değişken adı boşluk içermez.

            // seçilen satırları açıklama satırı yapmak için; CTRL + C tuşları
            // açıklama satırlarını kaldırmak için CTRL + U tuşları kullanılır.


            // değişken adları büyük/küçük harf duyarlıdır. Aşağıdaki 2 değişken birbirinden farklıdır.
           
            //int Val1 = 1;
            //int VAL1 = 2;

            //Console.WriteLine("Val1'in değeri : " + Val1);
            //Console.WriteLine("VAL1'in değeri :" + VAL1);



            // önceden tanımlanmış bir değişken tekrar tanımlanamaz. Aşağıdaki gibi. İkiside yukarıda tanımlı. Değişken tipleri farklı ve de değerleri de farklı olsa dahi.
           // double Val1 = 8;
           // float VAL1 = 10;




            Console.ReadLine(); // klavyeden enter tuşu basılana kadar bekler...

             

        }
    }
}
