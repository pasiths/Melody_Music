
namespace Melody_Music_Theams_2
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
            this.btnGetStart = new System.Windows.Forms.Button();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetStart
            // 
            this.btnGetStart.BackColor = System.Drawing.Color.White;
            this.btnGetStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetStart.FlatAppearance.BorderSize = 0;
            this.btnGetStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStart.Location = new System.Drawing.Point(257, 662);
            this.btnGetStart.Name = "btnGetStart";
            this.btnGetStart.Size = new System.Drawing.Size(178, 40);
            this.btnGetStart.TabIndex = 5;
            this.btnGetStart.Text = "Get Start";
            this.btnGetStart.UseVisualStyleBackColor = false;
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::Melody_Music_Theams_2.Properties.Resources.Close_red;
            this.picClose.Location = new System.Drawing.Point(969, 6);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(45, 37);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 6;
            this.picClose.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Melody_Music_Theams_2.Properties.Resources.Melody_Music_Welcome_Page;
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.btnGetStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 768);
            this.panel1.TabIndex = 0;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGetStart;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel panel1;
    }
}