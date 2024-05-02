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
    public partial class Fantasy : Form
    {
        public Fantasy()
        {
            InitializeComponent();
            
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\warun\Downloads\FinalProj (1)\Assignment\Assignment\Books.mdf"";Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from BOOKTable where Bcatagories= 'FANTASY BOOKS' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FantasyDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void Fantasylbl_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void FantasyDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void Fantasy_Load(object sender, EventArgs e)
        {

        }
    }
}
