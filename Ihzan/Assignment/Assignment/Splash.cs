using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startops = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startops += 1;
            myprogress1.Value = startops;
            percentage1.Text = startops + "%";
            if(myprogress1.Value==100)
            {
                myprogress1.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
