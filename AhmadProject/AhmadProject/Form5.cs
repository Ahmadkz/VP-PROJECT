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
    public partial class Form5 : Form
    {
         Label firstclicked = null;
       
        int score = 0;
        int randomno;
        Random random = new Random();
        List<string> icons = new List<string>()
    {
             "!","N",",","K",
             "b","v","w","z",
             "f","d","y","p",
             "l","M","c","g",
             "x","R","s","t",
	         "A","[","(","q",
	         "<","#","{","^",
	         "+","-"
    };
        List<string> iconshow = new List<string>()
    {
             "!","N",",","K",
             "b","v","w","z",
             "f","d","y","p",
             "l","M","c","g",
             "x","R","s","t",
	         "A","[","(","q",
	         "<","#","{","^",
	         "+","-"
    };

        public Form5()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        private void AssignIconsToSquares()
        {
            Form3 obj3 = new Form3();
            score = obj3.transferscore();

            foreach (Control control in GameLayout.Controls)
            {
                Label iconlabel = control as Label;
                if (iconlabel != null)
                {
                    int randomno = random.Next(icons.Count);
                    iconlabel.Text = icons[randomno];
                    icons.RemoveAt(randomno);

                }


            }



        }

        private void Cards_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                return;
            }
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                if (firstclicked == null)
                {
                    firstclicked = clickedLabel;
                    firstclicked.ForeColor = Color.Black;
                    return;
                }




            }

            timer1.Start();

            if (ShowIcon.Text == firstclicked.Text)
            {
                iconshow.RemoveAt(randomno);
                firstclicked = null;
                ShowIcon_Click(sender, e);
                score++;
                Score_click_Click(sender, e);
                timer1.Stop();

            }
            else if (ShowIcon.Text != firstclicked.Text)
            {

                score--;

                Score_click_Click(sender, e);
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstclicked.ForeColor = firstclicked.BackColor;

            firstclicked = null;
        }

        private void ShowIcon_Click(object sender, EventArgs e)
        {
            if (iconshow.Count != 0)
            {
                randomno = random.Next(iconshow.Count);
                ShowIcon.Text = iconshow[randomno];
                //  iconshow.RemoveAt(randomno);
            }
            else
            {
                wingame();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            score = 0;
            Score_click_Click(sender, e);
            foreach (Control control1 in GameLayout.Controls)
            {
                Label iconlabel1 = control1 as Label;
                iconlabel1.ForeColor = iconlabel1.BackColor;
            }

            ShowIcon_Click(sender, e);
        }

        private void Score_click_Click(object sender, EventArgs e)
        {
            Score_click.Text = "SCORE: " + score;
            Score_click.Show();
        }
        public void wingame()
        {
            MessageBox.Show("You Have finished all level your score is {0}", Score_click.Text);
        }

    }
}
