using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bensqloginwindowsforms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
