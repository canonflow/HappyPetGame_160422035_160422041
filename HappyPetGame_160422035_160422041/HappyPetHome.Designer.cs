﻿namespace HappyPetGame_160422035_160422041
{
    partial class HappyPetHome
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonResetGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(254, 160);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(86, 30);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play Game";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonResetGame
            // 
            this.buttonResetGame.Location = new System.Drawing.Point(254, 246);
            this.buttonResetGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonResetGame.Name = "buttonResetGame";
            this.buttonResetGame.Size = new System.Drawing.Size(86, 27);
            this.buttonResetGame.TabIndex = 1;
            this.buttonResetGame.Text = "Reset Game";
            this.buttonResetGame.UseVisualStyleBackColor = true;
            this.buttonResetGame.Click += new System.EventHandler(this.buttonResetGame_Click);
            // 
            // HappyPetHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonResetGame);
            this.Controls.Add(this.buttonPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HappyPetHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Happy Pet Home";
            this.Load += new System.EventHandler(this.HappyPetHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonResetGame;
    }
}