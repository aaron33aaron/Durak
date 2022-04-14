using System;
using System.Windows.Forms;
using Durak;

namespace CardBox
{
    /// <summary>
    /// A control to use in a Windows form application that displays a playing card
    /// </summary>
    public partial class CardBoxUserControl : UserControl
    {
        #region FIELDS AND PROPERTIES

        /// <summary>
        /// Card property: sets/gets the underlying card object
        /// </summary>
        private Card myCard;
        public Card Card
        {
            set
            {
                myCard = value;
                // SET PICTURE BOX IMAGE HERE
                //pbMyPictureBox.Image = myCard.
            }
            get { return myCard;  }
        }

        /// <summary>
        /// Suit Property: sets/gets the underlying Card Objects suit.
        /// </summary>
        public CardSuit Suit
        {
            set
            {
               Card.Suit = value;
            }
            get { return Card.Suit; }
        }

        /// <summary>
        /// Rank property: sets/gets the underlying Card Object's rank.
        /// </summary>
        /// 
        public cardRank Rank
        {
            set
            {
                Card.Rank = value;
            }
            get { return Card.Rank;  }
        }




        #endregion
        public CardBoxUserControl()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

    }
}
