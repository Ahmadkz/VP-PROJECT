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
            foreach (Control control in Gamelayout5.Controls)
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

        private void Cards_Click5(object sender, EventArgs e)
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
            
            if (IconShow5.Text == firstclicked.Text)
            {
                
                firstclicked = null;
                iconshow.RemoveAt(randomno);
                IconShow5_Click(sender, e);
                score++;
                Score_click5_Click(sender, e);
                timer1.Stop();

            }
            else if (IconShow5.Text != firstclicked.Text)
            {
              
                score--;

                Score_click5_Click(sender, e);
            }
            
                

                
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             timer1.Stop();
          
            firstclicked.ForeColor = firstclicked.BackColor;
            
            firstclicked = null;
        }

        private void StartButton5_Click(object sender, EventArgs e)
        {
            score = Convert.ToInt32(File.ReadAllText(@"C:\Users\Ahmad\Documents\GitHub\VP-Project\ScoreSafe4.txt"));
            score++;
                Score_click5_Click(sender, e);
                foreach (Control control1 in Gamelayout5.Controls)
                {
                    Label iconlabel1 = control1 as Label;
                    iconlabel1.ForeColor = iconlabel1.BackColor;
                }

                IconShow5_Click(sender, e);
        }

        private void IconShow5_Click(object sender, EventArgs e)
        {
            if (iconshow.Count != 1)
            {
                randomno = random.Next(iconshow.Count);
                IconShow5.Text = iconshow[randomno];
             
            }
            else 
            {
                WinGame();
            }
        }

        private void Score_click5_Click(object sender, EventArgs e)
        {
            Score_click5.Text = "SCORE: " + score;
            Score_click5.Show();
        }

        public void WinGame()
        {
            MessageBox.Show(string.Format("You have finsihed all level of Game your score is : ", score), "Congratulations", MessageBoxButtons.OK);
        }
     

        }
    }

