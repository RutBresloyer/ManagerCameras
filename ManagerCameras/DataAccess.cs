using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCameras
{
    public class DataAccess
    {
        public int InsertData(string conectionString)
        {
            int catagoryId, price;

            string name, description, img;
            Console.WriteLine("insert catagory id");
            catagoryId = int.Parse(Console.ReadLine());
            Console.WriteLine("insert name");
            name = Console.ReadLine();
            Console.WriteLine("insert price");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("insert description");
            description = Console.ReadLine();
            Console.WriteLine("insert img");
            img = Console.ReadLine();



            string query = "INSERT INTO Products (catagoryId,name,price,description,img)" +
            "VALUES (@catagoryId,@name,@price,@description,@img)";


            using (SqlConnection cn = new SqlConnection(conectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@catagoryId", SqlDbType.Int).Value = catagoryId;
                cmd.Parameters.Add("@name", SqlDbType.NChar, 20).Value = @name;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = price;
                cmd.Parameters.Add("@description", SqlDbType.NChar, 20).Value = description;
                cmd.Parameters.Add("@img", SqlDbType.VarChar, 50).Value = img;
                cn.Open();
                int rowes = cmd.ExecuteNonQuery();
                cn.Close();
                return rowes;

            }
        }

            public void ReadData(string conectionString)
            {
            string query = "select * from products";

                    using(SqlConnection cn = new SqlConnection(conectionString))
            {
             SqlCommand cmd = new SqlCommand(query, cn);
                try
                {
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}", reader[0]);

                    }
                    reader.Close();
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }

Console.ReadLine();
            }
            


    }
}
