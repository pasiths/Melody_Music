using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melody_Music_Theams_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Do you want to Exit?", "Exit",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2,
            MessageBoxOptions.DefaultDesktopOnly);
            if (dl.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Do you want to Exit?", "Exit",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2,
            MessageBoxOptions.DefaultDesktopOnly);
            if (dl.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "Admin123")
            {
                MessageBox.Show("Valid UserName & Password");
                Loadding loading = new Loadding();
                loading.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "User" && txtPassword.Text == "User123")
            {
                MessageBox.Show("Valid UserName & Password");
#pragma warning disable CS0246 // The type or namespace name 'Loading' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'Loading' could not be found (are you missing a using directive or an assembly reference?)
                Loadding loading = new Loadding();
#pragma warning restore CS0246 // The type or namespace name 'Loading' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning restore CS0246 // The type or namespace name 'Loading' could not be found (are you missing a using directive or an assembly reference?)
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
    }
}
