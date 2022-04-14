
namespace Durak
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.btnSubmitName = new System.Windows.Forms.Button();
            this.lblNamePrompt = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnUserGuide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMainTitle.Location = new System.Drawing.Point(133, 9);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(504, 48);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Welcome To The Game of Durak";
            // 
            // btnSubmitName
            // 
            this.btnSubmitName.Location = new System.Drawing.Point(346, 245);
            this.btnSubmitName.Name = "btnSubmitName";
            this.btnSubmitName.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitName.TabIndex = 1;
            this.btnSubmitName.Text = "Play";
            this.btnSubmitName.UseVisualStyleBackColor = true;
            this.btnSubmitName.Click += new System.EventHandler(this.btnSubmitName_Click);
            // 
            // lblNamePrompt
            // 
            this.lblNamePrompt.AutoSize = true;
            this.lblNamePrompt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNamePrompt.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNamePrompt.Location = new System.Drawing.Point(80, 146);
            this.lblNamePrompt.Name = "lblNamePrompt";
            this.lblNamePrompt.Size = new System.Drawing.Size(256, 27);
            this.lblNamePrompt.TabIndex = 2;
            this.lblNamePrompt.Text = "Please Enter Your Player Name:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(398, 149);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(194, 23);
            this.txtPlayerName.TabIndex = 3;
            // 
            // btnUserGuide
            // 
            this.btnUserGuide.Location = new System.Drawing.Point(346, 294);
            this.btnUserGuide.Name = "btnUserGuide";
            this.btnUserGuide.Size = new System.Drawing.Size(75, 23);
            this.btnUserGuide.TabIndex = 4;
            this.btnUserGuide.Text = "User Guide";
            this.btnUserGuide.UseVisualStyleBackColor = true;
            this.btnUserGuide.Click += new System.EventHandler(this.btnUserGuide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserGuide);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblNamePrompt);
            this.Controls.Add(this.btnSubmitName);
            this.Controls.Add(this.lblMainTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Button btnSubmitName;
        private System.Windows.Forms.Label lblNamePrompt;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnUserGuide;
    }
}

