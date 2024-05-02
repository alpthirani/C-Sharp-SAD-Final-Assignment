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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Aasir-2001;Initial Catalog=Bookdb;Integrated Security=True");
        public static string UName = "";
        private void gunaButton1_Click(object sender, EventArgs e)
        {
          Con.Open();
            SqlDataAdapter sda =new SqlDataAdapter("select count(*) from UserTbl where UName='"+Usertxt.Text+"' and Upass='"+Passtxt.Text+"'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                MessageBox.Show("Login Successful","Done!",MessageBoxButtons.OK);
                UName = Usertxt.Text;
                Bill obj = new Bill();
                obj.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password","Warning",MessageBoxButtons.AbortRetryIgnore);
            }
          Con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Admin obj =new Admin();
            obj.Show();
            this.Hide();
        }
    }
}
