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

    }
}
