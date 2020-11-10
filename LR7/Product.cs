using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    class Product
    {
        private MySqlConnection connection = null;
        private int id = 0;
        private int c_id = 0;
        private string p_name;
        private int cost;
        private string photo;
        private Image image;

        public Product(MySqlConnection connection) => this.connection = connection;
        public Product(string p_name, int c_id)
        {
            this.P_name = p_name;
            this.C_id = c_id;
        }

        public Product(int id, string p_name, int c_id)
        {
            this.Id = id;
            this.P_name = p_name;
            this.C_id = c_id;
        }

        public Product(int id, int c_id, string p_name, int cost)
        {
            this.Id = id;
            this.C_id = c_id;
            this.P_name = p_name;
            this.Cost = cost;
        }

        public string P_name { get => p_name; set => p_name = value; }
        public string Photo { get => photo; set => photo = value; }
        public int C_id { get => c_id; set => c_id = value; }
        public int Id { get => id; set => id = value; }
        public int Cost { get => cost; set => cost = value; }

        private int Len()
        {
            return 0;
        }

        public Product Next()
        {
            id++;
            Product product = null;
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"SELECT id, p_name, c_id, cost FROM products where id={Id}";
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                product = new Product(Convert.ToInt32(reader["id"].ToString()), reader["p_name"].ToString(), Convert.ToInt32(reader["cost"].ToString()));
            }

            connection.Close();

            return product;
        }
        
        public Product Now()
        {
            Product product = null;
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"SELECT id, p_name, c_id, cost FROM products where id={Id}";
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                product = new Product(Convert.ToInt32(reader["id"].ToString()), reader["p_name"].ToString(), Convert.ToInt32(reader["cost"].ToString()));
            }

            connection.Close();

            return product;
        }

        public Product Previous()
        {
            id--;
            Product product = null;
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"SELECT id, p_name, c_id, cost FROM products where id={Id}";
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                product = new Product(Convert.ToInt32(reader["id"].ToString()), reader["p_name"].ToString(), Convert.ToInt32(reader["cost"].ToString()));
            }

            connection.Close();

            return product;
        }

    

    }
}
