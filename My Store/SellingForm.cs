using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Store;

namespace My_Store
{
    public partial class SellingForm : Form
    {
       
        DBConnect dBCon = new DBConnect();  
        public SellingForm()
        {
            InitializeComponent();
        }



        private void getCategory()
        {
            string selectQuerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbCategory.DataSource = table;
            cmbCategory.ValueMember = "CatName";
        }

        private void getTable()
        {
            string selectQuerry = "SELECT ProdName, ProdPrice FROM Product";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewProduct.DataSource = table;
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_Date.Text = DateTime.Today.ToShortDateString();
            getTable();
            getCategory();
            getSellTable();
        }

        private void DataGridViewProduct_Click(object sender, EventArgs e)
        {
            txtName.Text = DataGridViewProduct.SelectedRows[0].Cells[0].Value.ToString();
            txtPrice.Text = DataGridViewProduct.SelectedRows[0].Cells[1].Value.ToString();
        }

        int grandTotal = 0, totalQuantity = 0, n = 0;

        private void getSellTable()
        {
            string selectQuerry = "SELECT * FROM Bill";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewSell.DataSource = table;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Bill VALUES(" + txtBill.Text + ",'" + label_seller.Text + "','" + label_Date.Text + "'," + grandTotal.ToString() + ")";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
        private void DataGridViewSell_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void label_Date_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridViewProduct_Click_1(object sender, EventArgs e)
        {
            txtName.Text = DataGridViewProduct.SelectedRows[0].Cells[0].Value.ToString();
            txtPrice.Text = DataGridViewProduct.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT ProdName, ProdPrice FROM Product WHERE ProdCat='" + cmbCategory.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewProduct.DataSource = table;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clear()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtQuanity.Clear();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtQuanity.Text == "")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int price = Convert.ToInt32(txtPrice.Text); // Get price from txtPrice
                    int quantity = Convert.ToInt32(txtQuanity.Text); // Get quantity from txtQuanity
                    int total =  quantity; // Calculate total for the current item

                    // Add a new row to DataGridViewOrder
                    DataGridViewRow addRow = new DataGridViewRow();
                    addRow.CreateCells(DataGridViewOrder);
                    addRow.Cells[0].Value = ++n; // Row number
                    addRow.Cells[1].Value = txtName.Text; // Product name
                    addRow.Cells[2].Value = price; // Product price
                    addRow.Cells[3].Value = quantity; // Product quantity
                    addRow.Cells[4].Value = total; // Total for the current row
                    DataGridViewOrder.Rows.Add(addRow);

                    // Update grand total and total quantity
                    grandTotal += total;
                    totalQuantity += quantity;

                    // Update label_amount to show both grand total and total quantity
                    label_amount.Text = $"Total: {grandTotal} ";
                    clear();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numeric values for Price and Quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
