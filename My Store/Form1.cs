using System;
using System.Drawing;
using System.Windows.Forms;

namespace My_Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for form load
        private void Form1_Load(object sender, EventArgs e)
        {
           
                // Check if the username and password match admin credentials
               
            
        }

        // Event handler for username text changed (currently not used)
        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtUser.Text == "Admin" && txtPassword.Text == "Admin123")
            {
               
                CategoryForm category = new CategoryForm();
                category.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                // If credentials are incorrect, show an error message
                MessageBox.Show("Incorrect Username or Password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clear the username and password fields for another attempt
                txtUser.Clear();
                txtPassword.Clear();

                // Set focus back to the username field for convenience
                txtUser.Focus();
            }
        }
    }
}
