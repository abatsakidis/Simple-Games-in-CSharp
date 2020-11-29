using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whack_a_Mole
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int locationNum = 0;
        int score = 0;
        int misses = 0;
        bool isHit = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHit.Text = "Hit: " + score;
            lblMiss.Text = "Miss: " + misses;
            if (isHit == false)
            {
                misses++;
            }
            if (score > 15)
            {
                timer1.Stop();
                Mole.Enabled = false;
                MessageBox.Show("You Win");
            }
            else if (misses > 10)
            {
                timer1.Stop();
                Mole.Enabled = false;
                MessageBox.Show("You Lose");
            }
            moveMole();
        }

        private void moveMole()
        {

            isHit = false;
            Mole.Enabled = true;
            Mole.Image = Properties.Resources.alive;
            Mole.BackColor = System.Drawing.Color.Transparent;
            locationNum = rnd.Next(1, 7);
            switch (locationNum)
            {
                case 1:
                    Mole.Left = 434;
                    Mole.Top = 249;
                    break;
                case 2:
                    Mole.Left = 257;
                    Mole.Top = 211;
                    break;
                case 3:
                    Mole.Left = 58;
                    Mole.Top = 240;
                    break;
                case 4:
                    Mole.Left = 85;
                    Mole.Top = 318;
                    break;
                case 5:
                    Mole.Left = 254;
                    Mole.Top = 364;
                    break;
                case 6:
                    Mole.Left = 416;
                    Mole.Top = 323;
                    break;
                default:
                    break;
            }
        }

        private void Mole_Click(object sender, EventArgs e)
        {
            score++;
            Mole.Image = Properties.Resources.dead;
            isHit = true;
            Mole.Enabled = false;
        }
    }
}
