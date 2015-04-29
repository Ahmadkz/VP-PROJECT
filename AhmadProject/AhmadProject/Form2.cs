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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            prograssbar();
        }

//===============================Progress bar function=======================================// 

        private void progressBar1_Click(object sender, EventArgs e)
        {
            Form3 obj3 = new Form3();
            progressBar1.Increment(2);
            label1.Text = "LOADING  " + progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                time.Stop();
                this.Hide();
                obj3.Show();
            }

        }

//===============================Timer=======================================//
        private Timer time = new Timer();

        public void prograssbar()
        {

            time.Interval = 250;
            time.Tick += new EventHandler(progressBar1_Click);
            time.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
