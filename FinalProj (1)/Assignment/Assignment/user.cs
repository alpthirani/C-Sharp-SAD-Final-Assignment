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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\warun\Downloads\FinalProj (1)\Assignment\Assignment\Books.mdf"";Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from UserTable ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];

            Con.Close();
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

        private void label8_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (Usertxt.Text == "" || Phonetxt.Text == "" || Addtxt.Text=="" || Passtxt.Text == "" )
            {
                MessageBox.Show("Fill Inforamtion", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                string query = "insert into UserTable values('" + Usertxt.Text + "','" + Phonetxt.Text + "','" +Addtxt.Text+ "','"+Passtxt.Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Saved successful", "Done!");
                Con.Close();
                populate();
                Reset();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Reset()
        {
            Usertxt.Text = "";
            Phonetxt.Text = "";
            Addtxt.Text = "";
            Passtxt.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Fill Information","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                string query = "delete from UserTable where UId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Deleted successful", "Done!");
                Con.Close();
                populate();
                Reset();
            }
        }
        int key = 0;
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Usertxt.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            Phonetxt.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            Addtxt.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();
            Passtxt.Text = UserDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (Usertxt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UserDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (Usertxt.Text == "" || Phonetxt.Text == "" || Addtxt.Text == "" || Passtxt.Text == "")
            {
                MessageBox.Show("Fill Information","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                string query = "update UserTable set UName='" + Usertxt.Text + "',UPhone='" + Phonetxt.Text + "',UAddress='" + Addtxt.Text + "',UPassword='" + Passtxt.Text + "' where UId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Update  successful", "Done!");
                Con.Close();
                populate();
                Reset();
            }
        }

        private void Categoriseslbl_Click(object sender, EventArgs e)
        {
            Categories obj = new Categories();
            obj.Show();
            this.Hide();
        }
    }
}
