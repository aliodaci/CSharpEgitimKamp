using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DataCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD ---> Create--Read--Update--Delete

            Console.WriteLine("---------- Menü Sipariş İşlem Paneli ------------");
            Console.WriteLine();

            Console.WriteLine("--------------------------");

            #region Kategori ekleme işlemi

            /*Console.Write("Eklemek istediğiniz kategori adi: ");
            string categoryName = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; initial catalog=EgitimKampiDb; integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            command.Parameters.AddWithValue("@p1", categoryName);
            command.ExecuteNonQuery();
            connection.Close();

            Console.Write("Kategoriye başarıyla eklendi.");*/
            #endregion

            #region Ürün ekleme işlemi

            /*string productName;
            decimal productPrice;
            bool productStatus;

            Console.Write("Eklemek istediğiniz ürün adı: ");
            productName=Console.ReadLine();
            Console.Write("Ürün Fiyati:");
            productPrice=Convert.ToDecimal(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; initial catalog=EgitimKampiDb; integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values(@productName,@productPrice,@productStatus)", connection);
            command.Parameters.AddWithValue("@productName",productName);
            command.Parameters.AddWithValue("@productPrice",productPrice);
            command.Parameters.AddWithValue("@productStatus", true);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Ürün eklemesi başarılı");*/
            #endregion

            #region Ürün listeleme işlemi

            /* SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; initial catalog=EgitimKampiDb; integrated security=true");
             connection.Open();

             SqlCommand cmd = new SqlCommand("select * from TblProduct",connection);
             SqlDataAdapter adapter = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             adapter.Fill(dt);

             foreach (DataRow dr in dt.Rows)
             {
                 foreach (var item in dr.ItemArray)
                 {
                     Console.Write(item.ToString()+" ");
                 }
                 Console.WriteLine();
             }*/

            #endregion

            #region Ürün silme işlemi

            /*Console.Write("Lütfen silinecek id'yi giriniz: ");
            int productId=Convert.ToInt32(Console.ReadLine());
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; initial catalog=EgitimKampiDb; integrated security=true");
            connection.Open();

            SqlCommand cmd = new SqlCommand("delete from TblProduct where ProductId=@productId",connection);
            cmd.Parameters.AddWithValue("@productId", productId);
            cmd.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Silme işlemi yapıldı!");*/
            #endregion

            #region Ürün güncelleme işlemi
            /*Console.Write("Güncellenecek Ürün Id: ");
            int productId=int.Parse(Console.ReadLine());
            Console.Write("Güncellenecek Ürün adı:");
            string productName=Console.ReadLine();
            Console.Write("Güncellenecek ürün fiyat:");
            decimal productPrice=decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; initial catalog=EgitimKampiDb; integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();
            Console.WriteLine("Güncelleme başarılı!");*/
            #endregion


            Console.Read();
        }
    }
}
