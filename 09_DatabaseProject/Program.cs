using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.Net
            Console.WriteLine("----- C# veri tabanılı ürün-kategori bilgi sistemi------");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını girniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("----------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; initial catalog=EgitimKampiDb; integrated security=true");
            connection.Open();
            SqlCommand cmd = new SqlCommand("select*from TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }


            
            Console.Read();
        }
    }
}
