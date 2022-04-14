using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Durak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Storing bacgkround image in myBackGroundImage variable
            Image myBackGroundImage = Image.FromFile("MenuBackground.jpeg");
            // Setting the background image using the variable created
            BackgroundImage = myBackGroundImage;
        }

        private void btnSubmitName_Click(object sender, EventArgs e)
        {
            if(txtPlayerName.Text != "")
            {
                string name = txtPlayerName.Text;
                Player player1 = new Player(name);

                Form GameForm = new GameForm(player1);
                this.Visible = false;
                GameForm.Show();
            }
            else
            {
               MessageBox.Show("Please Enter Name");
            }
            
        }

        private void btnUserGuide_Click(object sender, EventArgs e)
        {
            MessageBox.Show("================  USER GUIDE TO DURAK  ============== " +
                "This is our guide for our program for the card game Durak. " +
                "Durak is a Russian card game and the goal of the game is to " +
                "get rid of all of your cards before your opponent.The player " +
                "that is left with no cards is the winner and the other is the " +
                "Durak or 'fool' in english terms. Currently our game is played " +
                "between the user and an AI player. After clicking start you and " +
                "your opponent will be dealt a hand of six cards.The size of the " +
                "deck is thirty six cards and this is the deck that will be drawn " +
                "from when players shed a card. Trump cards will become visible to " +
                "the user and AI player that determine which suit types trump all " +
                "other base suits. The player that begins the attack will be determined " +
                "by the player will the lowest trump card value. After each round, players " +
                "will draw from the deck till they reach their six card limit until " +
                "the thirty six card deck is exhausted. To play a card you can click to " +
                "select your desired card. When you are attacking you can start by playing " +
                "any card in your deck, the computer will defend with any card of the same " +
                "suit and higher value or with a trump card. A trump card is displayed in " +
                "the game form and determines what suit beats all other suits meaning you can " +
                "play it on any suit. After the computer succesfuly defends you can counter " +
                "with a card of the same rank/value or with a trump card. This will continue " +
                "until one player can't play anymore, cease's their attack or pick's up the cards. " +
                "Ceasing your attack will end the play and give the attack over to the opposition " +
                "while taking a card will pick up the cards from the play deck. You will continue " +
                "to attack and defend until all thirty six cards have been dealt and then the first " +
                "player left with no cards is the winner and will be annouced at the end of the game."); 
        }
    }
}
