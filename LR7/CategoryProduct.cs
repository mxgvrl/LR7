using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    public class CategoryProduct
    {
        private MySqlConnection connection = null;
        private int id = 0;
        private int c_id = 0;
        private string c_name;
        private string p_name;
        private int cost;

        public int Id { get => id; set => id = value; }
        public int C_id { get => c_id; set => c_id = value; }
        public string C_name { get => c_name; set => c_name = value; }
        public int Cost { get => cost; set => cost = value; }
        public string P_name { get => p_name; set => p_name = value; }

        public CategoryProduct(MySqlConnection connection) => this.connection = connection;

        public CategoryProduct(int id, int c_id, string c_name, string p_name, int cost)
        {
            Id = id;
            C_id = c_id;
            C_name = c_name;
            P_name = p_name;
            Cost = cost;
        }

        public CategoryProduct(int c_id, string c_name, string p_name, int cost)
        {
            C_id = c_id;
            C_name = c_name;
            P_name = p_name;
            Cost = cost;
        }

        private int Len()
        {
            return 0;
        }

        //public CategoryProduct Next() // todo: do next method for class
        //{
        //    Id++;
        //    Product product = null;
        //    connection.Open();
        //    MySqlCommand command = new MySqlCommand();
        //    command.CommandText = $"SELECT id, p_name, c_id FROM products where id={Id}";
        //    command.Connection = connection;
        //    MySqlDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        product = new Product(Convert.ToInt32(reader["id"].ToString()), reader["p_name"].ToString(), Convert.ToInt32(reader["c_id"].ToString()));
        //    }

        //    connection.Close();

        //    return product;
        //}

        //public Product Previous()
        //{
        //    Id--;
        //    Product product = null;
        //    connection.Open();
        //    MySqlCommand command = new MySqlCommand();
        //    command.CommandText = $"SELECT id, p_name, c_id FROM products where id={Id}";
        //    command.Connection = connection;
        //    MySqlDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        product = new Product(Convert.ToInt32(reader["id"].ToString()), reader["p_name"].ToString(), Convert.ToInt32(reader["c_id"].ToString()));
        //    }

        //    connection.Close();

        //    return product;
        //}

        public List<CategoryProduct> GetCategoryProduct(MySqlConnection connection, int categ_id)
        {
            List<CategoryProduct> lCategProd = new List<CategoryProduct>();
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"SELECT (select c_name from categoryes where categoryes.c_id=c_id limit 1) as categ_name, c_id, p_name, cost FROM products where c_id={categ_id};";
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lCategProd.Add(new CategoryProduct(int.Parse(reader["c_id"].ToString()), reader["categ_name"].ToString(), reader["p_name"].ToString(), int.Parse(reader["cost"].ToString())));
            }

            connection.Close();

            return lCategProd;
        }
    }
}

