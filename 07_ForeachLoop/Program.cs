using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach döngüsü
            //Foreach(1;2;3;4)

            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste koleksiyon, dizi

            /*string[] cities = { "milano", "paris", "varşova", "moskova", "ankara", "istanbul" };
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }*/

            /*int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }*/

            /*int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            /*int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            int total = 0;
            foreach (int i in numbers)
            {
                total += i;
            }
            Console.WriteLine(total);*/

            /* List<int> numbers = new List<int>()
             {
                 1,2,3,4,5,6,8,12
             };

             foreach (int number in numbers)
             {
                 Console.WriteLine(number);
             }*/

            /*string word = "Merhaba";
            foreach (char c in word)
            {
                Console.WriteLine(c);
            }*/

            #endregion

            #region Sınıf sistemi uygulaması
            Console.Write("***** CSHARP EĞİTİM EĞİTİM KAMPI SINAV UYGULAMASI *****");
            Console.WriteLine();
            Console.WriteLine();


            //sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("----------------------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var:");
            int studentCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------");

            //iÖğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg=new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i]= Console.ReadLine();

                double totalExamResult = 0;

                //her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]}. isimli öğrencinin {j + 1}. sınav notunu giriniz:");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları topluyoruz.
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            //Sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("--------------------------------------");

                Console.WriteLine($"{studentNames[i]}. adlı öğrencinin: {studentExamAvg[i]}");

                //öğrencinin ortalaması ve geçip geçmedikleri
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]}. adlı öğrenci dersten geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]}. adlı öğrenci dersten kaldı.");
                }
                Console.WriteLine("---------------------------------------");
            }

            #endregion
            Console.Read();
        }
    }
}
