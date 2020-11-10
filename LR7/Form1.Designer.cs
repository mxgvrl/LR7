namespace LR7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.categoryesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryesDataSet = new LR7.categoryesDataSet();
            this.categoryesTableAdapter = new LR7.categoryesDataSetTableAdapters.categoryesTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnShowSales = new System.Windows.Forms.Button();
            this.lbSales = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.picBCateg = new System.Windows.Forms.PictureBox();
            this.btnNextCateg = new System.Windows.Forms.Button();
            this.btnPrevCateg = new System.Windows.Forms.Button();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCategName = new System.Windows.Forms.TextBox();
            this.tbCategId = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelCateg = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDelCategName = new System.Windows.Forms.TextBox();
            this.tbAddCategPhoto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tbAddCategAvailable = new System.Windows.Forms.TextBox();
            this.tbAddCategCare = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAddCategWrnty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddCategName = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDelProd = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.tbDelProdName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cdAddProdC_id = new System.Windows.Forms.ComboBox();
            this.tbAddProdAvailable = new System.Windows.Forms.TextBox();
            this.tbAddProdCount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbAddProdCost = new System.Windows.Forms.TextBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.tbAddProdColor = new System.Windows.Forms.TextBox();
            this.tbAddProdMaterial = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbAddProdName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbAddSalesP_id = new System.Windows.Forms.ComboBox();
            this.tbAddSaleDate = new System.Windows.Forms.TextBox();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.tbAddSaleDiscount = new System.Windows.Forms.TextBox();
            this.tbAddSaleCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAddSaleSize = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdAddCategory = new System.Windows.Forms.OpenFileDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDelSale = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.tbDelSalesId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.categoryesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.categoryesDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picBCateg)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryesBindingSource
            // 
            this.categoryesBindingSource.DataMember = "categoryes";
            this.categoryesBindingSource.DataSource = this.categoryesDataSet;
            // 
            // categoryesDataSet
            // 
            this.categoryesDataSet.DataSetName = "categoryesDataSet";
            this.categoryesDataSet.Namespace = "http://tempuri.org/categoryesDataSet.xsd";
            this.categoryesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryesTableAdapter
            // 
            this.categoryesTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 369);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnShowSales);
            this.tabPage1.Controls.Add(this.lbSales);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(671, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "sales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnShowSales
            // 
            this.btnShowSales.Location = new System.Drawing.Point(27, 183);
            this.btnShowSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowSales.Name = "btnShowSales";
            this.btnShowSales.Size = new System.Drawing.Size(87, 32);
            this.btnShowSales.TabIndex = 2;
            this.btnShowSales.Text = "button1";
            this.btnShowSales.UseVisualStyleBackColor = true;
            this.btnShowSales.Click += new System.EventHandler(this.btnShowSales_Click);
            // 
            // lbSales
            // 
            this.lbSales.FormattingEnabled = true;
            this.lbSales.ItemHeight = 20;
            this.lbSales.Location = new System.Drawing.Point(27, 24);
            this.lbSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbSales.Name = "lbSales";
            this.lbSales.Size = new System.Drawing.Size(622, 144);
            this.lbSales.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.picBCateg);
            this.tabPage2.Controls.Add(this.btnNextCateg);
            this.tabPage2.Controls.Add(this.btnPrevCateg);
            this.tabPage2.Controls.Add(this.lbProducts);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbCategName);
            this.tabPage2.Controls.Add(this.tbCategId);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(671, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Navigation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // picBCateg
            // 
            this.picBCateg.Location = new System.Drawing.Point(26, 10);
            this.picBCateg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBCateg.Name = "picBCateg";
            this.picBCateg.Size = new System.Drawing.Size(335, 297);
            this.picBCateg.TabIndex = 8;
            this.picBCateg.TabStop = false;
            // 
            // btnNextCateg
            // 
            this.btnNextCateg.Location = new System.Drawing.Point(535, 278);
            this.btnNextCateg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextCateg.Name = "btnNextCateg";
            this.btnNextCateg.Size = new System.Drawing.Size(118, 28);
            this.btnNextCateg.TabIndex = 7;
            this.btnNextCateg.Text = "Next";
            this.btnNextCateg.UseVisualStyleBackColor = true;
            this.btnNextCateg.Click += new System.EventHandler(this.btnNextCateg_Click);
            // 
            // btnPrevCateg
            // 
            this.btnPrevCateg.Location = new System.Drawing.Point(391, 279);
            this.btnPrevCateg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevCateg.Name = "btnPrevCateg";
            this.btnPrevCateg.Size = new System.Drawing.Size(130, 28);
            this.btnPrevCateg.TabIndex = 6;
            this.btnPrevCateg.Text = "Prev";
            this.btnPrevCateg.UseVisualStyleBackColor = true;
            this.btnPrevCateg.Click += new System.EventHandler(this.btnPrevCateg_Click);
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 20;
            this.lbProducts.Location = new System.Drawing.Point(392, 89);
            this.lbProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(262, 184);
            this.lbProducts.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category id";
            // 
            // tbCategName
            // 
            this.tbCategName.Location = new System.Drawing.Point(527, 54);
            this.tbCategName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCategName.Name = "tbCategName";
            this.tbCategName.Size = new System.Drawing.Size(126, 27);
            this.tbCategName.TabIndex = 2;
            // 
            // tbCategId
            // 
            this.tbCategId.Location = new System.Drawing.Point(391, 54);
            this.tbCategId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCategId.Name = "tbCategId";
            this.tbCategId.Size = new System.Drawing.Size(130, 27);
            this.tbCategId.TabIndex = 0;
            this.tbCategId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCategId_KeyDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.tbAddCategPhoto);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(671, 336);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit Ctg";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelCateg);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbDelCategName);
            this.groupBox2.Location = new System.Drawing.Point(353, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(230, 122);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // btnDelCateg
            // 
            this.btnDelCateg.Location = new System.Drawing.Point(6, 68);
            this.btnDelCateg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelCateg.Name = "btnDelCateg";
            this.btnDelCateg.Size = new System.Drawing.Size(218, 35);
            this.btnDelCateg.TabIndex = 10;
            this.btnDelCateg.Text = "Delete";
            this.btnDelCateg.UseVisualStyleBackColor = true;
            this.btnDelCateg.Click += new System.EventHandler(this.btnDelCateg_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(1, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Name";
            // 
            // tbDelCategName
            // 
            this.tbDelCategName.Location = new System.Drawing.Point(73, 32);
            this.tbDelCategName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDelCategName.Name = "tbDelCategName";
            this.tbDelCategName.Size = new System.Drawing.Size(151, 27);
            this.tbDelCategName.TabIndex = 2;
            // 
            // tbAddCategPhoto
            // 
            this.tbAddCategPhoto.Location = new System.Drawing.Point(111, 204);
            this.tbAddCategPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddCategPhoto.Name = "tbAddCategPhoto";
            this.tbAddCategPhoto.Size = new System.Drawing.Size(167, 27);
            this.tbAddCategPhoto.TabIndex = 9;
            this.tbAddCategPhoto.Click += new System.EventHandler(this.tbAddCategPhoto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddCategory);
            this.groupBox1.Controls.Add(this.tbAddCategAvailable);
            this.groupBox1.Controls.Add(this.tbAddCategCare);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbAddCategWrnty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAddCategName);
            this.groupBox1.Location = new System.Drawing.Point(33, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(260, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(13, 196);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(231, 35);
            this.btnAddCategory.TabIndex = 9;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tbAddCategAvailable
            // 
            this.tbAddCategAvailable.Location = new System.Drawing.Point(78, 130);
            this.tbAddCategAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddCategAvailable.Name = "tbAddCategAvailable";
            this.tbAddCategAvailable.Size = new System.Drawing.Size(167, 27);
            this.tbAddCategAvailable.TabIndex = 8;
            // 
            // tbAddCategCare
            // 
            this.tbAddCategCare.Location = new System.Drawing.Point(78, 98);
            this.tbAddCategCare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddCategCare.Name = "tbAddCategCare";
            this.tbAddCategCare.Size = new System.Drawing.Size(167, 27);
            this.tbAddCategCare.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Photo";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Available";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Care";
            // 
            // tbAddCategWrnty
            // 
            this.tbAddCategWrnty.Location = new System.Drawing.Point(78, 64);
            this.tbAddCategWrnty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddCategWrnty.Name = "tbAddCategWrnty";
            this.tbAddCategWrnty.Size = new System.Drawing.Size(167, 27);
            this.tbAddCategWrnty.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Warranty";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // tbAddCategName
            // 
            this.tbAddCategName.Location = new System.Drawing.Point(78, 31);
            this.tbAddCategName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddCategName.Name = "tbAddCategName";
            this.tbAddCategName.Size = new System.Drawing.Size(167, 27);
            this.tbAddCategName.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(671, 336);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Edit Products";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDelProd);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.tbDelProdName);
            this.groupBox5.Location = new System.Drawing.Point(309, 28);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(230, 122);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Delete";
            // 
            // btnDelProd
            // 
            this.btnDelProd.Location = new System.Drawing.Point(6, 68);
            this.btnDelProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelProd.Name = "btnDelProd";
            this.btnDelProd.Size = new System.Drawing.Size(218, 35);
            this.btnDelProd.TabIndex = 10;
            this.btnDelProd.Text = "Delete";
            this.btnDelProd.UseVisualStyleBackColor = true;
            this.btnDelProd.Click += new System.EventHandler(this.btnDelProd_Click);
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(1, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 22);
            this.label21.TabIndex = 3;
            this.label21.Text = "Name";
            // 
            // tbDelProdName
            // 
            this.tbDelProdName.Location = new System.Drawing.Point(73, 32);
            this.tbDelProdName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDelProdName.Name = "tbDelProdName";
            this.tbDelProdName.Size = new System.Drawing.Size(151, 27);
            this.tbDelProdName.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cdAddProdC_id);
            this.groupBox4.Controls.Add(this.tbAddProdAvailable);
            this.groupBox4.Controls.Add(this.tbAddProdCount);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.tbAddProdCost);
            this.groupBox4.Controls.Add(this.btnAddProd);
            this.groupBox4.Controls.Add(this.tbAddProdColor);
            this.groupBox4.Controls.Add(this.tbAddProdMaterial);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.tbAddProdName);
            this.groupBox4.Location = new System.Drawing.Point(25, 28);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(260, 315);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add";
            // 
            // cdAddProdC_id
            // 
            this.cdAddProdC_id.FormattingEnabled = true;
            this.cdAddProdC_id.Location = new System.Drawing.Point(78, 65);
            this.cdAddProdC_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cdAddProdC_id.Name = "cdAddProdC_id";
            this.cdAddProdC_id.Size = new System.Drawing.Size(165, 28);
            this.cdAddProdC_id.TabIndex = 15;
            this.cdAddProdC_id.Click += new System.EventHandler(this.cdAddProdC_id_Click);
            // 
            // tbAddProdAvailable
            // 
            this.tbAddProdAvailable.Location = new System.Drawing.Point(78, 231);
            this.tbAddProdAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddProdAvailable.Name = "tbAddProdAvailable";
            this.tbAddProdAvailable.Size = new System.Drawing.Size(167, 27);
            this.tbAddProdAvailable.TabIndex = 14;
            // 
            // tbAddProdCount
            // 
            this.tbAddProdCount.Location = new System.Drawing.Point(78, 198);
            this.tbAddProdCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddProdCount.Name = "tbAddProdCount";
            this.tbAddProdCount.Size = new System.Drawing.Size(167, 27);
            this.tbAddProdCount.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(6, 231);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 22);
            this.label20.TabIndex = 12;
            this.label20.Text = "Available";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(6, 200);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 22);
            this.label19.TabIndex = 11;
            this.label19.Text = "Count";
            // 
            // tbAddProdCost
            // 
            this.tbAddProdCost.Location = new System.Drawing.Point(78, 162);
            this.tbAddProdCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddProdCost.Name = "tbAddProdCost";
            this.tbAddProdCost.Size = new System.Drawing.Size(167, 27);
            this.tbAddProdCost.TabIndex = 10;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(14, 264);
            this.btnAddProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(231, 35);
            this.btnAddProd.TabIndex = 9;
            this.btnAddProd.Text = "Add";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // tbAddProdColor
            // 
            this.tbAddProdColor.Location = new System.Drawing.Point(78, 130);
            this.tbAddProdColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddProdColor.Name = "tbAddProdColor";
            this.tbAddProdColor.Size = new System.Drawing.Size(167, 27);
            this.tbAddProdColor.TabIndex = 8;
            // 
            // tbAddProdMaterial
            // 
            this.tbAddProdMaterial.Location = new System.Drawing.Point(78, 98);
            this.tbAddProdMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddProdMaterial.Name = "tbAddProdMaterial";
            this.tbAddProdMaterial.Size = new System.Drawing.Size(167, 27);
            this.tbAddProdMaterial.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 22);
            this.label14.TabIndex = 6;
            this.label14.Text = "Cost";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 22);
            this.label15.TabIndex = 5;
            this.label15.Text = "Color";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(6, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 22);
            this.label16.TabIndex = 4;
            this.label16.Text = "Material";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(6, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 22);
            this.label17.TabIndex = 2;
            this.label17.Text = "C_id";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(6, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 22);
            this.label18.TabIndex = 1;
            this.label18.Text = "Name";
            // 
            // tbAddProdName
            // 
            this.tbAddProdName.Location = new System.Drawing.Point(78, 31);
            this.tbAddProdName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddProdName.Name = "tbAddProdName";
            this.tbAddProdName.Size = new System.Drawing.Size(167, 27);
            this.tbAddProdName.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(671, 336);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Edit Sales";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbAddSalesP_id);
            this.groupBox3.Controls.Add(this.tbAddSaleDate);
            this.groupBox3.Controls.Add(this.btnAddSale);
            this.groupBox3.Controls.Add(this.tbAddSaleDiscount);
            this.groupBox3.Controls.Add(this.tbAddSaleCount);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbAddSaleSize);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(31, 39);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(260, 242);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add";
            // 
            // cbAddSalesP_id
            // 
            this.cbAddSalesP_id.FormattingEnabled = true;
            this.cbAddSalesP_id.Location = new System.Drawing.Point(78, 29);
            this.cbAddSalesP_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAddSalesP_id.Name = "cbAddSalesP_id";
            this.cbAddSalesP_id.Size = new System.Drawing.Size(165, 28);
            this.cbAddSalesP_id.TabIndex = 16;
            this.cbAddSalesP_id.Click += new System.EventHandler(this.cbAddSalesP_id_Click);
            // 
            // tbAddSaleDate
            // 
            this.tbAddSaleDate.Location = new System.Drawing.Point(78, 162);
            this.tbAddSaleDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddSaleDate.Name = "tbAddSaleDate";
            this.tbAddSaleDate.Size = new System.Drawing.Size(167, 27);
            this.tbAddSaleDate.TabIndex = 10;
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(13, 196);
            this.btnAddSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(231, 35);
            this.btnAddSale.TabIndex = 9;
            this.btnAddSale.Text = "Add";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // tbAddSaleDiscount
            // 
            this.tbAddSaleDiscount.Location = new System.Drawing.Point(78, 130);
            this.tbAddSaleDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddSaleDiscount.Name = "tbAddSaleDiscount";
            this.tbAddSaleDiscount.Size = new System.Drawing.Size(167, 27);
            this.tbAddSaleDiscount.TabIndex = 8;
            // 
            // tbAddSaleCount
            // 
            this.tbAddSaleCount.Location = new System.Drawing.Point(78, 98);
            this.tbAddSaleCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddSaleCount.Name = "tbAddSaleCount";
            this.tbAddSaleCount.Size = new System.Drawing.Size(167, 27);
            this.tbAddSaleCount.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 6;
            this.label9.Text = "Date";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "Discount";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 22);
            this.label11.TabIndex = 4;
            this.label11.Text = "Count";
            // 
            // tbAddSaleSize
            // 
            this.tbAddSaleSize.Location = new System.Drawing.Point(78, 64);
            this.tbAddSaleSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddSaleSize.Name = "tbAddSaleSize";
            this.tbAddSaleSize.Size = new System.Drawing.Size(167, 27);
            this.tbAddSaleSize.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 22);
            this.label12.TabIndex = 2;
            this.label12.Text = "Size";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 22);
            this.label13.TabIndex = 1;
            this.label13.Text = "P_id";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening +=
                new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ofdAddCategory
            // 
            this.ofdAddCategory.FileName = "openFileDialog1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDelSale);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.tbDelSalesId);
            this.groupBox6.Location = new System.Drawing.Point(332, 39);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(230, 122);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Delete";
            // 
            // btnDelSale
            // 
            this.btnDelSale.Location = new System.Drawing.Point(6, 68);
            this.btnDelSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelSale.Name = "btnDelSale";
            this.btnDelSale.Size = new System.Drawing.Size(218, 35);
            this.btnDelSale.TabIndex = 10;
            this.btnDelSale.Text = "Delete";
            this.btnDelSale.UseVisualStyleBackColor = true;
            this.btnDelSale.Click += new System.EventHandler(this.btnDelSale_Click);
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(6, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 22);
            this.label22.TabIndex = 3;
            this.label22.Text = "id";
            // 
            // tbDelSalesId
            // 
            this.tbDelSalesId.Location = new System.Drawing.Point(37, 32);
            this.tbDelSalesId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDelSalesId.Name = "tbDelSalesId";
            this.tbDelSalesId.Size = new System.Drawing.Size(187, 27);
            this.tbDelSalesId.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 367);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "LR7";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.categoryesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.categoryesDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picBCateg)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.BindingSource categoryesBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCategName;
        private System.Windows.Forms.TextBox tbCategId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrevCateg;
        private LR7.categoryesDataSetTableAdapters.categoryesTableAdapter categoryesTableAdapter;
        private LR7.categoryesDataSet categoryesDataSet;
        private System.Windows.Forms.Button btnNextCateg;
        private System.Windows.Forms.PictureBox picBCateg;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.OpenFileDialog ofdAddCategory;
        private System.Windows.Forms.TextBox tbAddCategCare;
        private System.Windows.Forms.TextBox tbAddCategAvailable;
        private System.Windows.Forms.TextBox tbAddCategPhoto;
        private System.Windows.Forms.TextBox tbAddCategWrnty;
        private System.Windows.Forms.TextBox tbAddCategName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDelCategName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelCateg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbAddSaleDate;
        private System.Windows.Forms.TextBox tbAddSaleSize;
        private System.Windows.Forms.TextBox tbAddSaleCount;
        private System.Windows.Forms.TextBox tbAddSaleDiscount;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbAddProdName;
        private System.Windows.Forms.ComboBox cdAddProdC_id;
        private System.Windows.Forms.TextBox tbAddProdCount;
        private System.Windows.Forms.TextBox tbAddProdAvailable;
        private System.Windows.Forms.TextBox tbAddProdMaterial;
        private System.Windows.Forms.TextBox tbAddProdColor;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.TextBox tbAddProdCost;
        private System.Windows.Forms.TextBox tbDelProdName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnDelProd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbAddSalesP_id;
        private System.Windows.Forms.ListBox lbSales;
        private System.Windows.Forms.Button btnShowSales;
        private System.Windows.Forms.TextBox tbDelSalesId;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnDelSale;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

