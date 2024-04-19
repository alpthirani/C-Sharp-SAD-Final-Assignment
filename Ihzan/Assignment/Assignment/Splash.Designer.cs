namespace Assignment
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.label2 = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox6 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.percentage1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.myprogress1 = new Guna.UI.WinForms.GunaProgressBar();
            this.myprogress = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(196, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "BOOK MANAGMENT SYSTEM";
            // 
            // gunaCirclePictureBox6
            // 
            this.gunaCirclePictureBox6.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox6.Image")));
            this.gunaCirclePictureBox6.Location = new System.Drawing.Point(285, 82);
            this.gunaCirclePictureBox6.Name = "gunaCirclePictureBox6";
            this.gunaCirclePictureBox6.Size = new System.Drawing.Size(214, 182);
            this.gunaCirclePictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox6.TabIndex = 24;
            this.gunaCirclePictureBox6.TabStop = false;
            this.gunaCirclePictureBox6.UseTransfarantBackground = false;
            // 
            // percentage1
            // 
            this.percentage1.AutoSize = true;
            this.percentage1.BackColor = System.Drawing.Color.Transparent;
            this.percentage1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage1.ForeColor = System.Drawing.Color.Black;
            this.percentage1.Location = new System.Drawing.Point(454, 361);
            this.percentage1.Name = "percentage1";
            this.percentage1.Size = new System.Drawing.Size(37, 34);
            this.percentage1.TabIndex = 26;
            this.percentage1.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(281, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 34);
            this.label3.TabIndex = 27;
            this.label3.Text = "Loading...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // myprogress1
            // 
            this.myprogress1.BorderColor = System.Drawing.Color.Black;
            this.myprogress1.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.myprogress1.IdleColor = System.Drawing.Color.Transparent;
            this.myprogress1.Location = new System.Drawing.Point(4, 410);
            this.myprogress1.Name = "myprogress1";
            this.myprogress1.ProgressMaxColor = System.Drawing.Color.Navy;
            this.myprogress1.ProgressMinColor = System.Drawing.Color.Navy;
            this.myprogress1.Size = new System.Drawing.Size(795, 11);
            this.myprogress1.TabIndex = 28;
            // 
            // myprogress
            // 
            this.myprogress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.myprogress.Location = new System.Drawing.Point(363, 291);
            this.myprogress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myprogress.Name = "myprogress";
            this.myprogress.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.myprogress.Size = new System.Drawing.Size(64, 64);
            this.myprogress.TabIndex = 29;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.myprogress);
            this.Controls.Add(this.myprogress1);
            this.Controls.Add(this.percentage1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gunaCirclePictureBox6);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox6;
        private System.Windows.Forms.Label percentage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaProgressBar myprogress1;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator myprogress;
    }
}