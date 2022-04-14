using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Durak
{
    public partial class GameForm : Form
    {
        //Declaring a public Player object so it can be accsessed anywhere in this logic
        public Player player1;
        public Player comm = new Player("Computer");
        public Card playedCard = null;
        public Card TrumpCard;
        public Deck playDeck = new Deck();

        public Deck inPlay = new Deck(1);
        //creating public boolean for turns (NOTE THIS WILL NEED TO UPDATED TO ACCOUNT FOR ATTACKING AND DEFENDING)

        //List of Picture boxes for player card hotbar
        List<PictureBox> pictures = new List<PictureBox>();

        // List of Picture boxes for comm player card hotbar
        List<PictureBox> Commpictures = new List<PictureBox>();

        public const string imagePath = @"Cards/";
        //form constructor that is passed the player obect from the previous form
        public GameForm(Player player)
        {
            InitializeComponent();
            player1 = player;
            lblPlayerHand.Text = player1.theName + "'s Current Hand";
            PrintTurn();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            GameStart();
            // Storing bacgkround image in myBackGroundImage variable
            Image myBackGroundImage = Image.FromFile("GreenFelt.jpg");
            // Setting the background image using the variable created
            BackgroundImage = myBackGroundImage;
        }
        //on game start


        private void GameStart()
        {
            //shuffle before dealing
            playDeck.shuffleDeck();

            //dealing cards to the player and comm
            playDeck.DealHands(player1, comm);

            //getting trump card and displaying it
            TrumpCard = playDeck.drawCard();

            string pic = TrumpCard.cardFormat();
            picTrumpCard.Image = Image.FromFile(@"Cards/" + pic + "");
            picTrumpCard.SizeMode = PictureBoxSizeMode.StretchImage;


            //setting is atk and def
            player1.isAttacking = true;
            comm.isDefending = true;

            //calling funciton to print players hand
            DisplayCardsInPlay();

            CreatePlayer1Controls();
            DisplayPlayer1Controls();

            CreateCommControls();
            DisplayCommControls();

        }


        //prints the card player selected
        void PrintPlayCard(Card Todisplay)
        {
            inPlay.addCard(Todisplay);
            
            if(playedCard != null)
            {
                
                string oldCard = playedCard.cardFormat();
                piclastPlayed.Image = Image.FromFile(@"Cards/" + oldCard + "");
                piclastPlayed.SizeMode = PictureBoxSizeMode.StretchImage;

            }
         
            playedCard = Todisplay;
            string pic = Todisplay.cardFormat();
            picPlayedCard.Image = Image.FromFile(@"Cards/" + pic + "");
            picPlayedCard.SizeMode = PictureBoxSizeMode.StretchImage;

            DisplayCardsInPlay();
        }
        
        //when the computer has to play
        void commPlay()
        {
            int move = comm.commMove(TrumpCard, playedCard, inPlay);
            if(move == 99)
            {
                if (comm.isAttacking)
                {
                    MessageBox.Show("Computer Ceases Attack");
                    if (playDeck.theDeck.Count < 12)
                    {
                        int deal = playDeck.theDeck.Count / 2;
                        if(deal != 0)
                        {
                            player1 = playDeck.takeCards(player1, deal);
                            comm = playDeck.takeCards(comm, deal);
                        }
                    }
                    else
                    {
                        player1 = playDeck.takeCards(player1, 6);
                        comm = playDeck.takeCards(comm, 6);
                    }
                  

                    player1.isAttacking = true;
                    player1.isDefending = false;
                    comm.isDefending = true;
                    comm.isAttacking = false;

                    inPlay = new Deck(1);
                    PrintTurn();
                    CreatePlayer1Controls();
                    DisplayPlayer1Controls();
                    // Display AI card picture box controls
                    CreateCommControls();
                    DisplayCommControls();
                }
                else
                {
                    MessageBox.Show("Computer Picks Up Cards in Play");
                    int inDeck = inPlay.theDeck.Count;
                    for (int i = 0; i < inDeck; i++)
                    {
                        comm.addCard(inPlay.drawCard());
                    }
                    inPlay = new Deck(1);
                    player1.isDefending = true;
                    player1.isAttacking = false;
                    comm.isAttacking = true;
                    comm.isDefending = false;
                    PrintTurn();
                    commPlay();
                }
                DisplayCardsInPlay();
            }
            else
            {
                Card toPlay = comm.playCard(move);
                if (comm.isDefending)
                {
                    handAssesment(toPlay);
                }
                PrintPlayCard(toPlay);
                if (comm.noCards())
                {
                    Form GameOver = new GameOver(player1, false);
                    this.Visible = false;
                    GameOver.Show();
                }
            }   
        }

        //when the player loses a hand
        void playerLoseHand()
        {
            int inDeck = inPlay.theDeck.Count;
            for (int i = 0; i < inDeck; i++)
            {
                player1.addCard(inPlay.drawCard());
            }
            inPlay = new Deck(1);
            player1.isDefending = false;
            player1.isAttacking = true;
            comm.isAttacking = false;
            comm.isDefending = true;
            CreatePlayer1Controls();
            DisplayPlayer1Controls();
            PrintTurn();
        }
        //when comm loses hand
        void commLoseHand()
        {
            int inDeck = inPlay.theDeck.Count;
            for (int i = 0; i < inDeck; i++)
            {
                comm.addCard(inPlay.drawCard());
            }
            inPlay = new Deck(1);
            player1.isDefending = true;
            player1.isAttacking = false;
            comm.isAttacking = true;
            comm.isDefending = false;
            PrintTurn();
            commPlay();
        }
        //this function get run after every defence to see if the hand has been won
        void handAssesment(Card tobePlayed)
        {
            int test = 0;
            int trump = TrumpCard.Suit;
            if (player1.isDefending)
            {
                if(tobePlayed.Suit != trump && playedCard.Suit == trump)
                {
                    playerLoseHand();
                    test++;
                }
                if (tobePlayed.Suit == trump && playedCard.Suit == trump)
                {
             
                    if (tobePlayed.Value < playedCard.Value)
                    {
                        playerLoseHand();
                        test++;
                    }
                }
                else if (tobePlayed.Suit != trump && playedCard.Suit != trump)
                {
               
                    if (tobePlayed.Value < playedCard.Value)
                    {
                        playerLoseHand();
                        test++;
                    }
                }
            }
            if(test == 0)
            {
                if (comm.isDefending)
                {
                    if (tobePlayed.Suit != trump && playedCard.Suit == trump)
                    {
    
                        commLoseHand();
                        test++;
                    }
                    if (tobePlayed.Suit == trump && playedCard.Suit == trump)
                    {

                        if (tobePlayed.Value < playedCard.Value)
                        {
                            commLoseHand();
                            test++;
                        }
                    }
                    else if (tobePlayed.Suit != trump && playedCard.Suit != trump)
                    {

                        if (tobePlayed.Value < playedCard.Value)
                        {
                            commLoseHand();
                            test++;
                        }
                    }
                }
            }
            else
            {
                test = 0;
            }
           

        }
        //prints the current turn to the turn label
        void PrintTurn()
        {
            if(player1.isAttacking == true)
            {
                lblTurnlbl.Text = "Player " + player1.theName + "'s Attack";
            }
            if(player1.isDefending == true)
            {
                lblTurnlbl.Text = "Player " + player1.theName + "'s Defence";
            }
        }
    
        private void btnTake_Click(object sender, EventArgs e)
        {
            if (player1.isAttacking)
            {
                piclastPlayed.Image = null;
                picPlayedCard.Image = null;
;
                if (playDeck.theDeck.Count < 12)
                {
                    int deal = playDeck.theDeck.Count / 2;
                    if (deal != 0)
                    {
                        player1 = playDeck.takeCards(player1, deal);
                        comm = playDeck.takeCards(comm, deal);
                    }
                }
                else
                {
                    player1 = playDeck.takeCards(player1, 6);
                    comm = playDeck.takeCards(comm, 6);
                }

                player1.isAttacking = false;
                player1.isDefending = true;
                comm.isDefending = false;
                comm.isAttacking = true;

                inPlay = new Deck(1);
                PrintTurn();
                CreatePlayer1Controls();
                DisplayPlayer1Controls();
                // Display AI card picture box controls
                CreateCommControls();
                DisplayCommControls();
                commPlay();
            }
        }

        //to delete picture boxes on screen when we need to re index them
        void picDelete()
        {
            int x = pictures.Count;

            for (int i = 0; i < x; i++)
            {
                pictures[i].Dispose();

            }
        }

        //to delete picture boxes on screen when we need to re index them
        void picCommDelete()
        {
            int x = Commpictures.Count;

            for (int i = 0; i < x; i++)
            {
                Commpictures[i].Dispose();

            }
        }

        /// <summary>
        /// This function will create the picture box controls for player 1's hand based on the values within the 
        /// players hand. It also calls SizeImage function()
        /// </summary>
        private void CreatePlayer1Controls()
        {
            //if there are any pictures in pictures 
            if (pictures != null)
            {
                picDelete();
                pictures.Clear();
            }

            // Storing length of player 1 hand in handLength
            int handLength = player1.theHand.Count;
            // Declaring string Pic that will hold the value of player1.theHand[i].cardFormat();
            string pic;

            // For loop that iterates through until handLength limit is met
            for (int i = 0; i < handLength; i++)
            {
                // Setting pic to the value of cardFormat function on player 1's hand
                pic = player1.theHand[i].cardFormat();
                // Declaring new PictureBox object called newPictureBox
                var newPictureBox = new PictureBox();
                //adding name attribute to each box so they are distingishable from eachother
                newPictureBox.Name = "box" + i;
                // Setting the width and height of the picture box  
                newPictureBox.Width = 75;
                newPictureBox.Height = 100;
                //adding to list
                pictures.Add(SizeImage(newPictureBox, pic));
                //adding event handeler
                newPictureBox.Click += new EventHandler(NewBox_Click);
            }
        }
        //on click eveent for picture boxs
        private void NewBox_Click(object sender, EventArgs e)
        {

            PictureBox box = (PictureBox)sender;
            int index = player1.theHand.Count;


            for (int i = 0; i < index; i++)
            {
                //When pic box is selected
                if (box.Name == ("box" + i) || box.Name == ("Commbox" + i))
                {
                    if (player1.isDefending)
                    {
                        
                        if (searchInPlay(player1.theHand[i]))
                        {
                            Card play = player1.playCard(i);
                            handAssesment(play);
                            PrintPlayCard(play);
                            commPlay();
                        }
                       
                           
                    }
                    else
                    {
                        if (searchInPlay(player1.theHand[i]))
                        {
                            Card play = player1.playCard(i);
                            PrintPlayCard(play);
                            commPlay();
                        }

                    }
                    CreatePlayer1Controls();
                    DisplayPlayer1Controls();
                    // Display AI card picture box controls
                    CreateCommControls();
                    DisplayCommControls();

                    if (player1.noCards())
                    {
                        Form GameOver = new GameOver(player1, true);
                        this.Visible = false;
                        GameOver.Show();
                    }
                    break;
                }
            }

        }

        bool searchInPlay(Card testCard)
        {
            int x = inPlay.deckLength;
            bool test = false;
            if (player1.isDefending)
            {
                if (x < 2)
                {
                    if (testCard.Suit == TrumpCard.Suit && inPlay.theDeck[0].Suit != TrumpCard.Suit)
                    {
                        test = true;
                    }
                    else if (testCard.Suit != TrumpCard.Suit && inPlay.theDeck[0].Suit == TrumpCard.Suit)
                    {
                        test = false;
                    }
                    if (testCard.Suit == TrumpCard.Suit && inPlay.theDeck[0].Suit == TrumpCard.Suit)
                    {
                        if (testCard.Value > inPlay.theDeck[0].Value)
                        {
                            test = true;
                        }
                        else
                        {
                            test = false;
                        }
                    }
                    else if (testCard.Suit != TrumpCard.Suit && inPlay.theDeck[0].Suit != TrumpCard.Suit)
                    {
                        if (testCard.Suit == inPlay.theDeck[0].Suit)
                        {
                            if (testCard.Value >= inPlay.theDeck[0].Value)
                            {
                                test = true;
                            }
                            else
                            {
                                test = false;
                            }

                        }
                        else
                        {
                            test = false;
                        }
                    }

                }
                else
                {
                    for (int i = 0; i < x; i++)
                    {
                        if (inPlay.theDeck[i].Suit == TrumpCard.Suit && testCard.Suit == TrumpCard.Suit)
                        {
                            if (inPlay.theDeck[i].Value < testCard.Value)
                            {
                                return true;
                            }
                        }
                        if (inPlay.theDeck[i].Value <= testCard.Value && inPlay.theDeck[i].Suit == testCard.Suit)
                        {
                            return true;
                        }
                        if (inPlay.theDeck[i].Suit != TrumpCard.Suit && testCard.Suit == TrumpCard.Suit)
                        {
                            return true;
                        }

                    }
                }
            }
            else
            {
                if(inPlay.theDeck.Count < 2)
                {
                    return true;
                }
                else
                {
                    for (int i = 0; i < x; i++)
                    {
                        if (inPlay.theDeck[i].Value == testCard.Value)
                        {
                            return true;
                        }
                    }
                }
            }
            return test;
        }
        /// <summary>
        /// This function will set and Image object called img based on the player1.TheHand[i].cardFormat method
        /// that link the correct images from the cards folder based on player 1's hand
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="pic"></param>
        /// <returns> pb </returns>
        private PictureBox SizeImage(PictureBox pb, string pic)
        {
            Image img = Image.FromFile(imagePath + pic);
            pb.Image = img;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            return pb;
        }

        /// <summary>
        /// This function is used to display player 1's hand
        /// </summary>
        private void DisplayPlayer1Controls()
        {
            // Storing length of player 1 hand in handLength
            int handLength = player1.theHand.Count;

            // For loops that iterates until hand length int is hit
            for (int i = 0; i < handLength; i++)
            {
                pictures[i].Location = new Point(100, 500);
                pictures[i].Left = (i * 80) + 50;
                this.Controls.Add(pictures[i]);
            }
        }

        /// <summary>
        /// This function will create the picture box controls for Computer AI's hand based on the values within the 
        /// computers hand. It also calls SizeImage function()
        /// </summary>
        private void CreateCommControls()
        {
            //if there are any pictures in pictures 
            if (Commpictures != null)
            {
                picCommDelete();
                Commpictures.Clear();
            }

            // Storing length of player 1 hand in handLength
            int handCommLength = comm.theHand.Count;
            // Declaring string Pic that will hold the value of player1.theHand[i].cardFormat();
            string pic;

            // For loop that iterates through until handLength limit is met
            for (int i = 0; i < handCommLength; i++)
            {
                // Setting pic to the value of cardFormat function on player 1's hand
                pic = comm.theHand[i].cardFormat();
                // Declaring new PictureBox object called newPictureBox
                var newCommPictureBox = new PictureBox();
                //adding name attribute to each box so they are distingishable from eachother
                newCommPictureBox.Name = "commbox" + i;
                // Setting the width and height of the picture box  
                newCommPictureBox.Width = 75;
                newCommPictureBox.Height = 100;
                //adding to list
                Commpictures.Add(SizeCommImage(newCommPictureBox));
            }
        }


        /// <summary>
        /// This function will set and Image object called img based on the comm.TheHand[i].cardFormat method
        /// that link the correct images from the cards folder based on Computer AI's hand
        /// </summary>
        /// <param name="pb"></param>
        /// <returns> pb </returns>
        private PictureBox SizeCommImage(PictureBox pb)
        {
            Image img = Image.FromFile(imagePath + "red_back.png");
            pb.Image = img;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            return pb;
        }

        /// <summary>
        /// This function is used to display computer AI's hand
        /// </summary>
        private void DisplayCommControls()
        {
            // Storing length of player 1 hand in handLength
            int handCommLength = comm.theHand.Count;

            // For loops that iterates until hand length int is hit
            for (int i = 0; i < handCommLength; i++)
            {
                Commpictures[i].Location = new Point(100, 30);
                Commpictures[i].Left = (i * 60) + 50;
                this.Controls.Add(Commpictures[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (player1.isDefending)
            {
                piclastPlayed.Image = null;
                picPlayedCard.Image = null;
                playerLoseHand();

            }
        }

        private void DisplayCardsInPlay()
        {
            lblCardsLeft.Text = "Current Cards Left in Deck: " + playDeck.theDeck.Count.ToString();

            string inPlayString = "";
            inPlayString = inPlay.ToString();
            lblInPlay.Text = inPlayString;
        }

    }

}


