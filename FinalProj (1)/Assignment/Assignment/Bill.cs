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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\warun\Downloads\FinalProj (1)\Assignment\Assignment\Books.mdf"";Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from BOOKTable ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(BQtytxt.Text);
            try
            {
                Con.Open();
                string query = "update BOOKTable set Bquantity=" + newQty + " where BId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Book Updated Successfully");
                Con.Close();
                populate();
                //Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        int n = 0,Grantotal=0;
        private void Savebtn_Click(object sender, EventArgs e)
        {
            
            if (BQtytxt.Text == "" || Convert.ToInt32(BQtytxt.Text) > stock)
            {
                MessageBox.Show("No Enough stock");
            }
            else
            {
                int total = Convert.ToInt32(BQtytxt.Text) * Convert.ToInt32(Bpricetxt.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = Btitletxt.Text;
                newRow.Cells[2].Value = BQtytxt.Text;
                newRow.Cells[3].Value = Bpricetxt.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                n++;
                UpdateBook();
                Grantotal = Grantotal + total;
                Totallbl.Text = "Rs"+Grantotal;

                
            }
        }
        int key = 0,stock=0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Btitletxt.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            //Client.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
            //Bcategoriescm.SelectedItem = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            //BQtytxt.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
            Bpricetxt.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (Btitletxt.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());
                stock= Convert.ToInt32(BookDGV.SelectedRows[0].Cells[4].Value.ToString());
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            main obj = new main();
            obj.Show();
            this.Hide();
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            Btitletxt.Text = "";
            Clienttxt.Text = "";
            BQtytxt.Text = "";
            Bpricetxt.Text = "";
        }
        private void Editbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
