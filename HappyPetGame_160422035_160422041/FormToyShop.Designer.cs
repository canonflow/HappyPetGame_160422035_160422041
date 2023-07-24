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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToyShop));
            this.pictureBoxYarnToy = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlueMarble = new System.Windows.Forms.PictureBox();
            this.pictureBoxBone = new System.Windows.Forms.PictureBox();
            this.radioButtonBone = new System.Windows.Forms.RadioButton();
            this.radioButtonBlueMarble = new System.Windows.Forms.RadioButton();
            this.radioButtonYarn = new System.Windows.Forms.RadioButton();
            this.labelBone = new System.Windows.Forms.Label();
            this.labelBlueMarble = new System.Windows.Forms.Label();
            this.labelYarn = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYarnToy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlueMarble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBone)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxYarnToy
            // 
            this.pictureBoxYarnToy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxYarnToy.Image = global::HappyPetGame_160422035_160422041.Properties.Resources.Yarn_Toy_1;
            this.pictureBoxYarnToy.Location = new System.Drawing.Point(552, 99);
            this.pictureBoxYarnToy.Margin = new System.Windows.Forms.Padding(2);
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
            this.pictureBoxBlueMarble.Location = new System.Drawing.Point(306, 99);
            this.pictureBoxBlueMarble.Margin = new System.Windows.Forms.Padding(2);
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
            this.pictureBoxBone.Location = new System.Drawing.Point(52, 99);
            this.pictureBoxBone.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBone.Name = "pictureBoxBone";
            this.pictureBoxBone.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxBone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBone.TabIndex = 0;
            this.pictureBoxBone.TabStop = false;
            // 
            // radioButtonBone
            // 
            this.radioButtonBone.AutoSize = true;
            this.radioButtonBone.BackColor = System.Drawing.Color.LavenderBlush;
            this.radioButtonBone.Checked = true;
            this.radioButtonBone.Font = new System.Drawing.Font("Dogica Pixel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBone.Location = new System.Drawing.Point(52, 62);
            this.radioButtonBone.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonBone.Name = "radioButtonBone";
            this.radioButtonBone.Size = new System.Drawing.Size(103, 23);
            this.radioButtonBone.TabIndex = 3;
            this.radioButtonBone.TabStop = true;
            this.radioButtonBone.Text = "Bone";
            this.radioButtonBone.UseVisualStyleBackColor = false;
            this.radioButtonBone.CheckedChanged += new System.EventHandler(this.radioButtonBone_CheckedChanged);
            // 
            // radioButtonBlueMarble
            // 
            this.radioButtonBlueMarble.AutoSize = true;
            this.radioButtonBlueMarble.BackColor = System.Drawing.Color.LavenderBlush;
            this.radioButtonBlueMarble.Font = new System.Drawing.Font("Dogica Pixel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBlueMarble.Location = new System.Drawing.Point(306, 62);
            this.radioButtonBlueMarble.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonBlueMarble.Name = "radioButtonBlueMarble";
            this.radioButtonBlueMarble.Size = new System.Drawing.Size(136, 23);
            this.radioButtonBlueMarble.TabIndex = 4;
            this.radioButtonBlueMarble.Text = "Marble";
            this.radioButtonBlueMarble.UseVisualStyleBackColor = false;
            this.radioButtonBlueMarble.CheckedChanged += new System.EventHandler(this.radioButtonBlueMarble_CheckedChanged);
            // 
            // radioButtonYarn
            // 
            this.radioButtonYarn.AutoSize = true;
            this.radioButtonYarn.BackColor = System.Drawing.Color.LavenderBlush;
            this.radioButtonYarn.Font = new System.Drawing.Font("Dogica Pixel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYarn.Location = new System.Drawing.Point(552, 62);
            this.radioButtonYarn.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonYarn.Name = "radioButtonYarn";
            this.radioButtonYarn.Size = new System.Drawing.Size(101, 23);
            this.radioButtonYarn.TabIndex = 5;
            this.radioButtonYarn.Text = "Yarn";
            this.radioButtonYarn.UseVisualStyleBackColor = false;
            this.radioButtonYarn.CheckedChanged += new System.EventHandler(this.radioButtonYarn_CheckedChanged);
            // 
            // labelBone
            // 
            this.labelBone.AutoSize = true;
            this.labelBone.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelBone.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBone.Location = new System.Drawing.Point(50, 338);
            this.labelBone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBone.Name = "labelBone";
            this.labelBone.Size = new System.Drawing.Size(67, 13);
            this.labelBone.TabIndex = 6;
            this.labelBone.Text = "labgel";
            // 
            // labelBlueMarble
            // 
            this.labelBlueMarble.AutoSize = true;
            this.labelBlueMarble.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelBlueMarble.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlueMarble.Location = new System.Drawing.Point(304, 338);
            this.labelBlueMarble.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBlueMarble.Name = "labelBlueMarble";
            this.labelBlueMarble.Size = new System.Drawing.Size(0, 13);
            this.labelBlueMarble.TabIndex = 7;
            // 
            // labelYarn
            // 
            this.labelYarn.AutoSize = true;
            this.labelYarn.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelYarn.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYarn.Location = new System.Drawing.Point(550, 338);
            this.labelYarn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYarn.Name = "labelYarn";
            this.labelYarn.Size = new System.Drawing.Size(0, 13);
            this.labelYarn.TabIndex = 8;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Dogica Pixel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.Location = new System.Drawing.Point(346, 390);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(96, 41);
            this.buttonBuy.TabIndex = 9;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // FormToyShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyPetGame_160422035_160422041.Properties.Resources.shop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 480);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelYarn);
            this.Controls.Add(this.labelBlueMarble);
            this.Controls.Add(this.labelBone);
            this.Controls.Add(this.radioButtonYarn);
            this.Controls.Add(this.radioButtonBlueMarble);
            this.Controls.Add(this.radioButtonBone);
            this.Controls.Add(this.pictureBoxYarnToy);
            this.Controls.Add(this.pictureBoxBlueMarble);
            this.Controls.Add(this.pictureBoxBone);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.RadioButton radioButtonBone;
        private System.Windows.Forms.RadioButton radioButtonBlueMarble;
        private System.Windows.Forms.RadioButton radioButtonYarn;
        private System.Windows.Forms.Label labelBone;
        private System.Windows.Forms.Label labelBlueMarble;
        private System.Windows.Forms.Label labelYarn;
        private System.Windows.Forms.Button buttonBuy;
    }
}