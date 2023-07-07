namespace HappyPetGame_160422035_160422041
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelCoin = new System.Windows.Forms.Label();
            this.labelPlayerUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCoin = new System.Windows.Forms.TextBox();
            this.buttonUpdateCoin = new System.Windows.Forms.Button();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCoin
            // 
            this.labelCoin.AutoSize = true;
            this.labelCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.labelCoin.ForeColor = System.Drawing.Color.White;
            this.labelCoin.Location = new System.Drawing.Point(133, 62);
            this.labelCoin.Name = "labelCoin";
            this.labelCoin.Size = new System.Drawing.Size(44, 16);
            this.labelCoin.TabIndex = 0;
            this.labelCoin.Text = "label1";
            // 
            // labelPlayerUsername
            // 
            this.labelPlayerUsername.AutoSize = true;
            this.labelPlayerUsername.Location = new System.Drawing.Point(345, 91);
            this.labelPlayerUsername.Name = "labelPlayerUsername";
            this.labelPlayerUsername.Size = new System.Drawing.Size(44, 16);
            this.labelPlayerUsername.TabIndex = 1;
            this.labelPlayerUsername.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coin: ";
            // 
            // textBoxCoin
            // 
            this.textBoxCoin.Location = new System.Drawing.Point(313, 175);
            this.textBoxCoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCoin.Name = "textBoxCoin";
            this.textBoxCoin.Size = new System.Drawing.Size(100, 22);
            this.textBoxCoin.TabIndex = 3;
            // 
            // buttonUpdateCoin
            // 
            this.buttonUpdateCoin.Location = new System.Drawing.Point(325, 214);
            this.buttonUpdateCoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateCoin.Name = "buttonUpdateCoin";
            this.buttonUpdateCoin.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateCoin.TabIndex = 4;
            this.buttonUpdateCoin.Text = "Update Coin";
            this.buttonUpdateCoin.UseVisualStyleBackColor = true;
            this.buttonUpdateCoin.Click += new System.EventHandler(this.buttonUpdateCoin_Click);
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(313, 295);
            this.buttonSignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(88, 27);
            this.buttonSignOut.TabIndex = 5;
            this.buttonSignOut.Text = "SignOut";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSignOut);
            this.Controls.Add(this.buttonUpdateCoin);
            this.Controls.Add(this.textBoxCoin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPlayerUsername);
            this.Controls.Add(this.labelCoin);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCoin;
        private System.Windows.Forms.Label labelPlayerUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCoin;
        private System.Windows.Forms.Button buttonUpdateCoin;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

