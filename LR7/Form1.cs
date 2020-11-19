using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using Xceed.Words.NET;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace LR7 {
    public partial class Form1 : Form {
        private readonly Category category;
        private readonly CategoryProduct categoryProduct;
        private readonly MySqlConnection connection;
        private Product product;

        public Form1() {
            InitializeComponent();
            connection = new MySqlConnection("server=127.0.0.1;user=root;database=lr7;port=3306;password=root;");
            product = new Product(connection);
            category = new Category(connection);
            categoryProduct = new CategoryProduct(connection);
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
        }

        private void tbCategId_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                try {
                    lbProducts.Items.Clear();
                    categoryProduct.C_id = 0;

                    var it_category = category.Now(Convert.ToInt32(tbCategId.Text));
                    tbCategId.Text = it_category.C_id.ToString();
                    tbCategName.Text = it_category.C_name;
                    picBCateg.BackgroundImage = it_category.Image;

                    foreach (var item in categoryProduct.GetCategoryProduct(connection, it_category.C_id))
                        lbProducts.Items.Add("Name = " + item.P_name + ", category = " + item.C_name + ", cost = " +
                                             item.Cost);
                }
                catch (Exception) {
                    MessageBox.Show(Directory.GetCurrentDirectory());
                    MessageBox.Show("Дальше значений нет");
                }
        }

        private void btnNextCateg_Click(object sender, EventArgs e) {
            try {
                lbProducts.Items.Clear();
                categoryProduct.C_id = 0;
                var it_category = category.Next();
                tbCategId.Text = it_category.C_id.ToString();
                tbCategName.Text = it_category.C_name;
                picBCateg.BackgroundImage = it_category.Image;
                foreach (var item in categoryProduct.GetCategoryProduct(connection, it_category.C_id))
                    lbProducts.Items.Add("Name = " + item.P_name + ", category = " + item.C_name + ", cost = " +
                                         item.Cost);
            }
            catch (Exception) {
                MessageBox.Show("Next value is null");
            }
        }

        private void btnPrevCateg_Click(object sender, EventArgs e) {
            try {
                lbProducts.Items.Clear();
                categoryProduct.C_id = 0;
                var it_category = category.Previous();
                tbCategId.Text = it_category.C_id.ToString();
                tbCategName.Text = it_category.C_name;
                picBCateg.BackgroundImage = it_category.Image;
                foreach (var item in categoryProduct.GetCategoryProduct(connection, it_category.C_id))
                    lbProducts.Items.Add("Name = " + item.P_name + ", category = " + item.C_name + ", cost = " +
                                         item.Cost);
            }
            catch (Exception) {
                MessageBox.Show("Previous value is null");
            }
        }

        // ----------------- EDIT CATEGORY TABLE STUFF -----------------
        private int getLengthCategoryes() {
            var command = new MySqlCommand();
            command.CommandText = "select count(*) from categoryes;";
            command.Connection = connection;
            connection.Open();
            var answer = command.ExecuteScalar().ToString();
            connection.Close();
            return int.Parse(answer);
        }

        private bool isRowExists(string name) {
            bool flag;
            var command = new MySqlCommand();
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

        private void btnAddCategory_Click(object sender, EventArgs e) {
            if (tbAddCategName.Text != "" && tbAddCategWrnty.Text != "" && tbAddCategCare.Text != "" &&
                tbAddCategAvailable.Text != "" && tbAddCategPhoto.Text != "") {
                if (!isRowExists(tbAddCategName.Text)) {
                    var command = new MySqlCommand();
                    command.CommandText =
                        $"insert into categoryes values({getLengthCategoryes() + 1}, '{tbAddCategName.Text}', {Convert.ToInt32(tbAddCategWrnty.Text)}, '{tbAddCategCare.Text}', {Convert.ToInt32(tbAddCategAvailable.Text)}, '{tbAddCategPhoto.Text}');";
                    command.Connection = connection;
                    connection.Open();
                    command.ExecuteScalar();
                    connection.Close();
                }
                else {
                    MessageBox.Show("This category name is already exists");
                }
            }
            else {
                MessageBox.Show("Fill empty fields");
            }
        }

        private void tbAddCategPhoto_Click(object sender, EventArgs e) {
            ofdAddCategory.ShowDialog();
            File.Copy(ofdAddCategory.FileName,
                Directory.GetCurrentDirectory().Replace('\\', '/') + "/images/" +
                ofdAddCategory.FileName.Split('\\').Last(), true);
            tbAddCategPhoto.Text = "/images/" + ofdAddCategory.FileName.Split('\\').Last();
        }

        private void btnDelCateg_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to delete?", "The Title",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes) {
                if (tbDelCategName.Text != "") {
                    if (isRowExists(tbDelCategName.Text)) {
                        var command = new MySqlCommand();
                        command.CommandText = $"delete from categoryes where c_name = '{tbDelCategName.Text}';";
                        command.Connection = connection;
                        connection.Open();
                        command.ExecuteScalar();
                        connection.Close();
                    }
                    else {
                        MessageBox.Show("There are no any fields like this");
                    }
                }
                else {
                    MessageBox.Show("Fill empty fields");
                }
            }
        }

        // ------------------- PRODUCT ADDING STUFF ------------------------
        private void btnAddProd_Click(object sender, EventArgs e) {
            try {
                if (cdAddProdC_id.Text != "" &&
                    tbAddProdName.Text != "" &&
                    tbAddProdMaterial.Text != "" &&
                    tbAddProdColor.Text != "" &&
                    tbAddProdCost.Text != "" &&
                    tbAddProdCount.Text != "" &&
                    tbAddProdAvailable.Text != "") {
                    var command = new MySqlCommand();
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
                else {
                    MessageBox.Show("Fill empty fields");
                }
            }
            catch {
                MessageBox.Show("incorrect");
                tabControl1.SelectTab(2);
            }
        }

        private void cdAddProdC_id_Click(object sender, EventArgs e) {
            if (cdAddProdC_id.Text == "") {
                cdAddProdC_id.Items.Clear();
                var command = new MySqlCommand();
                command.CommandText = "SELECT c_id FROM categoryes";
                command.Connection = connection;
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read()) cdAddProdC_id.Items.Add(reader["c_id"].ToString());
                connection.Close();
            }
            else {
                searchId(cdAddProdC_id.Text);
            }
        }

        private int getLengthProducts() {
            var command = new MySqlCommand();
            command.CommandText = "select count(*) from products;";
            command.Connection = connection;
            connection.Open();
            var answer = command.ExecuteScalar().ToString();
            connection.Close();
            return int.Parse(answer);
        }

        private void searchId(string id) {
            cdAddProdC_id.Items.Clear();
            var command = new MySqlCommand();
            command.CommandText = $"SELECT c_id FROM categoryes where c_id = {id}";
            command.Connection = connection;
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read()) cdAddProdC_id.Items.Add(reader["c_id"].ToString());

            if (cdAddProdC_id.Items.Count == 0)
                if (MessageBox.Show("There no such category. Add new category?", "The Title",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    tabControl1.SelectTab(2);
            connection.Close();
        }

        private void btnDelProd_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to delete?", "The Title",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes) {
                if (tbDelProdName.Text != "") {
                    if (isRowExistsProducts(tbDelProdName.Text)) {
                        var command = new MySqlCommand();
                        command.CommandText = $"delete from products where p_name = '{tbDelProdName.Text}';";
                        command.Connection = connection;
                        connection.Open();
                        command.ExecuteScalar();
                        connection.Close();
                    }
                    else {
                        MessageBox.Show("There are no any fields like this");
                    }
                }
                else {
                    MessageBox.Show("Fill empty fields");
                }
            }
        }

        private bool isRowExistsProducts(string name) {
            bool flag;
            var command = new MySqlCommand();
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

        private void btnAddSale_Click(object sender, EventArgs e) {
            try {
                if (cbAddSalesP_id.Text != "" &&
                    tbAddSaleSize.Text != "" &&
                    tbAddSaleCount.Text != "" &&
                    tbAddSaleDiscount.Text != "" &&
                    tbAddSaleDate.Text != "") {
                    var command = new MySqlCommand();
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
                else {
                    MessageBox.Show("Fill empty fields");
                }
            }
            catch {
                MessageBox.Show("incorrect");
                tabControl1.SelectTab(3);
            }
        }

        private int getLengthSales() {
            var command = new MySqlCommand();
            command.CommandText = "select count(*) from sales;";
            command.Connection = connection;
            connection.Open();
            var answer = command.ExecuteScalar().ToString();
            connection.Close();
            return int.Parse(answer);
        }

        private void btnShowSales_Click(object sender, EventArgs e) {
            lbSales.Items.Clear();
            var command = new MySqlCommand();
            command.CommandText = "SELECT s_id, p_id, size, sale_count, discount, sale_date FROM sales";
            command.Connection = connection;
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
                lbSales.Items.Add(reader["s_id"] + "  " + reader["p_id"] + "  " + reader["size"] + "  " +
                                  reader["sale_count"] + "  " + reader["discount"] + "  " + reader["sale_date"]);
            connection.Close();
        }

        private void cbAddSalesP_id_Click(object sender, EventArgs e) {
            cbAddSalesP_id.Items.Clear();
            var command = new MySqlCommand();
            command.CommandText = "SELECT p_id FROM products";
            command.Connection = connection;
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read()) cbAddSalesP_id.Items.Add(reader["p_id"].ToString());
            connection.Close();
        }

        private void btnDelSale_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to delete?", "The Title",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes) {
                if (tbDelSalesId.Text != "") {
                    if (isRowExistsSales(Convert.ToInt32(tbDelSalesId.Text))) {
                        var command = new MySqlCommand();
                        command.CommandText = $"delete from sales where s_id = '{Convert.ToInt32(tbDelSalesId.Text)}';";
                        command.Connection = connection;
                        connection.Open();
                        command.ExecuteScalar();
                        connection.Close();
                    }
                    else {
                        MessageBox.Show("There are no any fields like this");
                    }
                }
                else {
                    MessageBox.Show("Fill empty fields");
                }
            }
        }

        private bool isRowExistsSales(int id) {
            bool flag;
            var command = new MySqlCommand();
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

        public List<List<string>> SelectFromTable(string nameTable) {
            var answer = new List<List<string>>();
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"select * from {nameTable};";
            var dataReader = command.ExecuteReader();
            while (dataReader.Read()) {
                answer.Add(new List<string>());
                for (var i = 0; i < dataReader.FieldCount; i++) answer[answer.Count - 1].Add(dataReader[i].ToString());
            }

            connection.Close();
            return answer;
        }
        
        public List<List<string>> QueryParser(string query) {
            var answer = new List<List<string>>();
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"{query}";
            var dataReader = command.ExecuteReader();
            while (dataReader.Read()) {
                answer.Add(new List<string>());
                for (var i = 0; i < dataReader.FieldCount; i++) {
                    answer[answer.Count - 1].Add(dataReader[i].ToString());
                }
            }
            connection.Close();
            return answer;
        }

        public void doubleListToListBox(List<List<string>> doubleList) {
            lbOut.Items.Clear();
            var k = "";
            foreach (var i in doubleList) {
                k = i.Aggregate(k, (current, j) => current + (j + " | "));
                lbOut.Items.Add(k);
                k = "";
            }
        }

        private void btnQ1_Click(object sender, EventArgs e) {
            string query = 
                $"select sale_count * (select cost from products where sales.p_id = p_id) - discount AS result from sales;";
            var answer = QueryParser(query);
            doubleListToListBox(answer);
        }

        private void btnQ2_Click(object sender, EventArgs e) {
            string query = 
                $"select products.p_name, products.cost, sales.size from products join sales on products.p_id = sales.p_id" +
                $" where products.cost < {tbQ2Cost.Text} and sales.size = {tbQ2Size.Text};";
            var answer = QueryParser(query);
            doubleListToListBox(answer);
        }

        private void btnQ3_Click(object sender, EventArgs e) {
            string query = 
                $"select p_name from products where count_base = (select max(count_base) from products);";
            var answer = QueryParser(query);
            doubleListToListBox(answer);
        }

        private void btnQ4_Click(object sender, EventArgs e) {
            string query = 
                $"select products.p_name, products.cost, sales.sale_date, sales.sale_count " +
                $"from products join sales on products.p_id = sales.p_id " +
                $"where sales.sale_date = now() and sales.sale_count < {tbQ4.Text};";
            var answer = QueryParser(query);
            doubleListToListBox(answer);
        }

        private void btnQ5_Click(object sender, EventArgs e) {
            string query = 
                $"select c_id, cost " +
                $"from products " +
                $"where (select avg(cost) from products) > {tbQ5.Text} " +
                $"group by c_id ;";
            var answer = QueryParser(query);
            doubleListToListBox(answer); 
        }

        private void btnQ6_Click_1(object sender, EventArgs e) {
            string query =
                $"select sum(sale_count) " +
                $"from sales " +
                $"where month(sale_date) = 9";
            var answer = QueryParser(query);
            doubleListToListBox(answer); 
        }
        
        private void btnQ7_Click(object sender, EventArgs e) {
            string query =
                $"select sum(sale_count) " +
                $"from sales " +
                $"group by sale_date";
            var answer = QueryParser(query);
            doubleListToListBox(answer); 
        }

        private void btnQ8_Click(object sender, EventArgs e) {
            string query =
                $"select categoryes.c_name, sum(sales.sale_count)  " +
                $"from sales inner join  products inner join categoryes  " +
                $"on sales.p_id = products.p_id and products.c_id = categoryes.c_id " +
                $"group by categoryes.c_id " +
                $"having sum(sales.sale_count) < {tbQ8.Text};";
            var answer = QueryParser(query);
            doubleListToListBox(answer); 
        }
        
        private void btnQ9_Click(object sender, EventArgs e) {
            string query =
                $"select products.p_name, sales.sale_count " +
                $"from products join sales on products.p_id = sales.p_id " +
                $"where not exists(select * from sales where p_id = products.p_id);";
            var answer = QueryParser(query);
            doubleListToListBox(answer);
        }
        
        private void btnQ10_Click(object sender, EventArgs e) {
            string query =
                $"select products.p_name, avg(sales.discount) " +
                $"from sales inner join  products inner join categoryes  " +
                $"on sales.p_id = products.p_id and products.c_id = categoryes.c_id " +
                $"where categoryes.c_name = '{tbQ10.Text}' " +
                $"group by categoryes.c_id";
            var answer = QueryParser(query);
            doubleListToListBox(answer);
        }

        private void btnCheck_Click(object sender, EventArgs e) {
            var document = DocX.Create(Path.Combine(Environment.CurrentDirectory, "_Check.docx"));
            var query = $"select sales.sale_date, sales.p_id, sales.sale_count from sales;";

            var answer = QueryParser(query);

            var tableShoeCategory = document.AddTable(answer.Count()+1, 3);
            tableShoeCategory.Rows[0].Cells[0].Paragraphs[0].Append("date");
            tableShoeCategory.Rows[0].Cells[1].Paragraphs[0].Append("p_id");
            tableShoeCategory.Rows[0].Cells[2].Paragraphs[0].Append("count");

            tableShoeCategory.Rows[0].Cells[0].FillColor = Color.Moccasin;
            tableShoeCategory.Rows[0].Cells[1].FillColor = Color.Moccasin;
            tableShoeCategory.Rows[0].Cells[2].FillColor = Color.Moccasin;

            var c = 1;
            var d = 0;
            foreach (var items in answer) {
                foreach (var item in items) {
                    tableShoeCategory.Rows[c].Cells[d].Paragraphs[0].Append(item);
                    d++;
                }
                d = 0;
                c++;
            }
            document.InsertParagraph().InsertTableAfterSelf(tableShoeCategory);
            document.SaveAs(Environment.CurrentDirectory + "\\Check.docx");
        }

        private void btnExcelReport_Click(object sender, EventArgs e) {
            var query = $"select sales.sale_date, sales.p_id, sales.sale_count from sales;";
            var query1 = $"select sales.sale_date, products.p_name, sales.sale_count " + // Чтобы Ирина Юрьевна поверила, что я умный парень
                         $"from sales join products on sales.p_id = products.p_id " +
                         $"where sales.sale_date = now() ;";
            var answer = QueryParser(query);

            var _application = new Application { DisplayAlerts = false };
            var workbook = _application.Workbooks.Open(
                Path.Combine(Environment.CurrentDirectory, "Report.xlsx")
            );
            
            var worksheet = workbook.ActiveSheet as Worksheet;
            worksheet = workbook.Sheets.Add() as Worksheet;
            worksheet.Cells[1, 1] = "date";
            worksheet.Cells[1, 2] = "p_id";
            worksheet.Cells[1, 3] = "cost";

            var range = worksheet.Range["A1", "C1"];
            range.Borders.Item[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            range.Borders.Item[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            range.Borders.Item[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            range.Borders.Item[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            range.Borders.Item[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            range.Cells.Font.Color = Color.Gray;
            range.Interior.Color = Color.Wheat;
            var c = 2;
            var d = 1;
            
            foreach (var items in answer) {
                foreach (var item in items) {
                    worksheet.Cells[c, d] = item;
                    
                    range = worksheet.Range[$"A{c}", $"C{c}"];
                    range.Borders.Item[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
                    range.Borders.Item[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
                    range.Borders.Item[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
                    range.Borders.Item[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                    range.Borders.Item[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
                    d++;
                }
                d = 1;
                c++;
            }

            _application.Visible = true;
            TopMost = true;
        }

        private void btnLabel_Click(object sender, EventArgs e) {
            var document = DocX.Create(Path.Combine(Environment.CurrentDirectory, "Label.docx"));
            var query = $"select p_name, material, color, cost, count_base from products where p_name = '{tbProdNameLabel.Text}';";

            var answer = QueryParser(query);

            var tableShoeCategory = document.AddTable(answer.Count()+1, 5);
            tableShoeCategory.Rows[0].Cells[0].Paragraphs[0].Append("name");
            tableShoeCategory.Rows[0].Cells[1].Paragraphs[0].Append("material");
            tableShoeCategory.Rows[0].Cells[2].Paragraphs[0].Append("color");
            tableShoeCategory.Rows[0].Cells[3].Paragraphs[0].Append("cost");
            tableShoeCategory.Rows[0].Cells[4].Paragraphs[0].Append("count_base");

            tableShoeCategory.Rows[0].Cells[0].FillColor = Color.Moccasin;
            tableShoeCategory.Rows[0].Cells[1].FillColor = Color.Moccasin;
            tableShoeCategory.Rows[0].Cells[2].FillColor = Color.Moccasin;
            tableShoeCategory.Rows[0].Cells[3].FillColor = Color.Moccasin;
            tableShoeCategory.Rows[0].Cells[4].FillColor = Color.Moccasin;

            var c = 1;
            var d = 0;
            foreach (var items in answer) {
                foreach (var item in items) {
                    tableShoeCategory.Rows[c].Cells[d].Paragraphs[0].Append(item);
                    d++;
                }
                d = 0;
                c++;
            }
            document.InsertParagraph().InsertTableAfterSelf(tableShoeCategory);
            document.SaveAs(Environment.CurrentDirectory + "\\Label.docx");
        }

        private void button3_Click(object sender, EventArgs e) {
            Application ExcelApp = new Application();
            ExcelApp.Workbooks.Add(Type.Missing);
            Worksheet sheet = (Worksheet)ExcelApp.Sheets[1];
            connection.Open();
            MySqlCommand command = new MySqlCommand($"select sale_date, count(sale_date) from sales group by sale_date;", connection);
            var reader = command.ExecuteReader();
            int i = 1;
            while (reader.Read()) 
            { 
                sheet.Cells[i, 1] = reader.GetValue(0).ToString().Trim();
                sheet.Cells[i, 2] = reader.GetValue(1).ToString().Trim();
                i++;
            }
            reader.Close();
            connection.Close();
            ChartObjects xlCharts = (ChartObjects)sheet.ChartObjects(Type.Missing);
            ChartObject myChart = (ChartObject)xlCharts.Add(110, 0, 350, 250);
            var chart = myChart.Chart;
            var seriesCollection = (SeriesCollection)chart.SeriesCollection(Type.Missing);
            Series series = seriesCollection.NewSeries();
            series.XValues = sheet.get_Range("A1", "A" + (i - 1) + "");
            series.Values = sheet.get_Range("B1", "B" + (i - 1) + "");
            chart.ChartType = XlChartType.xlXYScatterSmooth;
            ExcelApp.Visible = true;
        }
    }
}