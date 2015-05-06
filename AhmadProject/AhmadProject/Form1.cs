using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AhmadProject
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
        private void Play_Click(object sender, EventArgs e)
        {
            Form2 obj2 = new Form2();
            obj2.Show();
            // this.Close();
        }
 //===============================Exit Button=======================================//
        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
