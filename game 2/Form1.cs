using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_2
{
    public partial class Form1 : Form
    {
        int page = 1;
        double random;

        public Form1()
        {
            InitializeComponent();
            storyLabel.Text = "you have tow doors door one you don't now were it gos and door tow leds to a bathroom";
            button1.Text = "door one";
            button2.Text = "door two";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 99;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                // 99 or 100
                page = 99;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 99)
            {
                page = 101;
            }
            else if (page == 100)
            {
                page = 101;
            }
            else if (page == 101)
            {
                page = 1;
            }
            else if (page == 102)
            {
                page = 900;
            }
            else if (page == 900)
            {
                storyLabel.Text = ":)";
            }

            switch (page)
            {
                case 1:
                    storyLabel.Text = "you have tow doors door one you don't now were it gos and door tow leds to a bathroom";
                    button1.Text = "door one";
                    button2.Text = "door two";
                    break;
                case 2:
                    storyLabel.Text = "go to the end page";
                    button1.Text = "end page";
                    button2.Text = "end page";
                    break;
                case 3:
                    storyLabel.Text = "do you stay in the bathroom or leave";
                    button1.Text = "stay";
                    button2.Text = "leave";
                    break;
                case 4:
                    storyLabel.Text = "there is a wendow do you jump out or stay in the bathroom";
                    button1.Text = "jump";
                    button2.Text = "stay";
                    break;
                case 5:
                    storyLabel.Text = "go to the end page";
                    button1.Text = "end page";
                    button2.Text = "end page";
                    break;
                case 6:
                    storyLabel.Text = "you jump out";
                    button1.Text = "end page";
                    button2.Text = "and pag";
                    break;
                case 7:
                    storyLabel.Text = "you stay and get killed";
                    button1.Text = "end page";
                    button2.Text = "end pag";
                    break;
                case 8:
                    storyLabel.Text = "you jump out and die do to the fall";
                    button1.Text = "end pag";
                    button2.Text = "end pag";
                    break;
                case 99:
                    storyLabel.Text = "your died";
                    button1.Text = "start agen";
                    button2.Text = "end of game";
                    break;
                case 100:
                    storyLabel.Text = "you wane";
                    button1.Text = "start agen";
                    button2.Text = "end of game";
                    break;
                case 101:
                    storyLabel.Text = "you are starting agen";
                    button1.Text = "go to start";
                    button2.Text = "go to start";
                    break;
                case 102:
                    storyLabel.Text = "you leving ok go bey";
                    button1.Text = "end game";
                    button2.Text = "end game";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 99;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                // 99 or 100
                page = 100;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 99)
            {
                page = 102;
            }
            else if (page == 100)
            {
                page = 102;
            }
            else if (page == 101)
            {
                page = 1;
            }
            else if (page == 102)
            {
                page = 900;
            }
            else if (page == 900)
            {
                storyLabel.Text = ":)";
            }

            switch (page)
            {
                case 1:
                    storyLabel.Text = "you have tow doors door one you don't now were it gos and door tow leds to a bathroom";
                    button1.Text = "door one";
                    button2.Text = "door two";
                    break;
                case 2:
                    storyLabel.Text = "go to the end page";
                    button1.Text = "end page";
                    button2.Text = "end page";
                    break;
                case 3:
                    storyLabel.Text = "do you stay in the bathroom or leave";
                    button1.Text = "stay";
                    button2.Text = "leave";
                    break;
                case 4:
                    storyLabel.Text = "there is a wendow do you jump out or stay in the bathroom";
                    button1.Text = "jump";
                    button2.Text = "stay";
                    break;
                case 5:
                    storyLabel.Text = "go to the end page";
                    button1.Text = "end page";
                    button2.Text = "end page";
                    break;
                case 6:
                    storyLabel.Text = "you jump out";
                    button1.Text = "end page";
                    button2.Text = "and pag";
                    break;
                case 7:
                    storyLabel.Text = "you stay and get killed";
                    button1.Text = "end page";
                    button2.Text = "end pag";
                    break;
                case 8:
                    storyLabel.Text = "you jump out and die do to the fall";
                    button1.Text = "end pag";
                    button2.Text = "end pag";
                    break;
                case 99:
                    storyLabel.Text = "your died";
                    button1.Text = "start agen";
                    button2.Text = "end of game";
                    break;
                case 100:
                    storyLabel.Text = "you wane";
                    button1.Text = "start agen";
                    button2.Text = "end of game";
                    break;
                case 101:
                    storyLabel.Text = "you are starting agen";
                    button1.Text = "go to start";
                    button2.Text = "go to start";
                    break;
                case 102:
                    storyLabel.Text = "you leving ok go bey";
                    button1.Text = "end game";
                    button2.Text = "end game";
                    break;
            }
        }
     
    }
}
