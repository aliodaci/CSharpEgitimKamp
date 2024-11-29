using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if

            /* Console.Write("Lütfen şifrenizi giriniz: ");
             string password;
             password = Console.ReadLine();
             if (password == "abcd")
             {
                 Console.WriteLine("Şifreniz Doğru");
             }
             else
             {
                 Console.WriteLine("Şifreniz yalnış");
             }
             Console.Read();*/

            /*string capital, country;
            Console.Write("Başkentinizi giriniz:");
            capital = Console.ReadLine();

            Console.Write("Ülkenizi giriniz: ");
            country = Console.ReadLine();

            if (capital == "Ankara" & country == "Türkiye")
            {
                Console.WriteLine("veriler doğrulandı");
            }
            else
            {
                Console.WriteLine("hatalı bilgi");
            }*/

            /*int sayi;
            Console.Write("Sayı Giriniz:");
            sayi=int.Parse(Console.ReadLine());

            if (sayi == 5)
            {
                Console.WriteLine("Sayınız doğru");
            }else
            {
                Console.WriteLine("Sayınız Yalnış");
            }*/

            /*int exam1, exam2, exam3, average;
            string result;
            Console.Write("1. Sınav notunu giriniz:");
            exam1=Convert.ToInt32(Console.ReadLine());

            Console.Write("2.Sınav notunu giriniz: ");
            exam2=int.Parse(Console.ReadLine());

            Console.Write("3.Sınav notunu giriniz: ");
            exam3=int.Parse(Console.ReadLine());
            result = "Hata!";
            average = (exam1 + exam2 + exam3) / 3;
            if (average > 0 & average <= 50)
            {
                result="Ortalama berabet";
            }
            if (average > 50 & average <= 69)
            {
                result="Ortalama Orta";
            }
            if (average > 70 & average <= 84)
            {
                result="Ortalama İyi";
            }
            if (average > 85)
            {
                result = "Ortalama çok iyi";
            }
            Console.WriteLine("Ortalamınız :" + average);
            Console.WriteLine("Ortalamanın durumu: "+result);*/

            /* string city;
             Console.Write("Lütfen şehir girişi yapınız: ");
             city = Console.ReadLine();

             if (city == "ankara" | city == "adana" | city == "bursa" | city == "trabzon")
             {
                 Console.WriteLine("Şehir mevcut");

             }
             else
             {
                 Console.WriteLine("Şehir mevcut değil");
             }*/

            /*Console.Write("Lütfen kullanıcı adını giriniz: ");
             string username=Console.ReadLine();
             if (username != "admin")
             {
                 Console.WriteLine("Bu kullanıcı adı kabul edilemez.");
             }
             else
             {
                 Console.WriteLine("Kullancınız doğru");
             }

             Console.Read();*/


            #endregion

            #region Mod işlemleri

            /*int number;
            number = 26;
            int result = number % 5;
            Console.WriteLine(result);*/

            /* Console.Write("Lütfen 1. Sayıyı Giriniz: ");
             int number1=Convert.ToInt32(Console.ReadLine());

             Console.Write("Lütfen 2.Sayıyı Giriniz: ");
             int number2=Convert.ToInt32(Console.ReadLine());

             int result = number1 % number2;
             Console.WriteLine("1. ve 2. sayının ortalaması: " + result);*/

            /*Console.Write("Lütfen sayıyı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.Write("Sayı Çifttir.");
            }else
            {
                Console.Write("Sayı Tektir.");
            }*/
            #endregion

            #region Char ile karar yapıları
            /*char team;
            Console.Write("Lütfen takım sembolünü giriniz: ");
            team = Convert.ToChar(Console.ReadLine());

            if (team == 'g' | team == 'G')
            {
                Console.Write("Galatasaray");
            }if (team == 'f' | team == 'F')
            {
                Console.Write("Fenerbahçe");

            }if (team == 'b' | team == 'B')
            {
                Console.Write("Beşiktaş");
            }*/

            #endregion

            #region Örnek Proje Uygulaması
            /* Console.WriteLine("***** C# Eğitim Kamp Restorant *****");
           Console.WriteLine();
           Console.WriteLine("---------------------------------");
           Console.WriteLine("1-Ana Yemekler");
           Console.WriteLine("2-Çorbalar");
           Console.WriteLine("3-Pizzalar");
           Console.WriteLine("4-İçecekler");
           Console.WriteLine("5-Tatlılar");
           Console.WriteLine("----------------------------------");
           Console.WriteLine();

           string menuItem;
           Console.Write("Detayını görmek için istediğiniz menu seçimi: ");
           menuItem = Console.ReadLine();
           if (menuItem == "1")
           {
               Console.WriteLine();
               Console.WriteLine("------------Ana Yemekler-------------");
               Console.WriteLine();
               Console.WriteLine("1- Köri soslu tavuk");
               Console.WriteLine("2- Kızatma tabağı");
               Console.WriteLine("3- Fasulye Pilav");
               Console.WriteLine("4-Fırında Somon");
               Console.WriteLine("5-Patlıcan Musakka");
               Console.WriteLine("------------Ana Yemekler--------------");
           }
           if (menuItem == "2")
           {
               Console.WriteLine();
               Console.WriteLine("------------Çorbalar-------------");
               Console.WriteLine();
               Console.WriteLine("1- Mercimek Çorbası");
               Console.WriteLine("2- Ezogelin Çorbası");
               Console.WriteLine("------------Çorbalar--------------");
           }
           if (menuItem == "3")
           {
               Console.WriteLine();
               Console.WriteLine("------------Pizzalar-------------");
               Console.WriteLine();
               Console.WriteLine("1- Akdeniz Pizza");
               Console.WriteLine("2- Karışık Pizza");
               Console.WriteLine("3- Meksika Pizza");
               Console.WriteLine("3- Tavuklu Pizza");
               Console.WriteLine("------------Pizzalar--------------");
           }
           if (menuItem == "4")
           {
               Console.WriteLine();
               Console.WriteLine("------------İçecekler-------------");
               Console.WriteLine();
               Console.WriteLine("1- Kola");
               Console.WriteLine("2- Ayran");
               Console.WriteLine("3- Su");
               Console.WriteLine("------------İçecekler--------------");
           }
           if (menuItem == "5")
           {
               Console.WriteLine();
               Console.WriteLine("------------Tatlılar-------------");
               Console.WriteLine();
               Console.WriteLine("1- Tirelice");
               Console.WriteLine("2- kazan Dibi");
               Console.WriteLine("3- Sütlaç");
               Console.WriteLine("------------Pizzalar--------------");
           }*/
            #endregion

            #region Switch Case

            /*Console.Write("Lütfen Ay Girişi Yapınız: ");
            int monthNumber=Convert.ToInt32(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:Console.Write("Ocak");break;
                case 2:Console.Write("Şubat");break;
                case 3:Console.Write("Mart"); break;
                case 4:Console.Write("Nisan");break;
                case 5:Console.Write("Mayıs");break;
                case 6:Console.Write("Haziran");break;
                case 7:Console.Write("Temmuz");break;
                case 8:Console.Write("Ağustos"); break;
                case 9:Console.Write("Eylül");break;
                case 10:Console.Write("Ekim");break;
                case 11:Console.Write("Kasım");break;
                case 12:Console.Write("Aralık");break;
                default:Console.Write("Hatalı veri girişi");break;
            }*/

            #endregion

            #region Switch case hesap makinesi

            int number1, number2, result;
            char symbol;

            Console.Write("1. Sayıyı giriniz: ");
            number1=Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sayıyı Gİriniz: ");
            number2=int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            symbol=char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result=number1 + number2;
                    Console.WriteLine("Toplam: " + result); 
                   break;

                case '-':
                    result=number1 - number2;
                    Console.Write("Fark: "+result);
                    break;

                case '*':result=number1 * number2;
                    Console.Write("Çarpım:"+result);
                    break;

                 case '/':result=number1 / number2;
                    Console.Write("Bölüm:" + result);
                    break;

                default:Console.Write("Hatalı işlem");
                    break;
            }

            #endregion

            Console.Read();
        }
    }
}
