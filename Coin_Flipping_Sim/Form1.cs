using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Flipping_Sim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbtnPickHeads_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string username = txtUsername.Text;


            if (!string.IsNullOrEmpty(username))
            {
                lblAsktoPlay.Text = "Hello " + username + ", \n do you want to flip a coin?";

            }
            else
            {
                lblAsktoPlay.Text = "Please Enter User Name";
            }
        }

        private void lblAsktoPlay_Click(object sender, EventArgs e)
        {

        }

        private void rdbtnPlayGameYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnPlayGameYes.Checked)
            {
                pnlGame.Visible = true;
                pnlGameResults.Visible = true;

            }
            else
            {
                pnlGame.Visible = false;
                pnlGameResults.Visible = false;
            }
        }

        private void rdbtnPlayGameNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnPlayGameNo.Checked)
            {
                pnlNoToGame.Visible = true;
            }
            else
            {
                pnlNoToGame.Visible = false;
            }
        }
        int intNumberOfTurns = 10;

        private void button2_Click(object sender, EventArgs e)
        {
            if (intNumberOfTurns <= 10 && intNumberOfTurns > 1)
            {
                intNumberOfTurns--;
                lblTurnsLeft.Text = intNumberOfTurns.ToString();



                int rndmResult;

                Random rndResultCalc = new Random();

                rndmResult = rndResultCalc.Next(2);

                if (rndmResult == 0)
                {
                    lblResult.Text = "Heads";
                }
                else if (rndmResult == 1)
                {
                    lblResult.Text = "Tails";
                }

                int intPoints = 0;



                if (rdbtnPickHead.Checked && rndmResult == 0)
                {

                     intPoints++;                  


                }
                else if (rdbtnPickTails.Checked && rndmResult == 1)
                {
                     intPoints++;
                  

                }
                lblPoints.Text = intPoints.ToString();
            }

            else
            {
                lblTurnsLeft.Text = "You Have No Turns Left";
                lblResult.Text = "Please Restart Game";
            }





        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}