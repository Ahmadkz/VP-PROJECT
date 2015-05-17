using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AhmadProject
{
    public partial class Form3 : Form
    {
        Label firstclicked = null;
     //   Label ShowingIcon = null;
        
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
       
        public Form3()
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

       

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Cards_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
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
                if (ShowIcon.Text == firstclicked.Text)
                {
                    firstclicked = null;
                    ShowIcon_Click(sender, e);
                    Score.Show();
                }

                timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstclicked.ForeColor = firstclicked.BackColor;
            
            firstclicked = null;
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
                foreach (Control control1 in GameLayout.Controls)
                {
                    Label iconlabel1 = control1 as Label;
                    iconlabel1.ForeColor = iconlabel1.BackColor;
                }

                ShowIcon_Click(sender , e);
                
        }

        private void ShowIcon_Click(object sender, EventArgs e)
        {

    
                randomno = random.Next(iconshow.Count);
                ShowIcon.Text = iconshow[randomno];
                iconshow.RemoveAt(randomno);
               

               

     
        }

        private void Score_Click(object sender, EventArgs e)
        {
            
            Score.Text = "SCORE :" + score++.ToString();
            Score.Show();
        }


        public void YouWin()
        {
            MessageBox.Show("You Win the game");
        }
        

        

        



       



      

        

       
        
        
    }
}
