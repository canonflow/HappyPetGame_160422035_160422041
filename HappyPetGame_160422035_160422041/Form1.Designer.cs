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
            this.labelPlayerUsername = new System.Windows.Forms.Label();
            this.labelCoin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCoin = new System.Windows.Forms.TextBox();
            this.buttonUpdateCoin = new System.Windows.Forms.Button();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlayerUsername
            // 
            this.labelPlayerUsername.AutoSize = true;
            this.labelPlayerUsername.Location = new System.Drawing.Point(345, 39);
            this.labelPlayerUsername.Name = "labelPlayerUsername";
            this.labelPlayerUsername.Size = new System.Drawing.Size(44, 16);
            this.labelPlayerUsername.TabIndex = 0;
            this.labelPlayerUsername.Text = "label1";
            // 
            // labelCoin
            // 
            this.labelCoin.AutoSize = true;
            this.labelCoin.Location = new System.Drawing.Point(345, 91);
            this.labelCoin.Name = "labelCoin";
            this.labelCoin.Size = new System.Drawing.Size(44, 16);
            this.labelCoin.TabIndex = 1;
            this.labelCoin.Text = "label1";
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
            this.textBoxCoin.Name = "textBoxCoin";
            this.textBoxCoin.Size = new System.Drawing.Size(100, 22);
            this.textBoxCoin.TabIndex = 3;
            // 
            // buttonUpdateCoin
            // 
            this.buttonUpdateCoin.Location = new System.Drawing.Point(325, 214);
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
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(88, 27);
            this.buttonSignOut.TabIndex = 5;
            this.buttonSignOut.Text = "SignOut";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
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
            this.Controls.Add(this.labelCoin);
            this.Controls.Add(this.labelPlayerUsername);
            this.Name = "Form1";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayerUsername;
        private System.Windows.Forms.Label labelCoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCoin;
        private System.Windows.Forms.Button buttonUpdateCoin;
        private System.Windows.Forms.Button buttonSignOut;
    }
}

