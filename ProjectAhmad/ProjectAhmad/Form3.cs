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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            prograssbar();
        }
 //===============================Timer=======================================//   
        private Timer time = new Timer();
        
        public void prograssbar()
        {
            
            time.Interval = 250;
            time.Tick += new EventHandler(progressBar2_Click);
            time.Start();
           
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

//===============================Progress bar function=======================================// 
        private void progressBar2_Click(object sender, EventArgs e)
        {
            Form2 obj2 = new Form2();
            progressBar2.Increment(2);
            label1.Text = "LOADING  "+progressBar2.Value.ToString()+"%";
            if (progressBar2.Value == progressBar2.Maximum)
            {
                time.Stop();
                this.Hide();
                obj2.Show();
            }
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

    }
}
