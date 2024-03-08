
using System;


namespace MakinaBolumu_Ders1
{
    class deneme
    {
        void topla(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
    internal class makina
    {
        void hesapla()
        {

        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray; //kağıt rengi 
            Console.ForegroundColor = ConsoleColor.Blue; // kalem rengi
            //tüm c# uygulamaları en az 1 sınıf(class) içermelidir...
            Console.WriteLine("Yaşınız Kaç?");
            string yas = Console.ReadLine();
            if (int.Parse(yas) < 20)
            {//curly braces -- süslü parantez -- küme parantezi
                Console.WriteLine("Yaşın Küçük");
            }
            else
            {
                Console.WriteLine("Yaşın Büyük");
            }

            Console.ReadLine();
        }
    }
}
