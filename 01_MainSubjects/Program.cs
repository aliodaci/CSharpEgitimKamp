using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Variable

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Ali";
            customerSurname = "ODACI";
            customerPhone = "+90 530 040 58 36";
            customerEmail = "deneme@gmail.com";
            district = "Yenişehir";
            city = "Mersin";

            Console.WriteLine();
            Console.WriteLine("**********  Rezervasyon Kartı ***********");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Müşteri:{0} {1}",customerName,customerSurname);
            Console.WriteLine("İletişim: "+customerPhone);
            Console.WriteLine("Email adres: ",customerEmail);
            Console.WriteLine("Adres: "+district+" /"+city);

            Console.WriteLine("----------------------------------------------");

            customerName = "Selin";
            customerSurname = "Odacı";
            customerPhone = "+90 531 833 74 57";
            customerEmail = "test@gmail.com";
            district = "Yenişehir";
            city = "Mersin";

            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: {0}", customerPhone);
            Console.WriteLine("Email Adres: " + customerEmail);
            Console.WriteLine("Adres: {0} / {1}",district,city);

            Console.WriteLine("-------------------------------------------");
            Console.Read();
            #endregion

            #region Int Variable


            #endregion
        }
    }
}
