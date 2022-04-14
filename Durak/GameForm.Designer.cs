
namespace Durak
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlayerHand = new System.Windows.Forms.Label();
            this.picTrumpCard = new System.Windows.Forms.PictureBox();
            this.lblTrumpCard = new System.Windows.Forms.Label();
            this.picPlayedCard = new System.Windows.Forms.PictureBox();
            this.lblCurrentCard = new System.Windows.Forms.Label();
            this.lblTurnlbl = new System.Windows.Forms.Label();
            this.btnTake = new System.Windows.Forms.Button();
            this.lblInPlay = new System.Windows.Forms.Label();
            this.piclastPlayed = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCardsLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTrumpCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayedCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclastPlayed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerHand
            // 
            this.lblPlayerHand.AutoSize = true;
            this.lblPlayerHand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerHand.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerHand.Location = new System.Drawing.Point(356, 387);
            this.lblPlayerHand.Name = "lblPlayerHand";
            this.lblPlayerHand.Size = new System.Drawing.Size(120, 27);
            this.lblPlayerHand.TabIndex = 0;
            this.lblPlayerHand.Text = "Current Hand";
            // 
            // picTrumpCard
            // 
            this.picTrumpCard.Location = new System.Drawing.Point(629, 191);
            this.picTrumpCard.Name = "picTrumpCard";
            this.picTrumpCard.Size = new System.Drawing.Size(99, 175);
            this.picTrumpCard.TabIndex = 1;
            this.picTrumpCard.TabStop = false;
            // 
            // lblTrumpCard
            // 
            this.lblTrumpCard.AutoSize = true;
            this.lblTrumpCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTrumpCard.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTrumpCard.Location = new System.Drawing.Point(629, 152);
            this.lblTrumpCard.Name = "lblTrumpCard";
            this.lblTrumpCard.Size = new System.Drawing.Size(106, 27);
            this.lblTrumpCard.TabIndex = 8;
            this.lblTrumpCard.Text = "Trump Card";
            // 
            // picPlayedCard
            // 
            this.picPlayedCard.Location = new System.Drawing.Point(426, 191);
            this.picPlayedCard.Name = "picPlayedCard";
            this.picPlayedCard.Size = new System.Drawing.Size(99, 175);
            this.picPlayedCard.TabIndex = 9;
            this.picPlayedCard.TabStop = false;
            // 
            // lblCurrentCard
            // 
            this.lblCurrentCard.AutoSize = true;
            this.lblCurrentCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentCard.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentCard.Location = new System.Drawing.Point(395, 152);
            this.lblCurrentCard.Name = "lblCurrentCard";
            this.lblCurrentCard.Size = new System.Drawing.Size(170, 27);
            this.lblCurrentCard.TabIndex = 10;
            this.lblCurrentCard.Text = "Current Card in Play";
            // 
            // lblTurnlbl
            // 
            this.lblTurnlbl.AutoSize = true;
            this.lblTurnlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTurnlbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTurnlbl.Location = new System.Drawing.Point(35, 152);
            this.lblTurnlbl.Name = "lblTurnlbl";
            this.lblTurnlbl.Size = new System.Drawing.Size(124, 27);
            this.lblTurnlbl.TabIndex = 11;
            this.lblTurnlbl.Text = "Players Attack";
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(742, 270);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(116, 23);
            this.btnTake.TabIndex = 13;
            this.btnTake.Text = "Cease Attack";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // lblInPlay
            // 
            this.lblInPlay.AutoSize = true;
            this.lblInPlay.Location = new System.Drawing.Point(35, 212);
            this.lblInPlay.Name = "lblInPlay";
            this.lblInPlay.Size = new System.Drawing.Size(69, 15);
            this.lblInPlay.TabIndex = 14;
            this.lblInPlay.Text = "CardsInPlay";
            // 
            // piclastPlayed
            // 
            this.piclastPlayed.Location = new System.Drawing.Point(299, 191);
            this.piclastPlayed.Name = "piclastPlayed";
            this.piclastPlayed.Size = new System.Drawing.Size(99, 175);
            this.piclastPlayed.TabIndex = 15;
            this.piclastPlayed.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Pick Up Cards";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCardsLeft
            // 
            this.lblCardsLeft.AutoSize = true;
            this.lblCardsLeft.Location = new System.Drawing.Point(35, 411);
            this.lblCardsLeft.Name = "lblCardsLeft";
            this.lblCardsLeft.Size = new System.Drawing.Size(108, 15);
            this.lblCardsLeft.TabIndex = 17;
            this.lblCardsLeft.Text = "Cards Left in Deck: ";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 649);
            this.Controls.Add(this.lblCardsLeft);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.piclastPlayed);
            this.Controls.Add(this.lblInPlay);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.lblTurnlbl);
            this.Controls.Add(this.lblCurrentCard);
            this.Controls.Add(this.picPlayedCard);
            this.Controls.Add(this.lblTrumpCard);
            this.Controls.Add(this.picTrumpCard);
            this.Controls.Add(this.lblPlayerHand);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTrumpCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayedCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclastPlayed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerHand;
        private System.Windows.Forms.PictureBox picTrumpCard;
        private System.Windows.Forms.Label lblTrumpCard;
        private System.Windows.Forms.PictureBox picPlayedCard;
        private System.Windows.Forms.Label lblCurrentCard;
        private System.Windows.Forms.Label lblTurnlbl;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Label lblInPlay;
        private System.Windows.Forms.PictureBox piclastPlayed;
        private System.Windows.Forms.PictureBox pcThirdPlayed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCardsLeft;
    }
}