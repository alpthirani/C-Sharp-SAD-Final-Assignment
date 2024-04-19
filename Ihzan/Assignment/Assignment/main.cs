using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            populate();
        }

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reset()
        {
            Btitletxt.Text = "";
            Bauthortxt.Text = "";
            Bcategoriescm.SelectedIndex = -1;
            Bqtytxt.Text = "";
            Bpricetxt.Text = "";
        }
        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Reset();
           
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("Fill Information","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                string query = "delete from BookTbl where BId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Deleted Sucess");
                Con.Close();
                populate();
                Reset();
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (Btitletxt.Text == "" || Bauthortxt.Text == "" || Bcategoriescm.SelectedIndex == -1 || Bqtytxt.Text == "" || Bpricetxt.Text == "") 
            {
                MessageBox.Show("Fill Information","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                string query = "update BookTbl set BTitle='" + Btitletxt.Text + "',BAuthor='" + Bauthortxt.Text + "',BCat='" + Bcategoriescm.SelectedItem.ToString() + "',BQty=" + Bqtytxt.Text + ",BPrice=" + Bpricetxt.Text + " where BId="+key+";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Update Sucessful","Done!");
                Con.Close();
                populate();
                Reset();
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Aasir-2001;Initial Catalog=Bookdb;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sda=new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder =new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void Filter()
        {
            Con.Open();
            string query = "select * from BookTbl where BCat='"+BsearchCmb.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (Btitletxt.Text == "" || Bauthortxt.Text == "" || Bcategoriescm.SelectedIndex == -1 || Bqtytxt.Text == "" || Bpricetxt.Text == "")
            {
                MessageBox.Show("Fill Information","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Con.Open();
                string query = "insert into BookTbl values('" + Btitletxt.Text + "','" + Bauthortxt.Text + "','" + Bcategoriescm.SelectedItem.ToString() + "'," + Bqtytxt.Text + "," + Bpricetxt.Text + ")";
                 SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Saved Successful","Done!");
                Con.Close();
                populate();
                Reset();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void gunaCirclePictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void gunaCirclePictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            user Obj = new user();
            Obj.Show();
            this.Hide();
        }

        private void gunaCirclePictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            populate();
            BsearchCmb.SelectedIndex = -1;
        }

        private void BsearchCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }
        int key = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Btitletxt.Text =BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            Bauthortxt.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
           Bcategoriescm.SelectedItem = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            Bqtytxt.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
            Bpricetxt.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
            if(Btitletxt.Text=="")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());       
            }

        }
    }
}
