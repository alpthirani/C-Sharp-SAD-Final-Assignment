using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Most_popular_books
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Assuming you have fetched your data into a DataTable
            DataTable salesData = GetSalesData();

            // Sort the data by sales quantity or revenue column (assuming it's a numeric column)
            DataView sortedView = salesData.DefaultView;
            sortedView.Sort = "SalesQuantity DESC"; // Change SalesQuantity to the appropriate column name

            // Select the top 10 records
            DataTable top10Data = sortedView.ToTable().AsEnumerable().Take(10).CopyToDataTable();

            // Bind the top 10 data to the DataGridView
            dataGridView1.DataSource = top10Data;
        }

        // Method to fetch sample sales data
        private DataTable GetSalesData()
        {
            // Replace this with your actual data retrieval logic
            DataTable salesData = new DataTable();
            // Assume columns are SalesID, ProductName, SalesQuantity, Revenue
            salesData.Columns.Add("B_ID", typeof(int));
            salesData.Columns.Add("B_TITLE", typeof(string));
            salesData.Columns.Add("B_AUTHOR", typeof(string));
            salesData.Columns.Add("B_CATEGORY", typeof(string));
            salesData.Columns.Add("B_PRICE", typeof(decimal));

            // Fill in some sample data
            // Add your actual data here
            salesData.Rows.Add(1, "Product A", 100, 500.00);
            salesData.Rows.Add(2, "Product B", 150, 750.00);
            // Add more rows as needed

            return salesData;
        }
    }
}
