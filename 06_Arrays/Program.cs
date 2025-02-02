﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region temel dizi örnekleri

            //değişken türü[] dizi adı=new değişken türü[eleman sayısı]

            /*string[] colors = new string[4];
            colors[0] = "Kırmızı";
            colors[1] = "Sarı";
            colors[2] = "Yeşil";
            colors[3] = "Mavi";

            Console.WriteLine(colors[2]);*/

            /*string[] cities = new string[5];
            cities[0] = "Milano";
            cities[1] = "Budapeşte";
            cities[2] = "Kahire";
            cities[3] = "Üsküp";

            Console.WriteLine(cities[5]);

            int[] numbers = new int[10];
            numbers[0] = 50;
            numbers[1] = 48;
            numbers[2] = 698;
            numbers[3] = 24;
            numbers[7] = 748;
            Console.WriteLine(numbers[7]);*/




            #endregion

            #region Dizideki tüm elemanları listeleme

            /*string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Yeşil", "Mavi", "Pembe" };
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }*/

            /*int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 ==0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }*/

            /*int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            int maxNumber=myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNumber)
                {
                    maxNumber = myArray[i];
                }
            }
            Console.WriteLine(maxNumber);*/

            /* string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
             Console.WriteLine(persons.Length);*/

            /*int[] numbers = { 48, 85, 52, 25, 41, 86, 10, 22, 35 };
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }*/

            /*int[] numbers = { 48, 85, 52, 25, 41, 86, 10, 22, 35 };
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }*/

            #endregion

            #region Dizi metotları
            /*string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            int indexof = Array.IndexOf(customers, "merve");
            Console.WriteLine(indexof);*/

            /*int[] numbers = { 48, 85, 96, 63, 74, 10, 25, 22, 36 };
            Console.WriteLine("Dizinin en büyük elemanı: "+numbers.Max()+" Dizinin en küçük elemanı: "+numbers.Min());*/


            #endregion

            #region Kullanıcıdan değer alma
            /*string[] cities = new string[5];

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine($"Lütfen {i + 1} şehiri giriniz: ");
                cities[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }*/

            /*int[] numbers = {10,20,30,40,50};
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);*/

            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            Console.WriteLine("-------Çift Sayılar----------");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("-------Tek Sayılar------------");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion

            Console.Read();
        }
    }
}
