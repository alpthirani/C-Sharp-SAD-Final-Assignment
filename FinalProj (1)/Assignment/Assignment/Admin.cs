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

namespace Assignment
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login obj =new Login();
            obj.Show();
            this.Hide();
        }
        
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
            if (Usertxt.Text=="password")
            {
                MessageBox.Show("Login Successful", "Done!", MessageBoxButtons.OK);
                
                main obj = new main();
                obj.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Wrong Password", "Warning", MessageBoxButtons.AbortRetryIgnore);
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
