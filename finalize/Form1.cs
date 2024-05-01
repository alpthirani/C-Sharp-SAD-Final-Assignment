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
using static System.Net.Mime.MediaTypeNames;

namespace finalize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection();
        private void populate()
        {
            Con.Open();
            string query = "select from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AddedListDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void Categoriseslbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        
        int key = 0;
        private void AddedList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            BTitleTb.Text = AddedListDGV.SelectedRows[0].Cells[1].Value.ToString(); 
            //QtyTb.Text = AddedListDGV.SelectedRows[0].Cells[4].Value.ToString(); 
            PriceTb.Text = AddedListDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (BTitleTb.Text == "")
            {
                Key = 0;
                Key = 0;
            }
            else 
            { 
                Key = Convert.ToInt32(AddedListDGV.SelectedRows[0].Cells[0].Value.ToString());
                Key = Convert.ToInt32(AddedListDGV.SelectedRows[0].Cells[4].Value.ToString());

            }


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            BTitleTb.Text = "";
            QtyTb.Text = "";
            PriceTb.Text = "";

        }
        private void button2_Click(object sender, EventArgs e)
        {
           Reset ();
        }
        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            try
            {
                Con.Open();
                string query = "update BookTbl set BQty=" + newQty + " where BId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Book Updated Successfully");
                Con.Close();
                populate();
                //Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (QtyTb.Text == "" || Convert.ToInt32(QtyTb.Text)>stock)
            {
                MessageBox.Show("No Enough stock");
            }
            else
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(QtyTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = BTitleTb.Text;
                newRow.Cells[2].Value = QtyTb.Text;
                newRow.Cells[3].Value = PriceTb.Text;
                BillDGV.Rows.Add (newRow);
                n++;
                UpdateBook();
              
            }
        }

        int Key = 0, stock = 0;
    }
}
