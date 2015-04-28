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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
 //===============================Play Button=======================================//
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 obj3 = new Form3();
           // this.Close();
            obj3.Show();
            
        }
//===============================Exit Button=======================================//
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

      

    }
}
