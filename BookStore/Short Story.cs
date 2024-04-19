using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Short_Storyfrm : Form
    {
        private string category;
        public Short_Storyfrm(string category)
        {
            InitializeComponent();
            this.category = category;
        }

        public Short_Storyfrm() : this("Default Category")
        {
            // You can set a default category here if needed
        }


        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Xlbl_Click(object sender, EventArgs e)
        {
            // when click the X Short Story from will close
            Application.Exit();
        }

        public void Short_Story_Load(object sender, EventArgs e)
        {
            DisplayBooksByCategory(category);
        }

        public void DisplayBooksByCategory( string category)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\OneDrive\\Documents\\Books.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            string query = "SELECT * FROM Booktable WHERE Category =@category";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@category", category);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    ShortStoryGridView.DataSource = dataTable;
                }
            }
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Categorisesfrm fh = new Categorisesfrm();
            fh.Show();
            this.Hide();
        }
    }
}
