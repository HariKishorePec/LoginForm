using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void ClrForm()
        {
            txtPass.Text = "";
            txtUser.Text = "";
        }
        private void label3_Click(object sender, EventArgs e)
        {
            string name = txtUser.Text;
            string pass = txtPass.Text;
            if (name.Equals("Hari") && pass.Equals("kishore"))
            {
                MessageBox.Show("Login Successful.", "Successful", MessageBoxButtons.OK);
                ClrForm();
            }
            else
            {
                MessageBox.Show("Please enter coorect credentials.", "login failed", MessageBoxButtons.RetryCancel);
                ClrForm();
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
