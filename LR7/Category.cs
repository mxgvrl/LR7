using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR7
{
    class Category
    {
        private MySqlConnection connection = null;
        private int c_id = 1;
        private string c_name;
        private int warranty;
        private string photo;
        private Image image;

        public Category(MySqlConnection connection) => this.connection = connection;

        public Category(int c_id, string c_name, int warranty, Image image)
        {
            this.c_id = c_id;
            this.c_name = c_name;
            this.Warranty = warranty;
            this.Image = image;
        }

        public int C_id { get => c_id; set => c_id = value; }
        public string C_name { get => c_name; set => c_name = value; }
        public string Photo { get => photo; set => photo = value; }
        public Image Image { get => image; set => image = value; }
        public int Warranty { get => warranty; set => warranty = value; }

        private int Len()
        {
            return 0;
        }

        public Category Now(int cat_id)
        {
            Category category = null;
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"SELECT c_id, c_name, warranty, photo FROM categoryes where c_id = {cat_id}";
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                category = new Category(Convert.ToInt32(reader["c_id"].ToString()), reader["c_name"].ToString(), Convert.ToInt32(reader["warranty"].ToString()), Image.FromFile(Directory.GetCurrentDirectory() + reader["photo"].ToString()));
            }

            connection.Close();
            return category;
        }
        
        public Category Next()
        {
            C_id++;
            Category category = null;
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"SELECT c_id, c_name, warranty, photo FROM categoryes where c_id={C_id}";
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                category = new Category(Convert.ToInt32(reader["c_id"].ToString()), reader["c_name"].ToString(), Convert.ToInt32(reader["warranty"].ToString()), Image.FromFile(Directory.GetCurrentDirectory() + reader["photo"].ToString()));
            }

            connection.Close();
            return category;
        }

        public Category Previous()
        {
            C_id--;
            Category category = null;
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"SELECT c_id, c_name, warranty, photo FROM categoryes where c_id={C_id}";
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                category = new Category(Convert.ToInt32(reader["c_id"].ToString()), reader["c_name"].ToString(), Convert.ToInt32(reader["warranty"].ToString()), Image.FromFile(Directory.GetCurrentDirectory() + reader["photo"].ToString()));
            }

            connection.Close();

            return category;
        }
    } 
}
