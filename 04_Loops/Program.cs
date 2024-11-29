using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler
            #region For döngüsü

            //For(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            /* int i;
             for (i = 1; i <= 5; i++)
             {
                 Console.WriteLine("C# eğitim kampı");
             }*/

            /*for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }*/

            /*for (int i = 3; i <= 50; i += 3)
            {
                Console.WriteLine(i);
            }*/

            /*Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            int finishValue=Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen kelimeyi giriniz: ");
            string word=Console.ReadLine();

            for (int i = 1; i <= finishValue; i++)
            {
                Console.WriteLine(word);
            }*/

            #endregion

            #region For Döngüsü ile Karar yapıları
            /*for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            /*int totalValue = 0;
            for (int i = 1; i <= 10; i++)
            {
                totalValue+= i;
            }
            Console.WriteLine(totalValue);*/

            /*int totalValue = 0;
            for (int i = 1; i < 50; i++)
            {
                if (i % 2 == 0)
                {
                    totalValue += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("----------------");
            Console.WriteLine(totalValue);*/

            /*int count = 0;
            for (int i = 1; i < 65; i++)
            {
                if (i % 7 ==0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);*/

            /*int bakterium = 1;
            for (int i = 1; i <= 24; i++)
            {
                bakterium *= 2;
                Console.WriteLine(i+".saatin sonunda : "+bakterium);
            }*/

            #endregion

            #region while Döngüsü
            /*While(şart)
             {
                işlemler
             }*/

            /*int i = 0;
            while (i <= 10)
            {
                Console.WriteLine("Merhaba döndüler");
                i++;
            }*/

            /*int i = 1;
            while (i <= 10)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }*/

            /*int i = 1;
            int sum = 0;

            while (i <= 10)
            {
                sum += i;
                i++;
            }
            Console.WriteLine(sum);*/
            #endregion

            #region örnek sınav sorusu
            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            //456

            Console.Write("Lütfen 3 basamaklı sayı giriniz: ");
            int number=int.Parse(Console.ReadLine());
            int ones, tens, hundres;
            int sum;

            ones = number % 10;
            tens = (number % 100)/10;
            hundres = number / 100;


            Console.WriteLine(ones+"-"+tens+"-"+hundres);
            sum=ones+tens+hundres;
            Console.WriteLine(sum);

            #endregion
            Console.Read();
        }
    }
}
