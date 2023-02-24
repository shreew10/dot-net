using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace AdoExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            SqlConnection sqlC = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            SqlCommand sqlCm = new SqlCommand("SELECT CarId,CarModels,NextServicingDate,OwnerName,CurrentServicingDate FROM tble_Cars", sqlC);
            sqlC.Open();
            SqlDataAdapter sqlD = new SqlDataAdapter(sqlCm);
            DataTable dt = new DataTable();
            sqlD.Fill(dt);
            sqlC.Close();


            //Console.WriteLine("enter carid");
            //var id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter car model");
            //var name = Console.ReadLine();
            //Console.WriteLine("enter next servicing date");
            //var date = Console.ReadLine();
            //Console.WriteLine("enter owner name");
            //var OwnerName = Console.ReadLine();

            //SqlCommand sc = new SqlCommand("INSERT INTO tble_Cars(CarModels, NextServicingDate, OwnerName) VALUES(@CarModels,  CONVERT(date,@NextServicingDate,103), @OwnerName)", sqlC);
            //sqlC.Open();
            ////sc.Parameters.AddWithValue("@CarId", id);
            //sc.Parameters.AddWithValue("@CarModels", name);
            //sc.Parameters.AddWithValue("@NextServicingDate", Convert.ToDateTime(date));
            //sc.Parameters.AddWithValue("@OwnerName", OwnerName);

            ////sc.ExecuteNonQuery();
            //i = sc.ExecuteNonQuery();
            //if (i != 0)
            //{
            //    Console.WriteLine("Data inserted");
            //}
            //sqlC.Close();

            // Execute Scalar
            SqlCommand sqlEX = new SqlCommand("SELECT COUNT(CarModels) FROM tble_Cars", sqlC);
            sqlC.Open();
            int count = Convert.ToInt32(sqlEX.ExecuteScalar());
            sqlC.Close();




            // sql data reader
            SqlCommand sqlRdr = new SqlCommand("SELECT CarId,CarModels,CurrentServicingDate,OwnerName FROM tble_Cars", sqlC);
            sqlC.Open();
            SqlDataReader dr = sqlRdr.ExecuteReader();
            DataTable dtCar = new DataTable();
            dtCar.Load(dr);
            sqlC.Close();


            //  sql delete command
            //Console.WriteLine("enter car id");
            //var id = Convert.ToInt32(Console.ReadLine());
            //SqlCommand cmdDelete = new SqlCommand("DELETE FROM tble_Cars WHERE CarId= " + id + " ", sqlC);
            //sqlC.Open();
            //cmdDelete.ExecuteNonQuery();
            //sqlC.Close();

            // sql update command
            Console.WriteLine("enter car id");
            var carid = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmdUpdate = new SqlCommand("UPDATE tble_Cars SET CarModels = @CarModels ,OwnerName = @OwnerName WHERE CarId = '" + carid + "'", sqlC);
            sqlC.Open();
            cmdUpdate.Parameters.AddWithValue("@CarModels", "Skoda");
            //cmdUpdate.Parameters.AddWithValue("@NextServicingDate", Convert.ToDateTime("10/02/1999"));
            cmdUpdate.Parameters.AddWithValue("@OwnerName", "Angelina");
            cmdUpdate.ExecuteNonQuery();
            sqlC.Close();

            Console.ReadKey();

            //Console.WriteLine("enter car id");
            //var carid = Convert.ToInt32(Console.ReadLine());

            //SqlCommand cmdUpdate = new SqlCommand("UPDATE tble_Cars SET CarModels = @CarModels ,NextServicingDate = CONVERT(10 / 02 / 1999,@NextServicingDate,103)  ,OwnerName = @OwnerName WHERE CarId = '" + carid + "'", sqlC);
            //sqlC.Open();
            //cmdUpdate.Parameters.AddWithValue("@CarModels", "Skoda");
            //cmdUpdate.Parameters.AddWithValue("@NextServicingDate", Convert.ToDateTime("10/02/1999"));
            //cmdUpdate.Parameters.AddWithValue("@OwnerName", "Angelina");
            //cmdUpdate.ExecuteNonQuery();
            //sqlC.Close();

        }
    }
}
