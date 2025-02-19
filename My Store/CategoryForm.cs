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
    public partial class CategoryForm : Form
    {

        DBConnect dBCon = new DBConnect();
        public CategoryForm()
        {
            InitializeComponent();
        }

        public void getTable()
        {
            string selectQaerry = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQaerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridViewCategory.DataSource = table;
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mystoresystemDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.mystoresystemDataSet.Category);
            getTable();
        }


        private void clear()
        {
            txtID.Clear();
            txtName.Clear();
            txtDescription.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Category VALUES(" + txtID.Text + ", '" + txtName.Text + "', '" + txtDescription.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
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
                if (txtID.Text == "" || txtName.Text == "" || txtDescription.Text == "")
                {
                    MessageBox.Show("Missing Informaion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Category SET CatName='" + txtName.Text + "', CatDes='" + txtDescription.Text + "'WHERE CatId= " + txtID.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully", "Updated Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM Category WHERE CatId=" + txtID.Text + "";
                SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Delected Successfully", "Delected Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridViewCategory_Click(object sender, EventArgs e)
        {
            txtID.Text = DataGridViewCategory.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = DataGridViewCategory.SelectedRows[0].Cells[1].Value.ToString();
            txtDescription.Text = DataGridViewCategory.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
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
