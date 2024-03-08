using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakinaBolumu_Ders4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // klavyeden öğrenci no, ad soyad, vize ve final notlarını alıp ortalamayı hesaplar.
            Console.Write("Öğrenci No Giriniz");
            string ogrno = Console.ReadLine();

            Console.Write("Ad Soyad Giriniz");
            string adSoyad = Console.ReadLine();

            Console.Write("Vize Notu : ");
            float vize = Convert.ToSingle(Console.ReadLine());

            Console.Write("Final Notu : ");
            float final = Convert.ToSingle(Console.ReadLine());

            float ortalama = vize * 0.40f + final * 0.60f;
            Console.WriteLine("Sınav Ortalaması : " + ortalama);
            Console.WriteLine("Sınav Ortalaması {0}",ortalama);



        }
    }
}
