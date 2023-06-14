using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melody_Music_Theams_1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "Admin123")
            {
                MessageBox.Show("Login Success!!!");
                Loadding loading = new Loadding();
                loading.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "User" && txtPassword.Text == "User123")
            {
                MessageBox.Show("Valid UserName & Password");
                Loadding loading = new Loadding();
                loading.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username & Passward");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
