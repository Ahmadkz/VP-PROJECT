using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AhmadProject
{
    public partial class Form4 : Form
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
        public Form4()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        private void AssignIconsToSquares()
        {
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

        private void Startbutton_Click(object sender, EventArgs e)
        {

            score = Convert.ToInt32(File.ReadAllText(@"C:\Users\Ahmad\Documents\GitHub\VP-Project\ScoreSafe.txt"));
            score++;
                Score_Click(sender, e);
                foreach (Control control1 in GameLayout.Controls)
                {
                    Label iconlabel1 = control1 as Label;
                    iconlabel1.ForeColor = iconlabel1.BackColor;
                }

                ShowIcon2_Click(sender, e);

        }

        private void Score_Click(object sender, EventArgs e)
        {
            Score.Text = "SCORE: " + score;
            Score.Show();
        }

        private void cards_click(object sender, EventArgs e)
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
            
            if (ShowIcon2.Text == firstclicked.Text)
            {
                
                firstclicked = null;
                iconshow.RemoveAt(randomno);
                ShowIcon2_Click(sender, e);
                score++;
                Score_Click(sender, e);
                timer1.Stop();

            }
            else if (ShowIcon2.Text != firstclicked.Text)
            {
              
                score--;

                Score_Click(sender, e);
            }
            
                

                
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             timer1.Stop();
          
            firstclicked.ForeColor = firstclicked.BackColor;
            
            firstclicked = null;
        }

        private void ShowIcon2_Click(object sender, EventArgs e)
        {
            if (iconshow.Count != 1)
            {
                randomno = random.Next(iconshow.Count);
                ShowIcon2.Text = iconshow[randomno];
             
            }
            else 
            {
                File.WriteAllText(@"C:\Users\Ahmad\Documents\GitHub\VP-Project\ScoreSafe4.txt", score.ToString());
                Form5 obj5 = new Form5();
                obj5.Show();
            }
        }



        }

       
    }

