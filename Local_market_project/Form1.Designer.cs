namespace Local_market_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.products = new System.Windows.Forms.TabPage();
            this.vendorsData = new System.Windows.Forms.DataGridView();
            this.customersData = new System.Windows.Forms.DataGridView();
            this.vendors = new System.Windows.Forms.Label();
            this.filterVendors = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.Label();
            this.filterCustomers = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.product = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.productsCategorized = new System.Windows.Forms.DataGridView();
            this.productVendors = new System.Windows.Forms.TabPage();
            this.vendorMD = new System.Windows.Forms.Label();
            this.productsMD = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.transactions = new System.Windows.Forms.TabPage();
            this.transactionInput = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateInput = new System.Windows.Forms.Label();
            this.vendorCombo = new System.Windows.Forms.ComboBox();
            this.customerCombo = new System.Windows.Forms.ComboBox();
            this.vendorInput = new System.Windows.Forms.Label();
            this.customerInput = new System.Windows.Forms.Label();
            this.amountInput = new System.Windows.Forms.Label();
            this.totalAmountTxtBx = new System.Windows.Forms.TextBox();
            this.productAndQuantities = new System.Windows.Forms.Label();
            this.transactionHistory = new System.Windows.Forms.DataGridView();
            this.filterTransactionHistory = new System.Windows.Forms.Label();
            this.transactionFilter = new System.Windows.Forms.TextBox();
            this.prodQuantity = new System.Windows.Forms.Label();
            this.productQuantity = new System.Windows.Forms.TextBox();
            this.addProduct = new System.Windows.Forms.DataGridView();
            this.saveNewTransaction = new System.Windows.Forms.Button();
            this.refreshTranHistory = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.home.SuspendLayout();
            this.products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsCategorized)).BeginInit();
            this.productVendors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.transactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.home);
            this.tabControl1.Controls.Add(this.products);
            this.tabControl1.Controls.Add(this.productVendors);
            this.tabControl1.Controls.Add(this.transactions);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1866, 1350);
            this.tabControl1.TabIndex = 0;
            // 
            // home
            // 
            this.home.Controls.Add(this.textBox2);
            this.home.Controls.Add(this.textBox1);
            this.home.Controls.Add(this.filterCustomers);
            this.home.Controls.Add(this.customer);
            this.home.Controls.Add(this.filterVendors);
            this.home.Controls.Add(this.vendors);
            this.home.Controls.Add(this.customersData);
            this.home.Controls.Add(this.vendorsData);
            this.home.Location = new System.Drawing.Point(8, 39);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(1850, 1303);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // products
            // 
            this.products.Controls.Add(this.productsCategorized);
            this.products.Controls.Add(this.treeView1);
            this.products.Controls.Add(this.product);
            this.products.Location = new System.Drawing.Point(8, 39);
            this.products.Name = "products";
            this.products.Padding = new System.Windows.Forms.Padding(3);
            this.products.Size = new System.Drawing.Size(1850, 1303);
            this.products.TabIndex = 1;
            this.products.Text = "Products";
            this.products.UseVisualStyleBackColor = true;
            // 
            // vendorsData
            // 
            this.vendorsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorsData.Location = new System.Drawing.Point(6, 62);
            this.vendorsData.Name = "vendorsData";
            this.vendorsData.RowHeadersWidth = 82;
            this.vendorsData.RowTemplate.Height = 33;
            this.vendorsData.Size = new System.Drawing.Size(1838, 624);
            this.vendorsData.TabIndex = 0;
            // 
            // customersData
            // 
            this.customersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersData.Location = new System.Drawing.Point(6, 754);
            this.customersData.Name = "customersData";
            this.customersData.RowHeadersWidth = 82;
            this.customersData.RowTemplate.Height = 33;
            this.customersData.Size = new System.Drawing.Size(1838, 543);
            this.customersData.TabIndex = 1;
            // 
            // vendors
            // 
            this.vendors.AutoSize = true;
            this.vendors.Location = new System.Drawing.Point(15, 17);
            this.vendors.Name = "vendors";
            this.vendors.Size = new System.Drawing.Size(186, 25);
            this.vendors.TabIndex = 2;
            this.vendors.Text = "Available Vendors";
            // 
            // filterVendors
            // 
            this.filterVendors.AutoSize = true;
            this.filterVendors.Location = new System.Drawing.Point(821, 17);
            this.filterVendors.Name = "filterVendors";
            this.filterVendors.Size = new System.Drawing.Size(282, 25);
            this.filterVendors.TabIndex = 3;
            this.filterVendors.Text = "Type to find specific vendor:";
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Location = new System.Drawing.Point(15, 706);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(115, 25);
            this.customer.TabIndex = 4;
            this.customer.Text = "Customers";
            // 
            // filterCustomers
            // 
            this.filterCustomers.AutoSize = true;
            this.filterCustomers.Location = new System.Drawing.Point(799, 706);
            this.filterCustomers.Name = "filterCustomers";
            this.filterCustomers.Size = new System.Drawing.Size(304, 25);
            this.filterCustomers.TabIndex = 5;
            this.filterCustomers.Text = "Type to find specific customer:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1110, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 31);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1110, 706);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(385, 31);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Location = new System.Drawing.Point(30, 27);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(196, 25);
            this.product.TabIndex = 0;
            this.product.Text = "Product Categories";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(26, 75);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(355, 1180);
            this.treeView1.TabIndex = 2;
            // 
            // productsCategorized
            // 
            this.productsCategorized.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsCategorized.Location = new System.Drawing.Point(387, 75);
            this.productsCategorized.Name = "productsCategorized";
            this.productsCategorized.RowHeadersWidth = 82;
            this.productsCategorized.RowTemplate.Height = 33;
            this.productsCategorized.Size = new System.Drawing.Size(1457, 1180);
            this.productsCategorized.TabIndex = 3;
            // 
            // productVendors
            // 
            this.productVendors.Controls.Add(this.dataGridView2);
            this.productVendors.Controls.Add(this.dataGridView1);
            this.productVendors.Controls.Add(this.productsMD);
            this.productVendors.Controls.Add(this.vendorMD);
            this.productVendors.Location = new System.Drawing.Point(8, 39);
            this.productVendors.Name = "productVendors";
            this.productVendors.Padding = new System.Windows.Forms.Padding(3);
            this.productVendors.Size = new System.Drawing.Size(1850, 1303);
            this.productVendors.TabIndex = 2;
            this.productVendors.Text = "Vendors And Their Products";
            this.productVendors.UseVisualStyleBackColor = true;
            // 
            // vendorMD
            // 
            this.vendorMD.AutoSize = true;
            this.vendorMD.Location = new System.Drawing.Point(30, 23);
            this.vendorMD.Name = "vendorMD";
            this.vendorMD.Size = new System.Drawing.Size(92, 25);
            this.vendorMD.TabIndex = 0;
            this.vendorMD.Text = "Vendors";
            // 
            // productsMD
            // 
            this.productsMD.AutoSize = true;
            this.productsMD.Location = new System.Drawing.Point(968, 23);
            this.productsMD.Name = "productsMD";
            this.productsMD.Size = new System.Drawing.Size(97, 25);
            this.productsMD.TabIndex = 1;
            this.productsMD.Text = "Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(961, 1226);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(973, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(871, 1226);
            this.dataGridView2.TabIndex = 3;
            // 
            // transactions
            // 
            this.transactions.Controls.Add(this.refreshTranHistory);
            this.transactions.Controls.Add(this.saveNewTransaction);
            this.transactions.Controls.Add(this.addProduct);
            this.transactions.Controls.Add(this.productQuantity);
            this.transactions.Controls.Add(this.prodQuantity);
            this.transactions.Controls.Add(this.transactionFilter);
            this.transactions.Controls.Add(this.filterTransactionHistory);
            this.transactions.Controls.Add(this.transactionHistory);
            this.transactions.Controls.Add(this.productAndQuantities);
            this.transactions.Controls.Add(this.totalAmountTxtBx);
            this.transactions.Controls.Add(this.amountInput);
            this.transactions.Controls.Add(this.customerInput);
            this.transactions.Controls.Add(this.vendorInput);
            this.transactions.Controls.Add(this.customerCombo);
            this.transactions.Controls.Add(this.vendorCombo);
            this.transactions.Controls.Add(this.dateInput);
            this.transactions.Controls.Add(this.dateTimePicker1);
            this.transactions.Controls.Add(this.transactionInput);
            this.transactions.Location = new System.Drawing.Point(8, 39);
            this.transactions.Name = "transactions";
            this.transactions.Padding = new System.Windows.Forms.Padding(3);
            this.transactions.Size = new System.Drawing.Size(1850, 1303);
            this.transactions.TabIndex = 3;
            this.transactions.Text = "Transactions";
            this.transactions.UseVisualStyleBackColor = true;
            // 
            // transactionInput
            // 
            this.transactionInput.AutoSize = true;
            this.transactionInput.Location = new System.Drawing.Point(16, 46);
            this.transactionInput.Name = "transactionInput";
            this.transactionInput.Size = new System.Drawing.Size(300, 25);
            this.transactionInput.TabIndex = 0;
            this.transactionInput.Text = "Enter a new transaction below";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(411, 31);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateInput
            // 
            this.dateInput.AutoSize = true;
            this.dateInput.Location = new System.Drawing.Point(16, 104);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(137, 25);
            this.dateInput.TabIndex = 2;
            this.dateInput.Text = "Choose Date";
            // 
            // vendorCombo
            // 
            this.vendorCombo.FormattingEnabled = true;
            this.vendorCombo.Location = new System.Drawing.Point(21, 230);
            this.vendorCombo.Name = "vendorCombo";
            this.vendorCombo.Size = new System.Drawing.Size(411, 33);
            this.vendorCombo.TabIndex = 3;
            // 
            // customerCombo
            // 
            this.customerCombo.FormattingEnabled = true;
            this.customerCombo.Location = new System.Drawing.Point(21, 341);
            this.customerCombo.Name = "customerCombo";
            this.customerCombo.Size = new System.Drawing.Size(411, 33);
            this.customerCombo.TabIndex = 4;
            // 
            // vendorInput
            // 
            this.vendorInput.AutoSize = true;
            this.vendorInput.Location = new System.Drawing.Point(16, 202);
            this.vendorInput.Name = "vendorInput";
            this.vendorInput.Size = new System.Drawing.Size(176, 25);
            this.vendorInput.TabIndex = 5;
            this.vendorInput.Text = "Choose a vendor";
            // 
            // customerInput
            // 
            this.customerInput.AutoSize = true;
            this.customerInput.Location = new System.Drawing.Point(16, 313);
            this.customerInput.Name = "customerInput";
            this.customerInput.Size = new System.Drawing.Size(198, 25);
            this.customerInput.TabIndex = 6;
            this.customerInput.Text = "Choose a customer";
            // 
            // amountInput
            // 
            this.amountInput.AutoSize = true;
            this.amountInput.Location = new System.Drawing.Point(16, 422);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(183, 25);
            this.amountInput.TabIndex = 7;
            this.amountInput.Text = "Input total amount";
            // 
            // totalAmountTxtBx
            // 
            this.totalAmountTxtBx.Location = new System.Drawing.Point(21, 450);
            this.totalAmountTxtBx.Name = "totalAmountTxtBx";
            this.totalAmountTxtBx.Size = new System.Drawing.Size(411, 31);
            this.totalAmountTxtBx.TabIndex = 8;
            // 
            // productAndQuantities
            // 
            this.productAndQuantities.AutoSize = true;
            this.productAndQuantities.Location = new System.Drawing.Point(16, 554);
            this.productAndQuantities.Name = "productAndQuantities";
            this.productAndQuantities.Size = new System.Drawing.Size(147, 25);
            this.productAndQuantities.TabIndex = 9;
            this.productAndQuantities.Text = "Add Products ";
            // 
            // transactionHistory
            // 
            this.transactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionHistory.Location = new System.Drawing.Point(523, 63);
            this.transactionHistory.Name = "transactionHistory";
            this.transactionHistory.RowHeadersWidth = 82;
            this.transactionHistory.RowTemplate.Height = 33;
            this.transactionHistory.Size = new System.Drawing.Size(1324, 1212);
            this.transactionHistory.TabIndex = 11;
            // 
            // filterTransactionHistory
            // 
            this.filterTransactionHistory.AutoSize = true;
            this.filterTransactionHistory.Location = new System.Drawing.Point(518, 19);
            this.filterTransactionHistory.Name = "filterTransactionHistory";
            this.filterTransactionHistory.Size = new System.Drawing.Size(322, 25);
            this.filterTransactionHistory.TabIndex = 12;
            this.filterTransactionHistory.Text = "Type to find specific transaction:";
            // 
            // transactionFilter
            // 
            this.transactionFilter.Location = new System.Drawing.Point(846, 16);
            this.transactionFilter.Name = "transactionFilter";
            this.transactionFilter.Size = new System.Drawing.Size(487, 31);
            this.transactionFilter.TabIndex = 13;
            // 
            // prodQuantity
            // 
            this.prodQuantity.AutoSize = true;
            this.prodQuantity.Location = new System.Drawing.Point(16, 1101);
            this.prodQuantity.Name = "prodQuantity";
            this.prodQuantity.Size = new System.Drawing.Size(136, 25);
            this.prodQuantity.TabIndex = 14;
            this.prodQuantity.Text = "Add Quantity";
            // 
            // productQuantity
            // 
            this.productQuantity.Location = new System.Drawing.Point(21, 1129);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(411, 31);
            this.productQuantity.TabIndex = 15;
            // 
            // addProduct
            // 
            this.addProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProduct.Location = new System.Drawing.Point(21, 582);
            this.addProduct.Name = "addProduct";
            this.addProduct.RowHeadersWidth = 82;
            this.addProduct.RowTemplate.Height = 33;
            this.addProduct.Size = new System.Drawing.Size(411, 493);
            this.addProduct.TabIndex = 16;
            // 
            // saveNewTransaction
            // 
            this.saveNewTransaction.Location = new System.Drawing.Point(117, 1211);
            this.saveNewTransaction.Name = "saveNewTransaction";
            this.saveNewTransaction.Size = new System.Drawing.Size(199, 52);
            this.saveNewTransaction.TabIndex = 17;
            this.saveNewTransaction.Text = "Add Transaction";
            this.saveNewTransaction.UseVisualStyleBackColor = true;
            this.saveNewTransaction.Click += new System.EventHandler(this.saveNewTransaction_Click);
            // 
            // refreshTranHistory
            // 
            this.refreshTranHistory.Location = new System.Drawing.Point(1652, 6);
            this.refreshTranHistory.Name = "refreshTranHistory";
            this.refreshTranHistory.Size = new System.Drawing.Size(192, 51);
            this.refreshTranHistory.TabIndex = 18;
            this.refreshTranHistory.Text = "Refresh";
            this.refreshTranHistory.UseVisualStyleBackColor = true;
            this.refreshTranHistory.Click += new System.EventHandler(this.refreshTranHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1866, 1350);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.home.PerformLayout();
            this.products.ResumeLayout(false);
            this.products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsCategorized)).EndInit();
            this.productVendors.ResumeLayout(false);
            this.productVendors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.transactions.ResumeLayout(false);
            this.transactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabPage products;
        private System.Windows.Forms.DataGridView customersData;
        private System.Windows.Forms.DataGridView vendorsData;
        private System.Windows.Forms.Label filterCustomers;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.Label filterVendors;
        private System.Windows.Forms.Label vendors;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label product;
        private System.Windows.Forms.DataGridView productsCategorized;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage productVendors;
        private System.Windows.Forms.Label vendorMD;
        private System.Windows.Forms.Label productsMD;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage transactions;
        private System.Windows.Forms.Label dateInput;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label transactionInput;
        private System.Windows.Forms.TextBox totalAmountTxtBx;
        private System.Windows.Forms.Label amountInput;
        private System.Windows.Forms.Label customerInput;
        private System.Windows.Forms.Label vendorInput;
        private System.Windows.Forms.ComboBox customerCombo;
        private System.Windows.Forms.ComboBox vendorCombo;
        private System.Windows.Forms.DataGridView transactionHistory;
        private System.Windows.Forms.Label productAndQuantities;
        private System.Windows.Forms.Label filterTransactionHistory;
        private System.Windows.Forms.TextBox transactionFilter;
        private System.Windows.Forms.TextBox productQuantity;
        private System.Windows.Forms.Label prodQuantity;
        private System.Windows.Forms.DataGridView addProduct;
        private System.Windows.Forms.Button saveNewTransaction;
        private System.Windows.Forms.Button refreshTranHistory;
    }
}

