using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WinProj_0719_guass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SysNum;
            int guess =-1;
            bool flag = false;
            SysNum = new Random().Next(1, 101);
            for (int i = 1; i <= 3; i++) 
            {
                guess = Convert.ToInt32(Interaction.InputBox("Input a number", "Guess", "50", 0, 0));
                if (guess > SysNum) 
                {
                    MessageBox.Show("Lower");
                }
                else if (guess < SysNum)
                {
                    MessageBox.Show("Higher");
                }
                else 
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                MessageBox.Show("Bingo: " + guess);
            else
                MessageBox.Show("Wrong Number: " + guess);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int SysNum;
            int guess = -1;
            SysNum = new Random().Next(1, 101);
            do 
            {
                guess = Convert.ToInt32(Interaction.InputBox("Input a number", "Guess", "50", 0, 0));
                if (guess > SysNum)
                {
                    MessageBox.Show("Lower");
                }
                else if (guess < SysNum)
                {
                    MessageBox.Show("Higher");
                }
                else
                { 
                    break;
                }
            } while (true);
            MessageBox.Show("Bingo: " + guess);
        }
    }
}
