using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Store;


namespace My_Store
{
    public partial class ProductForm : Form
    {

        DBConnect dBCon = new DBConnect();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            cmbSearch.DataSource = table;
            cmbSearch.ValueMember = "CatName";
        }

        private void getTable()
        {
            string selectQuerry = "SELECT * FROM Product";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewProduct.DataSource = table;
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mystoresystemDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.mystoresystemDataSet.Product);
            getCategory();
            getTable();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void clear()
        {
            txtID.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            cmbCategory.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Product VALUES(" + txtID.Text + ",'" + txtName.Text + "'," + txtPrice.Text + "," + txtQty.Text + ",'" + cmbCategory.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtQty.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string updateQuery = "UPDATE Product SET ProdName='" + txtName.Text + "',ProdPrice=" + txtPrice.Text + ",ProdQty=" + txtQty.Text + ",ProdCat='" + cmbCategory.Text + "'WHERE ProdId=" + txtID.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridViewProduct_Click(object sender, EventArgs e)
        {
            txtID.Text = DataGridViewProduct.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = DataGridViewProduct.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Text = DataGridViewProduct.SelectedRows[0].Cells[2].Value.ToString();
            txtQty.Text = DataGridViewProduct.SelectedRows[0].Cells[3].Value.ToString();
            cmbCategory.SelectedValue = DataGridViewProduct.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Missing Information", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM Product WHERE ProdId=" + txtID.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT * FROM Product WHERE ProdCat='" + cmbSearch.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewProduct.DataSource = table;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void btnSlling_Click(object sender, EventArgs e)
        {
            SellingForm sellingForm = new SellingForm();
            sellingForm.Show();
            this.Hide();
        }

       
    }
}
