namespace HappyPetGame_160422035_160422041
{
    partial class HappyPetGame
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
            this.components = new System.ComponentModel.Container();
            this.panelActivity = new System.Windows.Forms.Panel();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.buttonVaccinate = new System.Windows.Forms.Button();
            this.buttonBath = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.game = new System.Windows.Forms.Timer(this.components);
            this.indikator = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTambahan = new System.Windows.Forms.Label();
            this.labelHappiness = new System.Windows.Forms.Label();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.labelMyPet = new System.Windows.Forms.Label();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelCoin = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.pictureBoxPet = new System.Windows.Forms.PictureBox();
            this.panelActivity.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActivity
            // 
            this.panelActivity.BackColor = System.Drawing.Color.Transparent;
            this.panelActivity.Controls.Add(this.buttonSleep);
            this.panelActivity.Controls.Add(this.buttonVaccinate);
            this.panelActivity.Controls.Add(this.buttonBath);
            this.panelActivity.Controls.Add(this.buttonClean);
            this.panelActivity.Controls.Add(this.buttonPlay);
            this.panelActivity.Controls.Add(this.buttonFeed);
            this.panelActivity.Location = new System.Drawing.Point(32, 423);
            this.panelActivity.Margin = new System.Windows.Forms.Padding(2);
            this.panelActivity.Name = "panelActivity";
            this.panelActivity.Size = new System.Drawing.Size(896, 92);
            this.panelActivity.TabIndex = 4;
            // 
            // buttonSleep
            // 
            this.buttonSleep.BackColor = System.Drawing.Color.Yellow;
            this.buttonSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSleep.Location = new System.Drawing.Point(781, 33);
            this.buttonSleep.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(88, 27);
            this.buttonSleep.TabIndex = 5;
            this.buttonSleep.Text = "Sleep";
            this.buttonSleep.UseVisualStyleBackColor = false;
            this.buttonSleep.Click += new System.EventHandler(this.buttonSleep_Click);
            // 
            // buttonVaccinate
            // 
            this.buttonVaccinate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonVaccinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVaccinate.Location = new System.Drawing.Point(476, 33);
            this.buttonVaccinate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVaccinate.Name = "buttonVaccinate";
            this.buttonVaccinate.Size = new System.Drawing.Size(88, 27);
            this.buttonVaccinate.TabIndex = 4;
            this.buttonVaccinate.Text = "Vaccinate";
            this.buttonVaccinate.UseVisualStyleBackColor = false;
            this.buttonVaccinate.Click += new System.EventHandler(this.buttonVaccinate_Click);
            // 
            // buttonBath
            // 
            this.buttonBath.BackColor = System.Drawing.Color.Cyan;
            this.buttonBath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBath.Location = new System.Drawing.Point(326, 33);
            this.buttonBath.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBath.Name = "buttonBath";
            this.buttonBath.Size = new System.Drawing.Size(88, 27);
            this.buttonBath.TabIndex = 3;
            this.buttonBath.Text = "Bath";
            this.buttonBath.UseVisualStyleBackColor = false;
            this.buttonBath.Click += new System.EventHandler(this.buttonBath_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClean.Location = new System.Drawing.Point(634, 33);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(88, 27);
            this.buttonClean.TabIndex = 2;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(166, 33);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(88, 27);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonFeed
            // 
            this.buttonFeed.BackColor = System.Drawing.Color.Coral;
            this.buttonFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFeed.Location = new System.Drawing.Point(26, 33);
            this.buttonFeed.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(88, 27);
            this.buttonFeed.TabIndex = 0;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = false;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // game
            // 
            this.game.Enabled = true;
            this.game.Interval = 3000;
            this.game.Tick += new System.EventHandler(this.game_Tick);
            // 
            // indikator
            // 
            this.indikator.Enabled = true;
            this.indikator.Interval = 5000;
            this.indikator.Tick += new System.EventHandler(this.indikator_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.labelTambahan);
            this.panel1.Controls.Add(this.labelHappiness);
            this.panel1.Controls.Add(this.labelEnergy);
            this.panel1.Controls.Add(this.labelHealth);
            this.panel1.Controls.Add(this.labelMyPet);
            this.panel1.Location = new System.Drawing.Point(265, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 114);
            this.panel1.TabIndex = 6;
            // 
            // labelTambahan
            // 
            this.labelTambahan.AutoSize = true;
            this.labelTambahan.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTambahan.Location = new System.Drawing.Point(123, 86);
            this.labelTambahan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTambahan.Name = "labelTambahan";
            this.labelTambahan.Size = new System.Drawing.Size(0, 13);
            this.labelTambahan.TabIndex = 4;
            // 
            // labelHappiness
            // 
            this.labelHappiness.AutoSize = true;
            this.labelHappiness.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHappiness.Location = new System.Drawing.Point(320, 44);
            this.labelHappiness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHappiness.Name = "labelHappiness";
            this.labelHappiness.Size = new System.Drawing.Size(135, 13);
            this.labelHappiness.TabIndex = 3;
            this.labelHappiness.Text = "Happiness: ";
            // 
            // labelEnergy
            // 
            this.labelEnergy.AutoSize = true;
            this.labelEnergy.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnergy.Location = new System.Drawing.Point(168, 44);
            this.labelEnergy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnergy.Name = "labelEnergy";
            this.labelEnergy.Size = new System.Drawing.Size(95, 13);
            this.labelEnergy.TabIndex = 2;
            this.labelEnergy.Text = "Energy: ";
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealth.Location = new System.Drawing.Point(13, 44);
            this.labelHealth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(94, 13);
            this.labelHealth.TabIndex = 1;
            this.labelHealth.Text = "Health: ";
            // 
            // labelMyPet
            // 
            this.labelMyPet.AutoSize = true;
            this.labelMyPet.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyPet.Location = new System.Drawing.Point(212, 7);
            this.labelMyPet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyPet.Name = "labelMyPet";
            this.labelMyPet.Size = new System.Drawing.Size(79, 13);
            this.labelMyPet.TabIndex = 0;
            this.labelMyPet.Text = "label1";
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Font = new System.Drawing.Font("Dogica Pixel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerName.Location = new System.Drawing.Point(33, 15);
            this.labelPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(95, 16);
            this.labelPlayerName.TabIndex = 7;
            this.labelPlayerName.Text = "label1";
            // 
            // labelCoin
            // 
            this.labelCoin.AutoSize = true;
            this.labelCoin.Font = new System.Drawing.Font("Dogica Pixel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoin.Location = new System.Drawing.Point(33, 51);
            this.labelCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCoin.Name = "labelCoin";
            this.labelCoin.Size = new System.Drawing.Size(99, 16);
            this.labelCoin.TabIndex = 8;
            this.labelCoin.Text = "Coins: ";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Dogica Pixel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(355, 134);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(76, 19);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "Date";
            // 
            // pictureBoxPet
            // 
            this.pictureBoxPet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPet.Location = new System.Drawing.Point(376, 155);
            this.pictureBoxPet.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPet.Name = "pictureBoxPet";
            this.pictureBoxPet.Size = new System.Drawing.Size(150, 162);
            this.pictureBoxPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPet.TabIndex = 5;
            this.pictureBoxPet.TabStop = false;
            // 
            // HappyPetGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 524);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCoin);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxPet);
            this.Controls.Add(this.panelActivity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "HappyPetGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyPetGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HappyPetGame_FormClosing);
            this.Load += new System.EventHandler(this.HappyPetGame_Load);
            this.panelActivity.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelActivity;
        private System.Windows.Forms.Button buttonSleep;
        private System.Windows.Forms.Button buttonVaccinate;
        private System.Windows.Forms.Button buttonBath;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonFeed;
        private System.Windows.Forms.PictureBox pictureBoxPet;
        private System.Windows.Forms.Timer game;
        private System.Windows.Forms.Timer indikator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMyPet;
        private System.Windows.Forms.Label labelHappiness;
        private System.Windows.Forms.Label labelEnergy;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelCoin;
        private System.Windows.Forms.Label labelTambahan;
        private System.Windows.Forms.Label labelDate;
    }
}