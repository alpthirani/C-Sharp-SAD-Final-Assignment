using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Fantasylbl_Click(object sender, EventArgs e)
        {
            Fantasy obj = new Fantasy();
            obj.Show();
            this.Hide();
        }

        private void ScienceFictionlbl_Click(object sender, EventArgs e)
        {
            Science obj = new Science();
            obj.Show();
            this.Hide();
        }

        private void ShortStorylbl_Click(object sender, EventArgs e)
        {
            ShortStory obj = new ShortStory();
            obj.Show();
            this.Hide();
        }
    }
}
