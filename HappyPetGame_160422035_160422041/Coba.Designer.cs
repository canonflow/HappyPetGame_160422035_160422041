namespace HappyPetGame_160422035_160422041
{
    partial class Coba
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
            this.BackgroundMovement = new System.Windows.Forms.Timer(this.components);
            this.PlayerMovement = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BackgroundMovement
            // 
            this.BackgroundMovement.Enabled = true;
            this.BackgroundMovement.Interval = 1;
            this.BackgroundMovement.Tick += new System.EventHandler(this.BackgroundMovement_Tick);
            // 
            // PlayerMovement
            // 
            this.PlayerMovement.Enabled = true;
            this.PlayerMovement.Interval = 1;
            this.PlayerMovement.Tick += new System.EventHandler(this.PlayerMovement_Tick);
            // 
            // Coba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 495);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Coba";
            this.Text = "Coba";
            this.Load += new System.EventHandler(this.Coba_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Coba_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Coba_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer BackgroundMovement;
        private System.Windows.Forms.Timer PlayerMovement;
    }
}