using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectAhmad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void nEWGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 obj2 = new Form2();
            obj2.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
