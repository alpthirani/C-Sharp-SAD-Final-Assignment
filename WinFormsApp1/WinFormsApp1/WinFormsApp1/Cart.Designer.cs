namespace WinFormsApp1
{
    partial class Cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Price = new TextBox();
            button4 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ResetBtn = new Button();
            Add = new Button();
            Qty = new TextBox();
            Title = new TextBox();
            UserLbl = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            label5 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            LogOut = new Button();
            label1 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            imageList1 = new ImageList(components);
            label11 = new Label();
            label9 = new Label();
            List = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Book = new DataGridView();
            TotalLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)List).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Book).BeginInit();
            SuspendLayout();
            // 
            // Price
            // 
            Price.Location = new Point(340, 276);
            Price.Name = "Price";
            Price.Size = new Size(100, 23);
            Price.TabIndex = 34;
            // 
            // button4
            // 
            button4.Location = new Point(859, 508);
            button4.Name = "button4";
            button4.Size = new Size(72, 28);
            button4.TabIndex = 19;
            button4.Text = "Print";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.book_user;
            pictureBox3.Location = new Point(340, 77);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 38);
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.book;
            pictureBox2.Location = new Point(552, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // ResetBtn
            // 
            ResetBtn.Cursor = Cursors.Hand;
            ResetBtn.Location = new Point(527, 276);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(75, 23);
            ResetBtn.TabIndex = 30;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // Add
            // 
            Add.Cursor = Cursors.Hand;
            Add.Location = new Point(446, 276);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 29;
            Add.Text = "Add to Bill";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Qty
            // 
            Qty.Location = new Point(498, 204);
            Qty.Name = "Qty";
            Qty.Size = new Size(100, 23);
            Qty.TabIndex = 28;
            // 
            // Title
            // 
            Title.Location = new Point(340, 204);
            Title.Name = "Title";
            Title.Size = new Size(100, 23);
            Title.TabIndex = 27;
            // 
            // UserLbl
            // 
            UserLbl.AutoSize = true;
            UserLbl.Font = new Font("Segoe UI", 10F);
            UserLbl.Location = new Point(382, 84);
            UserLbl.Name = "UserLbl";
            UserLbl.Size = new Size(77, 19);
            UserLbl.TabIndex = 26;
            UserLbl.Text = "User Name";
            UserLbl.Click += UserLbl_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LogOut);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 634);
            panel1.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Location = new Point(38, 372);
            panel5.Name = "panel5";
            panel5.Size = new Size(245, 45);
            panel5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Bookman Old Style", 16F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(73, 9);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 4;
            label5.Text = "Finalize";
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Location = new Point(38, 306);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 45);
            panel4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Bookman Old Style", 16F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(70, 11);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 3;
            label4.Text = "Latest";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Location = new Point(38, 242);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 45);
            panel3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Bookman Old Style", 16F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(54, 9);
            label3.Name = "label3";
            label3.Size = new Size(165, 25);
            label3.TabIndex = 2;
            label3.Text = "Most Populor";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(38, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 45);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Bookman Old Style", 16F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 11);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 1;
            label2.Text = "Categories";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.book_shop__2_;
            pictureBox1.Location = new Point(35, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LogOut
            // 
            LogOut.Cursor = Cursors.Hand;
            LogOut.Font = new Font("Bookman Old Style", 16F, FontStyle.Bold);
            LogOut.Image = Properties.Resources.logout;
            LogOut.ImageAlign = ContentAlignment.MiddleLeft;
            LogOut.Location = new Point(12, 509);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(279, 52);
            LogOut.TabIndex = 5;
            LogOut.Text = "Log Out";
            LogOut.UseVisualStyleBackColor = true;
            LogOut.Click += LogOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Bookman Old Style", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(108, 76);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 0;
            label1.Text = "Book Shop";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold);
            label10.Location = new Point(527, 9);
            label10.Name = "label10";
            label10.Size = new Size(146, 28);
            label10.TabIndex = 24;
            label10.Text = "Book Shop";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(498, 165);
            label8.Name = "label8";
            label8.Size = new Size(63, 19);
            label8.TabIndex = 23;
            label8.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(527, 351);
            label7.Name = "label7";
            label7.Size = new Size(35, 19);
            label7.TabIndex = 22;
            label7.Text = "Cart";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(340, 244);
            label6.Name = "label6";
            label6.Size = new Size(38, 19);
            label6.TabIndex = 21;
            label6.Text = "Price";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(340, 165);
            label11.Name = "label11";
            label11.Size = new Size(80, 19);
            label11.TabIndex = 25;
            label11.Text = "Book Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(776, 136);
            label9.Name = "label9";
            label9.Size = new Size(65, 19);
            label9.TabIndex = 36;
            label9.Text = "Book List";
            label9.Click += label9_Click;
            // 
            // List
            // 
            List.BackgroundColor = Color.FromArgb(226, 235, 240);
            List.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            List.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, Column6, Column7 });
            List.Location = new Point(323, 374);
            List.Name = "List";
            List.Size = new Size(454, 222);
            List.TabIndex = 37;
            List.CellContentClick += List_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "B.ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "B.Title";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "B.Author";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "B.Catrgories";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "B.Price";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 50;
            // 
            // Column6
            // 
            Column6.HeaderText = "Quantity";
            Column6.Name = "Column6";
            Column6.Width = 60;
            // 
            // Column7
            // 
            Column7.HeaderText = "Total";
            Column7.Name = "Column7";
            Column7.Width = 60;
            // 
            // Book
            // 
            Book.BackgroundColor = Color.FromArgb(226, 235, 240);
            Book.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Book.Location = new Point(691, 165);
            Book.Name = "Book";
            Book.Size = new Size(240, 150);
            Book.TabIndex = 38;
            Book.CellContentClick += Book_CellContentClick;
            // 
            // TotalLbl
            // 
            TotalLbl.AutoSize = true;
            TotalLbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            TotalLbl.Location = new Point(874, 486);
            TotalLbl.Name = "TotalLbl";
            TotalLbl.Size = new Size(42, 19);
            TotalLbl.TabIndex = 39;
            TotalLbl.Text = "Total";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 235, 240);
            ClientSize = new Size(974, 633);
            Controls.Add(TotalLbl);
            Controls.Add(Book);
            Controls.Add(List);
            Controls.Add(label9);
            Controls.Add(Price);
            Controls.Add(button4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(ResetBtn);
            Controls.Add(Add);
            Controls.Add(Qty);
            Controls.Add(Title);
            Controls.Add(UserLbl);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cart";
            Text = "Cart";
            Load += Cart_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)List).EndInit();
            ((System.ComponentModel.ISupportInitialize)Book).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Price;
        private Button button4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button ResetBtn;
        private Button Add;
        private TextBox Qty;
        private TextBox Title;
        private Label UserLbl;
        private Panel panel1;
        private Panel panel5;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Button LogOut;
        private Label label1;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private ImageList imageList1;
        private Label label11;
        private Label label9;
        private DataGridView List;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridView Book;
        private Label TotalLbl;
    }
}