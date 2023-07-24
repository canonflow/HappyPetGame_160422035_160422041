namespace HappyPetGame_160422035_160422041
{
    partial class FormToyShop
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
            this.pictureBoxYarnToy = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlueMarble = new System.Windows.Forms.PictureBox();
            this.pictureBoxBone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYarnToy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlueMarble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBone)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxYarnToy
            // 
            this.pictureBoxYarnToy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxYarnToy.Image = global::HappyPetGame_160422035_160422041.Properties.Resources.Yarn_Toy_1;
            this.pictureBoxYarnToy.Location = new System.Drawing.Point(639, 153);
            this.pictureBoxYarnToy.Name = "pictureBoxYarnToy";
            this.pictureBoxYarnToy.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxYarnToy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxYarnToy.TabIndex = 2;
            this.pictureBoxYarnToy.TabStop = false;
            // 
            // pictureBoxBlueMarble
            // 
            this.pictureBoxBlueMarble.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBlueMarble.Image = global::HappyPetGame_160422035_160422041.Properties.Resources.Blue_Marble_Toy_1;
            this.pictureBoxBlueMarble.Location = new System.Drawing.Point(373, 153);
            this.pictureBoxBlueMarble.Name = "pictureBoxBlueMarble";
            this.pictureBoxBlueMarble.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxBlueMarble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBlueMarble.TabIndex = 1;
            this.pictureBoxBlueMarble.TabStop = false;
            // 
            // pictureBoxBone
            // 
            this.pictureBoxBone.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBone.Image = global::HappyPetGame_160422035_160422041.Properties.Resources.Bone_Toy;
            this.pictureBoxBone.Location = new System.Drawing.Point(78, 153);
            this.pictureBoxBone.Name = "pictureBoxBone";
            this.pictureBoxBone.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxBone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBone.TabIndex = 0;
            this.pictureBoxBone.TabStop = false;
            // 
            // FormToyShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 591);
            this.Controls.Add(this.pictureBoxYarnToy);
            this.Controls.Add(this.pictureBoxBlueMarble);
            this.Controls.Add(this.pictureBoxBone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormToyShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toy Shop";
            this.Load += new System.EventHandler(this.FormToyShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYarnToy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlueMarble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBone;
        private System.Windows.Forms.PictureBox pictureBoxBlueMarble;
        private System.Windows.Forms.PictureBox pictureBoxYarnToy;
    }
}