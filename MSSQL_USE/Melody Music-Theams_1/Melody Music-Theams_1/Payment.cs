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

namespace Melody_Music_Theams_1
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-68QNKBQ\\SQL;Initial Catalog=MelodyMusic;Integrated Security=True";
            commandString = "SELECT RegNo FROM Payment";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            SqlDataReader reader = null;
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                cboRegNo.Items.Add(reader[0]);
            }
            reader.Close();
            conn.Close();

            cboPayment.Items.Add("Cash");
            cboPayment.Items.Add("Credit Card");
        }

        private void cboRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-68QNKBQ\\SQL;Initial Catalog=MelodyMusic;Integrated Security=True";
            commandString = "SELECT * FROM Payment WHERE RegNo='" + cboRegNo.Text + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            SqlDataReader reader = null;
            try
            { conn.Open(); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                txtCName.Text = reader[1].ToString();
                cboPayment.Text = reader[2].ToString();
                txtAmount.Text = reader[3].ToString();

            }
            reader.Close();
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-68QNKBQ\\SQL;Initial Catalog=MelodyMusic;Integrated Security=True";
            commandString = "INSERT INTO Payment VALUES ('" + cboRegNo.Text + "','" + txtCName.Text + "','" + cboPayment.Text + "','" + txtAmount.Text + "')";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Added Succesfully");
            cboRegNo.Items.Add(cboRegNo.Text);
            Clear();
            cboRegNo.Focus();
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-68QNKBQ\\SQL;Initial Catalog=MelodyMusic;Integrated Security=True";
            commandString = "UPDATE Payment SET CName = '" + txtCName.Text + "', Payment = '" + cboPayment.Text + "', Amount = '" + txtAmount.Text + "'where RegNo = '" + cboRegNo.Text + "'";
            if (MessageBox.Show("Are you sure, you want to Update this record ? ", "Sure ? ", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;

            }
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Updated Succesfully");
            Clear();
            cboRegNo.Focus();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString, commandString;
            connectionString = "Data Source=DESKTOP-68QNKBQ\\SQL;Initial Catalog=MelodyMusic;Integrated Security=True";
            commandString = "DELETE Payment FROM Payment where Payment.RegNo = '" + cboRegNo.Text + "'";
            if (MessageBox.Show("Are you sure, you want to delete this record ? ", "Sure ? ", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand(commandString, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
            conn.Close();
            cboRegNo.Items.Remove(cboRegNo.Text);
            cboRegNo.Focus();
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboRegNo.Text = "";
            txtCName.Text = "";
            cboPayment.Text = "";
            txtAmount.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            this.Hide();
            course.Show();
        }

        public void Clear()
        {
            cboRegNo.Text = "";
            txtCName.Text = "";
            cboPayment.Text = "";
            txtAmount.Text = "";
        }

        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
