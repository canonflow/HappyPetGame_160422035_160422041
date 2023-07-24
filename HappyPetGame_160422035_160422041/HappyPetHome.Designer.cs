namespace HappyPetGame_160422035_160422041
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
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.BackgroundImage = global::HappyPetGame_160422035_160422041.Properties.Resources.play_game_hpg;
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Location = new System.Drawing.Point(223, 141);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(160, 35);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonResetGame
            // 
            this.buttonResetGame.BackColor = System.Drawing.Color.Transparent;
            this.buttonResetGame.BackgroundImage = global::HappyPetGame_160422035_160422041.Properties.Resources.reset_game_hpg;
            this.buttonResetGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetGame.FlatAppearance.BorderSize = 0;
            this.buttonResetGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonResetGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetGame.Location = new System.Drawing.Point(223, 328);
            this.buttonResetGame.Margin = new System.Windows.Forms.Padding(2);
            this.buttonResetGame.Name = "buttonResetGame";
            this.buttonResetGame.Size = new System.Drawing.Size(129, 27);
            this.buttonResetGame.TabIndex = 1;
            this.buttonResetGame.UseVisualStyleBackColor = false;
            this.buttonResetGame.Click += new System.EventHandler(this.buttonResetGame_Click);
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTitle.Image = global::HappyPetGame_160422035_160422041.Properties.Resources.happy_pet_title;
            this.pictureBoxTitle.Location = new System.Drawing.Point(163, 12);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(297, 51);
            this.pictureBoxTitle.TabIndex = 2;
            this.pictureBoxTitle.TabStop = false;
            // 
            // HappyPetHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyPetGame_160422035_160422041.Properties.Resources.hp_home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBoxTitle);
            this.Controls.Add(this.buttonResetGame);
            this.Controls.Add(this.buttonPlay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "HappyPetHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Happy Pet Home";
            this.Load += new System.EventHandler(this.HappyPetHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonResetGame;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
    }
}