using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakinaBolumu_Ders5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 250;

            //byte tipi 0 ile 255 arası değer alabilir.(tam sayı kabul ediyor)
            int x = 270;

            // bilinçli tür dönüşümlerinde büyük kapasiteli türden küçük kapasiteli türe dönüşüm yapıldığında ortaya çıkar.
            b = (byte)x;// bilinçli tür dönüşümü
            b = (byte)25.5; // bilinçli tür dönüşümü

            double d = 8500;
            x = (int)d;// bilinçli tür dönüşümü


            byte b1 = 200;
            int x1 = 270;

            //Console.WriteLine("byte değişkeni olan b1'nin değeri : {0}",b1);
            b1 = (byte)x1;
            //Console.WriteLine("int değişkeni olan x1'nin değeri : {0}", x1);
            //Console.WriteLine("byte değişkeni olan b1'nin x1 aktarıldıktan sonraki değeri : {0}", b1);

            decimal d1 = 150787.56786m;
            decimal d2 = (decimal)150787.56786;

            decimal money = (decimal)250.7;
           // Console.WriteLine("Sayının Tipi : {0}",(250.7).GetType());

            int s1 = 3;
            float f1 = 4.5f;
            int z = 5;
            //  3 * 4.5 / 5 = 2,7
            Console.WriteLine("{0} * {1} / {2} = {3:f4} ",s1, (float)f1 ,z, s1 * f1 / z);
            Console.WriteLine("pi sayısı :{0}", Math.PI);
            Console.WriteLine("pi sayısı :{0:f2}", Math.PI);
            Console.WriteLine("-----------------------");
            int tamsayi = 100; // bu bir int değişken deklare eder 
            double kesirli = 100.0d; //bu, ondalıklı bir değişken deklare eder 
            Console.WriteLine("tamsayi değişkeninin ilk değeri:{0} ", tamsayi);
            Console.WriteLine("kesirli değişkeninin ilk değeri:{0} " , kesirli);
            Console.WriteLine(); // bos bir satir basar 
                                 // simdi, her ikisini de 3‘e bölelim
            tamsayi = tamsayi / 3;
            kesirli = kesirli / 3;
            Console.WriteLine("tamsayi değişkeni bölmeden sonra: {0} ", tamsayi);
            Console.WriteLine("kesirli değişkeni bölmeden sonra: {0:f3} ", kesirli);
            Console.ReadKey();// herhangi bir tuşa basılana kadar ekran bekler.
            Console.ReadLine();// ENTER tuşuna basılana kadar ekran bekler.

        
        }
    }
}
