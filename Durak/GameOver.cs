using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Durak
{
    public partial class GameOver : Form
    {
        public Player player1;
        public Boolean hasWon;
        public GameOver(Player player, Boolean won)
        {
            InitializeComponent();

            player1 = player;
            hasWon = won;
            setForm();

            // GIF Image sourced from https://bestanimations.com/Holidays/Fireworks/Fireworks.html royal free GIF
            pbGameOver.Image = Image.FromFile(@"GameOver/gameover.gif");
            pbGameOver.SizeMode = PictureBoxSizeMode.StretchImage;
            lblWinLose.BringToFront();
        }

        public void setForm()
        {
            if (hasWon)
            {
                lblWinLose.Text = player1.theName + " is the Winner!";
            }
            else
            {
                lblWinLose.Text = player1.theName + " is the DURAK!";
            }
            
        }
    }
}
