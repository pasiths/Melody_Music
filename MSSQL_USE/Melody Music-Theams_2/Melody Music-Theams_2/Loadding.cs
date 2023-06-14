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
    public partial class Loadding : Form
    {
        public Loadding()
        {
            InitializeComponent();
        }

        private void Loadding_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 4;
            }
            else
            {
                timer1.Enabled = false;
                Student student = new Student();
                this.Hide();
                student.Show();
            }
        }
    }
}
