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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            main Obj = new main();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            user Obj = new user();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Categoriseslbl_Click(object sender, EventArgs e)
        {
            Categories obj = new Categories();
            obj.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Aasir-2001;Initial Catalog=Bookdb;Integrated Security=True");
        private void Dashboard_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select sum(BQty) from BookTb1", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BookStockLbl.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("Select sum(BQty) from BookTb1", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            UserStockLbl.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("Select sum(BQty) from BookTb1", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            TotalAmountStockLbl.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter sda3 = new SqlDataAdapter("Select sum(BQty) from BookTb1", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            SellsStockLbl.Text = dt2.Rows[0][0].ToString();
            Con.Close();
        }
    }
}
