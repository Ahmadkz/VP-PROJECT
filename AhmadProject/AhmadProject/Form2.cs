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

        private void LoadingBar_Click(object sender, EventArgs e)
        {
            Form3 obj4 = new Form3();
            LoadingBar.Increment(8);
            label1.Text = "LOADING  " + LoadingBar.Value.ToString() + "%";
            if (LoadingBar.Value == LoadingBar.Maximum)
            {
                time.Stop();
                obj4.Show();
                this.Close();
                
            }

        }

//===============================Timer=======================================//
        private Timer time = new Timer();

        public void prograssbar()
        {

            time.Interval = 250;
            time.Tick += new EventHandler(LoadingBar_Click);
            time.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }


    }
}
