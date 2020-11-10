using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR7
{
    public partial class Form1 : Form
    {
        Product product = null;
        Category category = null;
        CategoryProduct categoryProduct = null;
        MySqlConnection connection = null;
        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=127.0.0.1;user=root;database=lr7;port=3306;password=root;");
            product = new Product(connection);
            category = new Category(connection);
            categoryProduct = new CategoryProduct(connection);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tbCategId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    lbProducts.Items.Clear();
                    categoryProduct.C_id = 0;

                    Category it_category = category.Now(Convert.ToInt32(tbCategId.Text));
                    tbCategId.Text = it_category.C_id.ToString();
                    tbCategName.Text = it_category.C_name.ToString();
                    picBCateg.BackgroundImage = it_category.Image;

                    foreach (CategoryProduct item in categoryProduct.GetCategoryProduct(connection, it_category.C_id))
                    {
                        lbProducts.Items.Add("Name = " + item.P_name + ", category = " + item.C_name + ", cost = " + item.Cost);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(Directory.GetCurrentDirectory());
                    MessageBox.Show("Дальше значений нет");
                }
            }

        }

        private void btnNextCateg_Click(object sender, EventArgs e)
        {
            try
            {
                lbProducts.Items.Clear();
                categoryProduct.C_id = 0;
                Category it_category = category.Next();
                tbCategId.Text = it_category.C_id.ToString();
                tbCategName.Text = it_category.C_name.ToString();
                picBCateg.BackgroundImage = it_category.Image;
                foreach (CategoryProduct item in categoryProduct.GetCategoryProduct(connection, it_category.C_id))
                {
                    lbProducts.Items.Add("Name = " + item.P_name + ", category = " + item.C_name + ", cost = " + item.Cost);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Next value is null");
            }
        }

        private void btnPrevCateg_Click(object sender, EventArgs e)
        {
            try
            {
                lbProducts.Items.Clear();
                categoryProduct.C_id = 0;
                Category it_category = category.Previous();
                tbCategId.Text = it_category.C_id.ToString();
                tbCategName.Text = it_category.C_name.ToString();
                picBCateg.BackgroundImage = it_category.Image;
                foreach (CategoryProduct item in categoryProduct.GetCategoryProduct(connection, it_category.C_id))
                {
                    lbProducts.Items.Add("Name = " + item.P_name + ", category = " + item.C_name + ", cost = " + item.Cost);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Previous value is null");
            }        
        }
        
        // ----------------- EDIT CATEGORY TABLE STUFF -----------------
        private int getLengthCategoryes()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"select count(*) from categoryes;";
            command.Connection = connection;
            connection.Open();
            string answer = command.ExecuteScalar().ToString();
            connection.Close();
            return int.Parse(answer);
        }
        
        private bool isRowExists(string name)
        {
            bool flag;
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"select exists(select * from categoryes where c_name='{name}');";
            command.Connection = connection;
            connection.Open();
            if (command.ExecuteScalar().ToString() == "1")
                flag = true;
            else
                flag = false;
            connection.Close();
            return flag;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if(tbAddCategName.Text != "" && tbAddCategWrnty.Text != "" && tbAddCategCare.Text !="" && tbAddCategAvailable.Text != "" && tbAddCategPhoto.Text!="")
            {
                if (!isRowExists(tbAddCategName.Text))
                {
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = $"insert into categoryes values({(getLengthCategoryes() + 1)}, '{tbAddCategName.Text}', {Convert.ToInt32(tbAddCategWrnty.Text)}, '{tbAddCategCare.Text}', {Convert.ToInt32(tbAddCategAvailable.Text)}, '{tbAddCategPhoto.Text}');";
                    command.Connection = connection;
                    connection.Open();
                    command.ExecuteScalar();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("This category name is already exists");
                }
            }
            else
            {
                MessageBox.Show("Fill empty fields");
            }
        }

        private void tbAddCategPhoto_Click(object sender, EventArgs e)
        {
            ofdAddCategory.ShowDialog();
            File.Copy(ofdAddCategory.FileName, Directory.GetCurrentDirectory().Replace('\\', '/') + "/images/" + ofdAddCategory.FileName.Split('\\').Last(), true);
            tbAddCategPhoto.Text = "/images/" + ofdAddCategory.FileName.Split('\\').Last();
        }

        private void btnDelCateg_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "The Title", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (tbDelCategName.Text != "")
                {
                    if (isRowExists(tbDelCategName.Text))
                    {
                        MySqlCommand command = new MySqlCommand();
                        command.CommandText = $"delete from categoryes where c_name = '{tbDelCategName.Text}';";
                        command.Connection = connection;
                        connection.Open();
                        command.ExecuteScalar();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("There are no any fields like this");
                    }

                }
                else
                {
                    MessageBox.Show("Fill empty fields");
                }
            }
            
        }

        // ------------------- PRODUCT ADDING STUFF ------------------------
        private void btnAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cdAddProdC_id.Text != "" && 
                    tbAddProdName.Text != "" && 
                    tbAddProdMaterial.Text != "" &&
                    tbAddProdColor.Text != "" &&
                    tbAddProdCost.Text != "" &&
                    tbAddProdCount.Text != "" &&
                    tbAddProdAvailable.Text != "")
                {
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = $"insert into products values({getLengthProducts() + 1}, " +
                                          $"'{tbAddProdName.Text}', " +
                                          $"{Convert.ToInt32(cdAddProdC_id.Text)}, " +
                                          $"'{tbAddProdMaterial.Text}', " +
                                          $"'{tbAddProdColor.Text}', " +
                                          $"{Convert.ToInt32(tbAddProdCost.Text)}, " +
                                          $"{Convert.ToInt32(tbAddProdCount.Text)}, " +
                                          $"{Convert.ToInt32(tbAddProdAvailable.Text)});";
                    command.Connection = connection;
                    connection.Open();
                    command.ExecuteScalar();
                    connection.Close();
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("Fill empty fields");
                }
            
            
            }
            catch
            {
                MessageBox.Show("incorrect");
                tabControl1.SelectTab(2);
            }
        }

        private void cdAddProdC_id_Click(object sender, EventArgs e)
        {
            if (cdAddProdC_id.Text == "")
            {
                cdAddProdC_id.Items.Clear();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = $"SELECT c_id FROM categoryes";
                command.Connection = connection;
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cdAddProdC_id.Items.Add(reader["c_id"].ToString());
                }
                connection.Close();
            }
            else
            {
                searchId(cdAddProdC_id.Text);
            }
        }
        
        private int getLengthProducts()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"select count(*) from products;";
            command.Connection = connection;
            connection.Open();
            string answer = command.ExecuteScalar().ToString();
            connection.Close();
            return int.Parse(answer);
        }
        
        private void searchId(string id)
        {
            cdAddProdC_id.Items.Clear();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"SELECT c_id FROM categoryes where c_id = {id}";
            command.Connection = connection;
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cdAddProdC_id.Items.Add(reader["c_id"].ToString());
            }

            if (cdAddProdC_id.Items.Count == 0)
            {
                if (MessageBox.Show("There no such category. Add new category?", "The Title",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    tabControl1.SelectTab(2);
                }
                
            }
            connection.Close();
        }

        private void btnDelProd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "The Title", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (tbDelProdName.Text != "")
                {
                    if (isRowExistsProducts(tbDelProdName.Text))
                    {
                        MySqlCommand command = new MySqlCommand();
                        command.CommandText = $"delete from products where p_name = '{tbDelProdName.Text}';";
                        command.Connection = connection;
                        connection.Open();
                        command.ExecuteScalar();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("There are no any fields like this");
                    }

                }
                else
                {
                    MessageBox.Show("Fill empty fields");
                }
            }
        }
        
        private bool isRowExistsProducts(string name)
        {
            bool flag;
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"select exists(select * from products where p_name='{name}');";
            command.Connection = connection;
            connection.Open();
            if (command.ExecuteScalar().ToString() == "1")
                flag = true;
            else
                flag = false;
            connection.Close();
            return flag;
        }
        
        
        // ---------------- SALE ADDING STUFF ----------------------
        
        private void btnAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbAddSalesP_id.Text != "" && 
                    tbAddSaleSize.Text != "" && 
                    tbAddSaleCount.Text != "" &&
                    tbAddSaleDiscount.Text != "" &&
                    tbAddSaleDate.Text != "")
                {
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = $"insert into sales values({getLengthSales() + 1}, " +
                                          $"{Convert.ToInt32(cbAddSalesP_id.Text)}, " +
                                          $"{Convert.ToInt32(tbAddSaleSize.Text)}, " +
                                          $"{Convert.ToInt32(tbAddSaleCount.Text)}, " +
                                          $"{Convert.ToInt32(tbAddSaleDiscount.Text)}, " +
                                          $"'{tbAddSaleDate.Text}');";
                    command.Connection = connection;
                    connection.Open();
                    command.ExecuteScalar();
                    connection.Close();
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("Fill empty fields");
                }
            }
            catch
            {
                MessageBox.Show("incorrect");
                tabControl1.SelectTab(3);
            }
        }
        
        private int getLengthSales()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"select count(*) from sales;";
            command.Connection = connection;
            connection.Open();
            string answer = command.ExecuteScalar().ToString();
            connection.Close();
            return int.Parse(answer);
        }

        private void btnShowSales_Click(object sender, EventArgs e)
        {
            lbSales.Items.Clear();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"SELECT s_id, p_id, size, sale_count, discount, sale_date FROM sales";
            command.Connection = connection;
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lbSales.Items.Add(reader["s_id"].ToString() + "  " + reader["p_id"].ToString() + "  " + reader["size"].ToString() + "  " + reader["sale_count"].ToString() + "  " + reader["discount"].ToString() + "  " + reader["sale_date"].ToString());
            }
            connection.Close();
        }

        private void cbAddSalesP_id_Click(object sender, EventArgs e)
        {
            cbAddSalesP_id.Items.Clear();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"SELECT p_id FROM products";
            command.Connection = connection;
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbAddSalesP_id.Items.Add(reader["p_id"].ToString());
            }
            connection.Close();
        }

        private void btnDelSale_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "The Title", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                if (tbDelSalesId.Text != "")
                {
                    if (isRowExistsSales(Convert.ToInt32(tbDelSalesId.Text)))
                    {
                        MySqlCommand command = new MySqlCommand();
                        command.CommandText = $"delete from sales where s_id = '{Convert.ToInt32(tbDelSalesId.Text)}';";
                        command.Connection = connection;
                        connection.Open();
                        command.ExecuteScalar();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("There are no any fields like this");
                    }
                }
                else
                {
                    MessageBox.Show("Fill empty fields");
                }
            }
        }
        
        private bool isRowExistsSales(int id)
        {
            bool flag;
            MySqlCommand command = new MySqlCommand();
            command.CommandText = $"select exists(select * from sales where s_id='{id}');";
            command.Connection = connection;
            connection.Open();
            if (command.ExecuteScalar().ToString() == "1")
                flag = true;
            else
                flag = false;
            connection.Close();
            return flag;
        }
    }
}

