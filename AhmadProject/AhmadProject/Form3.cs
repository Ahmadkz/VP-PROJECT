using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace AhmadProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void nEWGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 obj3 = new Form3();
            this.Close();
            obj3.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void iNSTRUCTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Flip over two cards, if they match they will disappear, if they don't... remember them and flip over more cards. Win by matching all the cards.");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
     

        
    }
}
