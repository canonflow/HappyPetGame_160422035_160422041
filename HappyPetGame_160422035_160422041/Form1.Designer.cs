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
            this.SuspendLayout();
            // 
            // labelPlayerUsername
            // 
            this.labelPlayerUsername.AutoSize = true;
            this.labelPlayerUsername.Location = new System.Drawing.Point(329, 36);
            this.labelPlayerUsername.Name = "labelPlayerUsername";
            this.labelPlayerUsername.Size = new System.Drawing.Size(44, 16);
            this.labelPlayerUsername.TabIndex = 0;
            this.labelPlayerUsername.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPlayerUsername);
            this.Name = "Form1";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayerUsername;
    }
}

