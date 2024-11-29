using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables

            /* Console.WriteLine("******* Fiayat listesi *******");
             Console.WriteLine();

             double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

             applePrice = 14.85;
             orangePrice = 20.95;
             strawberryPrice = 45;
             potatoPrice = 9.74;
             tomatoPrice = 6.88;

             Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " Tl");
             Console.WriteLine("---- Portakal Birim Fİyatı: " + orangePrice + "TL");
             Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + "TL");
             Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + "TL");
             Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + "TL");

             Console.WriteLine();
             Console.WriteLine();

             double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

             appleGram = 1.245;
             orangeGram = 2.650;
             strawberryGram = 0.750;
             potatoGram = 4.859;
             tomatoGram = 3.745;

             double applleTotalPrice = applePrice * appleGram;
             double orangeTotalPrice = orangePrice * orangeGram;
             double strawberryTotalPrice = strawberryPrice * strawberryGram;
             double potatoTotalPrice = potatoPrice * potatoGram;
             double tomatoTotalPrice = tomatoPrice * tomatoGram;

             Console.WriteLine("Alınana Ürün: Elma - " + " Birim Fiyatı: " + applePrice + " - Gramaj: " + appleGram + " - Toplam tutar: " + applleTotalPrice);
             Console.WriteLine("Alınana Ürün: Portakal - " + " Birim Fiyatı: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam tutar: " + orangeTotalPrice);
             Console.WriteLine("Alınana Ürün: Çilek - " + " Birim Fiyatı: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam tutar: " + strawberryTotalPrice);
             Console.WriteLine("Alınana Ürün: Patates - " + " Birim Fiyatı: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam tutar: " + potatoTotalPrice);
             Console.WriteLine("Alınana Ürün: Domates - " + " Birim Fiyatı: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam tutar: " + tomatoTotalPrice);

             double shoppingTotalPrice = applleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

             Console.WriteLine();
             Console.WriteLine();

             Console.WriteLine("Alışveriş toplam tutarı: " + shoppingTotalPrice + " TL");


             Console.Read();*/
            #endregion

            #region Char Variables

            /*char symbol;
            symbol='a';
            Console.WriteLine(symbol);*/

            #endregion

            #region Klavyeden veri girişleri - String Variables

            /* Console.WriteLine("**** CSharp Hava Yolları Yolcu Bİlgisi ******");
             Console.WriteLine();

             string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

             Console.Write("Yolcu Adı:");
             passengerName = Console.ReadLine();

             Console.Write("Yolcu Soyadı:");
             passengerSurname = Console.ReadLine();

             Console.Write("İlçe Bilgisi:");
             passengerDistrict = Console.ReadLine();

             Console.Write("Şehir Bilgisi:");
             passengerCity = Console.ReadLine();

             Console.Write("Yolcu Yaş: ");
             passengerAge = Console.ReadLine();

             Console.Write("Yolcu TC Kimlik Bilgisi: ");
             passengerIdentityNumber = Console.ReadLine();

             Console.WriteLine();
             Console.WriteLine("----------------------------------");

             Console.WriteLine("Yolcu TC Kimlik Numarası: {0} -  Yolcu: {1} {2} - İlçesi: {3} - Şehir: {4} - Yolcunun Yaşı: {5}", 
                 passengerIdentityNumber,
                 passengerName,
                 passengerSurname,
                 passengerDistrict, 
                 passengerCity,
                 passengerAge);


             Console.Read();*/

            #endregion


            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri

            /*int shoesPrice, computerPrice, chairPrice, tvPrice;

            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoesCount=Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            computerCount=int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            chairCount=int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız TV sayısını giriniz: ");
            tvCount=Convert.ToInt32(Console.ReadLine());

            int totalPrice=shoesCount*shoesPrice+computerCount*computerPrice+chairCount*chairPrice+tvCount* tvPrice;

            Console.WriteLine();
            Console.WriteLine("Toplam ödemeniz gereken fiyat: "+totalPrice);

            Console.Read();*/
            #endregion


            #region Klavyeden Ondalıklı sayı işlemleri

            /*double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1. notunuzu giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. notunuzu giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3. notunuzu giriniz: ");
            exam3 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Not Ortalaması: " + result);

            Console.Read();*/
            #endregion


        }
    }
}
