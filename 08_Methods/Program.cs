using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //()
            //Geriye değer döndürmeyen metodlar
            //Customer ----> Listele, ekle, sil güncelle
            //void
            #region Metodlar
            /*void CustomerVoid()
            {
                Console.WriteLine("ALİ ODACI");
                Console.WriteLine("SELİN ÇELİK");
                Console.WriteLine("SELİN ODACI");
            }

            CustomerVoid();
            CustomerVoid();
            CustomerVoid();*/


            /* void Sum()
             {
                 int x = 1;
                 int y=2;
                 Console.WriteLine(x + y);
             }

             Sum();*/
            #endregion

            #region Geri değer dönndürmeyen string parametreli metotlar
            /* void WriteMothod(string customerName)
             {
                 Console.WriteLine(customerName);
             }
             WriteMothod("ALİ ODACI");*/

            /*void CustomerCard(string name, string surName)
            {
                Console.WriteLine("Müşteri " + name + " " + surName);

            }
            CustomerCard("Alİ", "ODACI");
            CustomerCard("Selin", "ODACI");*/

            #endregion

            #region Geri değer dönndürmeyen string parametreli metotlar
            /*void Sum(int number1, int number2, int number3)
            {
                int result=number1+number2+number3;
                Console.WriteLine(result);
            }
            Sum(4, 5, 6);*/

            #endregion

            #region Geriye değer döndüren metotlar

            /*string CustomerName()
            {
                return "Ali ODACI";
            }
            CustomerName();*/

            /*string StudentCard()
            {
                string name = "Ali";
                string surName = "Odacı";

                return name +" "+ surName;
            }

            Console.WriteLine(StudentCard());*/

            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            /*string CountryCard(string countryName,string capital,string flagColor)
            {
                string countryInfo="Ülke: "+ countryName+" - Başkent: "+capital+" - Bayrak Rengi: "+flagColor;

                return countryInfo;
            }

            string x, y, z;
            Console.Write("Ülke adını giriniz: ");
            x= Console.ReadLine();

            Console.Write("Başkentin adını giriniz: ");
            y= Console.ReadLine();

            Console.Write("Ülke bayrak rengini giriniz: ");
            z= Console.ReadLine();

            Console.WriteLine(CountryCard(x, y, z));*/

            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            /*int Sum(int number1, int number2)
            {
                int result=number1 + number2;
                return result;
            }
            int x,y;
            Console.Write("Lütfen 1. sayıyı giriniz: ");
            x=Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen 2. sayıyı giriniz: ");
            y=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Sum(x,y));*/

            #endregion

            #region Örnek uygulama

            /*string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3 )/ 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti " + " ortalama: " + result;

                }
                else
                {
                    return student + " isimli öğrenci sınavdan kaldı " + " ortalama: " + result;
                }

            }
            Console.WriteLine(ExamResult("ALi ODACı", 50, 42, 53));
            Console.WriteLine(ExamResult("SELİN ODACI", 70, 85, 80));*/
            #endregion

            Console.Read();
        }
    }
}
