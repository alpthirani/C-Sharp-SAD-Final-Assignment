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

namespace WinFormsApp1
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Milan\OneDrive\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True")
        private void populate()
        {
            Con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sba = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sba);
            var ds = new DataSet();
            sba.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Cart_Load(object sender, EventArgs e)
        {
            UserLbl.Text = Login.UserName;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            Cart f1 = new Cart();
            f1.Show();

        }
        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(Qty.Text);
            try
            {
                Con.Open();
                string query = "Update BookTbl set BQty=" + newQty + " where BId" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Book Update successfully");
                Con.Close();
                populate();
                //Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int n = 0, Grdtotal = 0;
        private void Add_Click(object sender, EventArgs e)
        {
            if (Qty.Text == "" || Convert.ToInt32(Qty.Text) > stock)
            {
                MessageBox.Show("No Enough Stock");
            }
            else
            {
                int total = Convert.ToInt32(Qty.Text) * Convert.ToInt32(Price.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = Title.Text;
                newRow.Cells[2].Value = Qty.Text;
                newRow.Cells[3].Value = Price.Text;
                newRow.Cells[0].Value = total;
                BillDGV.Rows.Add(newRow);
                n++;
                UpdateBook();
                Grdtotal = Grdtotal + total;
                TotalLbl.Text = "Rs" + Grdtotal;
            }
        }
        int key = 0, stock = 0;
        private void Book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Title.Text = BookDGV.SelectedRow[0].Cell[1].Value.ToString();
            //Qty.Text = BookDGV.SelectedRow[0].Cell[1].Value.ToString();
            Price = BookDGV.SelectedRow[0].Cell[1].Value.ToString();
            if (Qty.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.SelectedRow[0].Cell[0].Value.ToString());
                stock = Convert.ToInt32(BookDGV.SelectedRow[0].Cell[0].Value.ToString());

            }
        }
        private void Reset()
        {
            Title.Text = "";
            Qty.Text = "";
            Price.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
