using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace Local_market_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vendorsData.CellValueChanged += vendorsData_CellValueChanged;
            customersData.CellValueChanged += customersData_CellValueChanged;
            productsCategorized.CellValueChanged += productDataGridView_CellValueChanged;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        string connString = "Host=localhost;Username=Oheneba;Password=Bosompem;Database=Ghana_market";

        private void LoadVendorsData()
        {
            var conn = new NpgsqlConnection(connString);
            conn.Open();
            var query = "SELECT vendors_id, name, surname, gender, birthday, contact_number, address FROM vendors";
            var da = new NpgsqlDataAdapter(query, conn);
            var dt = new DataTable();
            da.Fill(dt);
            vendorsData.DataSource = dt;
            vendorsData.Columns["vendors_id"].Visible = false;
            vendorsData.Columns["name"].HeaderText = "First Name";
            vendorsData.Columns["surname"].HeaderText = "Last Name";
            vendorsData.Columns["gender"].HeaderText = "Gender";
            vendorsData.Columns["birthday"].HeaderText = "Date of Birth";
            vendorsData.Columns["contact_number"].HeaderText = "Phone Number";
            vendorsData.Columns["address"].HeaderText = "Address";

            vendorsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadCustomersData()
        {
            var conn = new NpgsqlConnection(connString);
            conn.Open();
            var query = "SELECT customer_id, customer_name, customer_surname, customer_contact_number, customer_address FROM customer";
            var da = new NpgsqlDataAdapter(query, conn);
            var dt = new DataTable();
            da.Fill(dt);
            customersData.DataSource = dt;
            customersData.Columns["customer_id"].Visible = false;
            customersData.Columns["customer_name"].HeaderText = "First Name";
            customersData.Columns["customer_surname"].HeaderText = "Last Name";
            customersData.Columns["customer_contact_number"].HeaderText = "Phone Number";
            customersData.Columns["customer_address"].HeaderText = "Address";

            customersData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadVendorsData();
            LoadCustomersData();
            LoadCategories();
            LoadVendorsForMasterDetail();
            LoadVendorsAndCustomers();
            LoadProductSelectionGrid();
            LoadTransactionHistory();
            textBox1.TextChanged += textBox1_TextChanged;
            textBox2.TextChanged += textBox2_TextChanged;
            treeView1.AfterSelect += treeView1_AfterSelect;
            transactionFilter.TextChanged += transactionFilter_TextChanged;


        }

        private void UpdateDatabase(DataTable dt, string tableName, string idColumn)
        {
            var conn = new NpgsqlConnection(connString);
            conn.Open();

            var da = new NpgsqlDataAdapter($"SELECT * FROM {tableName}", conn);
            var cb = new NpgsqlCommandBuilder(da);
            da.UpdateCommand = cb.GetUpdateCommand();
            da.InsertCommand = cb.GetInsertCommand();
            da.DeleteCommand = cb.GetDeleteCommand();
            da.Update(dt);
        }

        private void vendorsData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (vendorsData.DataSource is DataTable dt)
                UpdateDatabase(dt, "vendors", "vendors_id");
        }

        private void customersData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (customersData.DataSource is DataTable dt)
                UpdateDatabase(dt, "customer", "customer_id");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var filterText = textBox1.Text.Trim().ToLower();
            var dv = ((DataTable)vendorsData.DataSource).DefaultView;
            dv.RowFilter = $"name LIKE '%{filterText}%' OR surname LIKE '%{filterText}%'";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var filterText = textBox2.Text.Trim().ToLower();
            var dv = ((DataTable)customersData.DataSource).DefaultView;
            dv.RowFilter = $"customer_name LIKE '%{filterText}%' OR customer_surname LIKE '%{filterText}%'";
        }

        // Load categories into the TreeView on form load------------------------------------------------------------------
        private void LoadCategories()
        {
            var conn = new NpgsqlConnection(connString);
            conn.Open();

            var cmd = new NpgsqlCommand("SELECT category_id, category_name, parent_category_id FROM category", conn);
            var reader = cmd.ExecuteReader();

            var categories = new List<(int id, string name, int parentId)>();
            while (reader.Read())
            {
                categories.Add((reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
            }

            treeView1.Nodes.Clear();
            AddCategoryNodes(null, 0, categories); // Start with parent_id = 0
        }

        private void AddCategoryNodes(TreeNode parentNode, int parentId, List<(int id, string name, int parentId)> categories)
        {
            foreach (var cat in categories.Where(c => c.parentId == parentId))
            {
                var node = new TreeNode(cat.name) { Tag = cat.id };
                if (parentNode == null)
                    treeView1.Nodes.Add(node);
                else
                    parentNode.Nodes.Add(node);

                AddCategoryNodes(node, cat.id, categories);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int categoryId = (int)e.Node.Tag;
            LoadProducts(categoryId);
        }

        private void LoadProducts(int categoryId)
        {
            var conn = new NpgsqlConnection(connString);
            conn.Open();

            string query = @"
            SELECT p.product_id, p.product_name, p.product_price, p.stock_quantity, p.category_id, c.category_name
            FROM product p
            JOIN category c ON p.category_id = c.category_id
            WHERE p.category_id = @category_id";

            var da = new NpgsqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("category_id", categoryId);

            var dt = new DataTable();
            da.Fill(dt);
            productsCategorized.DataSource = dt;

            // Hide product_id
            if (productsCategorized.Columns.Contains("product_id"))
                productsCategorized.Columns["product_id"].Visible = false;

            // Replace category_id with combobox
            if (productsCategorized.Columns.Contains("category_id"))
                productsCategorized.Columns.Remove("category_id");

            // Prevent duplicate ComboBox columns
            if (productsCategorized.Columns.Contains("Category"))
                productsCategorized.Columns.Remove("Category");

           
            productsCategorized.Columns["product_name"].HeaderText = "Product Name";
            productsCategorized.Columns["product_price"].HeaderText = "Price";
            productsCategorized.Columns["stock_quantity"].HeaderText = "Stock";
            productsCategorized.Columns["category_name"].HeaderText = "Category";

            productsCategorized.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void productDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (productsCategorized.DataSource is DataTable dt)
                UpdateDatabase(dt, "product", "product_id");
        }

        // Load vendors for master-detail view in the DataGridView -----------------------------------------------------------------
        private void LoadVendorsForMasterDetail()
        {
            var conn = new NpgsqlConnection(connString);
            conn.Open();

            string query = "SELECT vendors_id, name, surname, contact_number FROM vendors";
            var da = new NpgsqlDataAdapter(query, conn);
            var dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["vendors_id"].Visible = false;

            dataGridView1.Columns["name"].HeaderText = "First Name";
            dataGridView1.Columns["surname"].HeaderText = "Last Name";
            dataGridView1.Columns["contact_number"].HeaderText = "Phone Number";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadVendorProducts(int vendorId)
        {
            var conn = new NpgsqlConnection(connString);
            conn.Open();

            string query = @"
            SELECT 
                pv.product_vendor_id,
                p.product_id,
                p.product_name,
                p.product_price,
                p.stock_quantity
            FROM product_vendor pv
            JOIN product p ON pv.product_id = p.product_id
            WHERE pv.vendors_id = @vendorId";

            var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("vendorId", vendorId);

            var da = new NpgsqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;
            if (dataGridView2.Columns.Contains("product_vendor_id"))
                dataGridView2.Columns["product_vendor_id"].Visible = false;
            if (dataGridView2.Columns.Contains("product_id"))
                dataGridView2.Columns["product_id"].Visible = false;

            dataGridView2.Columns["product_name"].HeaderText = "Product Name";
            dataGridView2.Columns["product_price"].HeaderText = "Price";
            dataGridView2.Columns["stock_quantity"].HeaderText = "Stock";

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int vendorId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["vendors_id"].Value);
                LoadVendorProducts(vendorId);
            }
        }


        // Load vendors and customers into comboboxes for transaction entry -------------------------------------------------

        private void LoadVendorsAndCustomers()
        {
            var conn = new NpgsqlConnection(connString);
            conn.Open();

            // Vendors
            var vendorAdapter = new NpgsqlDataAdapter("SELECT vendors_id, name || ' ' || surname AS fullname FROM vendors", conn);
            var vendorTable = new DataTable();
            vendorAdapter.Fill(vendorTable);
            vendorCombo.DataSource = vendorTable;
            vendorCombo.DisplayMember = "fullname";
            vendorCombo.ValueMember = "vendors_id";

            // Customers
            var customerAdapter = new NpgsqlDataAdapter("SELECT customer_id, customer_name || ' ' || customer_surname AS fullname FROM customer", conn);
            var customerTable = new DataTable();
            customerAdapter.Fill(customerTable);
            customerCombo.DataSource = customerTable;
            customerCombo.DisplayMember = "fullname";
            customerCombo.ValueMember = "customer_id";
        }


        private void LoadProductSelectionGrid()
        {
            var conn = new NpgsqlConnection(connString);
            conn.Open();

            // Load product list
            var productAdapter = new NpgsqlDataAdapter("SELECT product_id, product_name, product_price FROM product", conn);
            var productTable = new DataTable();
            productAdapter.Fill(productTable);

            addProduct.Columns.Clear();

            // ComboBox column for product name
            var productComboCol = new DataGridViewComboBoxColumn
            {
                HeaderText = "Product",
                Name = "product_id",
                DataSource = productTable,
                ValueMember = "product_id",
                DisplayMember = "product_name",
                AutoComplete = true,
                Width = 200
            };

            // Price column (read-only)
            var priceCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                Name = "product_price",
                ReadOnly = true,
                Width = 100
            };

            // Quantity input column
            var qtyCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                Name = "quantity",
                Width = 100
            };

            addProduct.Columns.Add(productComboCol);
            addProduct.Columns.Add(priceCol);
            addProduct.Columns.Add(qtyCol);

            // Event to update price when product is selected
            addProduct.EditingControlShowing += AddProduct_EditingControlShowing;
        }

        private void AddProduct_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (addProduct.CurrentCell.ColumnIndex == addProduct.Columns["product_id"].Index &&
                e.Control is ComboBox comboBox)
            {
                comboBox.SelectedIndexChanged -= ProductComboBox_SelectedIndexChanged; // avoid duplicates
                comboBox.SelectedIndexChanged += ProductComboBox_SelectedIndexChanged;
            }
        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem is DataRowView drv)
            {
                var currentRow = addProduct.CurrentRow;
                if (currentRow != null)
                {
                    currentRow.Cells["product_price"].Value = drv["product_price"];
                }
            }
        }

        private void SaveTransaction()
        {
            var conn = new NpgsqlConnection(connString);
            conn.Open();
            var tran = conn.BeginTransaction();

            try
            {
                // Insert transaction
                var insertTransaction = new NpgsqlCommand(@"
                INSERT INTO transaction (transaction_date, total_amount, customer_id, vendors_id)
                VALUES (@date, @amount, @customer, @vendor) RETURNING transaction_id", conn, tran);

                insertTransaction.Parameters.AddWithValue("date", dateTimePicker1.Value.Date);
                insertTransaction.Parameters.AddWithValue("amount", decimal.Parse(totalAmountTxtBx.Text));
                insertTransaction.Parameters.AddWithValue("customer", (int)customerCombo.SelectedValue);
                insertTransaction.Parameters.AddWithValue("vendor", (int)vendorCombo.SelectedValue);

                int transactionId = (int)insertTransaction.ExecuteScalar();

                // Insert transaction_product rows
                foreach (DataGridViewRow row in addProduct.Rows)
                {
                    if (row.IsNewRow || row.Cells["product_id"].Value == null) continue;

                    int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                    int quantity = Convert.ToInt32(row.Cells["quantity"].Value);

                    var insertItem = new NpgsqlCommand(@"
                INSERT INTO transaction_product (transaction_id, product_id, quantity)
                VALUES (@tid, @pid, @qty)", conn, tran);

                    insertItem.Parameters.AddWithValue("tid", transactionId);
                    insertItem.Parameters.AddWithValue("pid", productId);
                    insertItem.Parameters.AddWithValue("qty", quantity);
                    insertItem.ExecuteNonQuery();
                }

                tran.Commit();
                MessageBox.Show("Transaction saved successfully.");
                LoadTransactionHistory(); // Refresh transaction history
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Error saving transaction: " + ex.Message);
            }


        }

        
        private void LoadTransactionHistory()
        {
            var conn = new NpgsqlConnection(connString);
            conn.Open();

            string query = @"
            SELECT 
                t.transaction_id,
                t.transaction_date,
                v.name || ' ' || v.surname AS vendor,
                c.customer_name || ' ' || c.customer_surname AS customer,
                t.total_amount,
                STRING_AGG(p.product_name || ' x' || tp.quantity, ', ') AS items
            FROM transaction t
            JOIN vendors v ON t.vendors_id = v.vendors_id
            JOIN customer c ON t.customer_id = c.customer_id
            JOIN transaction_product tp ON t.transaction_id = tp.transaction_id
            JOIN product p ON tp.product_id = p.product_id
            GROUP BY t.transaction_id, t.transaction_date, vendor, customer, t.total_amount
            ORDER BY t.transaction_date DESC";

            var adapter = new NpgsqlDataAdapter(query, conn);
            var dt = new DataTable();
            adapter.Fill(dt);

            transactionHistory.DataSource = dt;

            if (transactionHistory.Columns.Contains("transaction_id"))
                transactionHistory.Columns["transaction_id"].Visible = false;

            
            transactionHistory.Columns["transaction_date"].HeaderText = "Date";
            transactionHistory.Columns["vendor"].HeaderText = "Vendor Name";
            transactionHistory.Columns["customer"].HeaderText = "Customer Name";
            transactionHistory.Columns["total_amount"].HeaderText = "Total Amount";
            transactionHistory.Columns["items"].HeaderText = "Products";

            transactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void transactionFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = transactionFilter.Text.Trim().ToLower();

            if (transactionHistory.DataSource is DataTable dt)
            {
                var matches = dt.AsEnumerable().Where(row =>
                    row.Field<string>("vendor").ToLower().Contains(filter) ||
                    row.Field<string>("customer").ToLower().Contains(filter));

                transactionHistory.DataSource = matches.Any() ? matches.CopyToDataTable() : dt.Clone();
            }
        }

        private void saveNewTransaction_Click(object sender, EventArgs e)
        {
            SaveTransaction();
        }

        private void refreshTranHistory_Click(object sender, EventArgs e)
        {
            LoadTransactionHistory();
        }
    }
}
