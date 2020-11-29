using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scary_Maze_Game
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            StarGame();
        }

        private void reset()
        {
            button1.Enabled = true;
            player.Stop();
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Enabled = false;
                    x.BackColor = System.Drawing.Color.Black;
                }
            }
        }

        private void StarGame()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Enabled = true;
                    x.BackColor = System.Drawing.Color.SkyBlue;
                }
            }
            // play the back ground music when it starts
            player.Stream = Properties.Resources.bg_music;
            player.PlayLooping();
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            Scare fullScreen = new Scare();
            fullScreen.Show();
        }
    }
}
