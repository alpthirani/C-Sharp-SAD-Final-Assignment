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

namespace Bookshop_login_and_sign_in
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection Con=new SqlConnection(@"Data Source=Aasir-2001;Initial Catalog=Bookdb;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda=new SqlDataAdapter("select count(*) from UserTbl where Uname='"+UnameTb.Text+"' and UPass='"+UPassTb.Text+"'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Books obj = new Books();
                obj.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("wrong username or password");
            }
            Con.Close();


        }

        private void label4_Click(object sender, EventArgs e)
        {
            AdminLogin obj=new AdminLogin();
            obj.Show();
            this.Hide();
        }
    }
}
