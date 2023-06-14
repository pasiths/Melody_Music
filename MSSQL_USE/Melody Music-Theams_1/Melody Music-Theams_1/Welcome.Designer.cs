
namespace Melody_Music_Theams_1
{
    partial class Welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Melody_Music_Theams_1.Properties.Resources.Melody_Music_2_Welcome_Page;
            this.panel1.Controls.Add(this.btnGetStart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 768);
            this.panel1.TabIndex = 0;
            // 
            // btnGetStart
            // 
            this.btnGetStart.BackColor = System.Drawing.Color.White;
            this.btnGetStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetStart.FlatAppearance.BorderSize = 0;
            this.btnGetStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStart.Location = new System.Drawing.Point(609, 660);
            this.btnGetStart.Name = "btnGetStart";
            this.btnGetStart.Size = new System.Drawing.Size(219, 51);
            this.btnGetStart.TabIndex = 3;
            this.btnGetStart.Text = "Get Start";
            this.btnGetStart.UseVisualStyleBackColor = false;
            this.btnGetStart.Click += new System.EventHandler(this.btnGetStart_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 65);
            this.label2.TabIndex = 0;
            this.label2.Text = "It is the foreground to the background accompaniment. A line or part need not to " +
    "be foreground melody.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 196);
            this.label1.TabIndex = 0;
            this.label1.Text = "A melody also tune,voice or line,is a linear succession of musical tones that the" +
    " listener\nPerceives as a single entity.\nIn its most literal sense, a melody is a" +
    " combination of pitch and rhythm.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Welcome_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}