
namespace Durak
{
    partial class GameOver
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
            this.lblWinLose = new System.Windows.Forms.Label();
            this.pbGameOver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWinLose
            // 
            this.lblWinLose.AutoSize = true;
            this.lblWinLose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWinLose.Font = new System.Drawing.Font("SimSun", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWinLose.Location = new System.Drawing.Point(238, 138);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(125, 37);
            this.lblWinLose.TabIndex = 0;
            this.lblWinLose.Text = "label1";
            // 
            // pbGameOver
            // 
            this.pbGameOver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGameOver.Location = new System.Drawing.Point(0, 0);
            this.pbGameOver.Name = "pbGameOver";
            this.pbGameOver.Size = new System.Drawing.Size(800, 450);
            this.pbGameOver.TabIndex = 1;
            this.pbGameOver.TabStop = false;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbGameOver);
            this.Controls.Add(this.lblWinLose);
            this.Name = "GameOver";
            this.Text = "GameOver";
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.PictureBox pbGameOver;
    }
}