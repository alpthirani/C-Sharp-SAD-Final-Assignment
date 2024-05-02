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
    public partial class ShortStory : Form
    {
        public ShortStory()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\warun\Downloads\FinalProj (1)\Assignment\Assignment\Books.mdf"";Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from BOOKTable where Bcatagories= 'SHORT STORY BOOKS' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ShortDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void ShortStorylbl_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Categories Obj=new Categories();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void ShortStory_Load(object sender, EventArgs e)
        {

        }
    }
}
