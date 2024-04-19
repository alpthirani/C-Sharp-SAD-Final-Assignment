using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Categorisesfrm : Form
    {
        public Categorisesfrm()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Categorises_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
           
        }

        private void Xlbl_Click(object sender, EventArgs e)
        {
            // when click the X categorises from will close
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fantasyfrm fh = new Fantasyfrm();
            fh.Show();
            this.Hide();

        }

        private void ScienceFictionlbl_Click(object sender, EventArgs e)
        {
            Science_Fictionfrm fh = new Science_Fictionfrm();
            fh.Show();
            this.Hide();
        }

        private void ShortStorylbl_Click(object sender, EventArgs e)
        {
            Short_Storyfrm fh = new Short_Storyfrm();
            fh.Show();
            this.Hide();
        }

        private void GraphicNovellbl_Click(object sender, EventArgs e)
        {
            Graphic_Novelfrm fh = new Graphic_Novelfrm();
            fh.Show();
            this.Hide();
        }

        private void Mysterylbl_Click(object sender, EventArgs e)
        {
            Mysteryfrm fh = new Mysteryfrm();
            fh.Show();
            this.Hide();
        }

        private void Categoriseslbl_Click(object sender, EventArgs e)
        {
            Label selectedLabel =(Label)sender;
            string category = selectedLabel.Text;

            switch (category)
            {
                case "Fantasy":
                    Fantasyfrm  fantasyfrm = new Fantasyfrm(category);
                    fantasyfrm.Show();
                    break;

                case "Graphic Novel":
                    Graphic_Novelfrm Graphic_Novelfrm = new Graphic_Novelfrm(category);
                    Graphic_Novelfrm.Show();
                    break;

                case " Mysteryfrm":
                    Mysteryfrm Mysteryfrm = new Mysteryfrm(category);
                    Mysteryfrm.Show();
                    break;

                case "Science Fiction":
                    Science_Fictionfrm Science_Fictionfrm = new Science_Fictionfrm(category);
                    Science_Fictionfrm.Show();
                    break;

                case "Short Story":
                    Short_Storyfrm Short_Storyfrm = new Short_Storyfrm(category);
                    Short_Storyfrm.Show();
                    break;



            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fanlbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
