﻿namespace HappyPetGame_160422035_160422041
{
    partial class FormSelectToy
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxToys = new System.Windows.Forms.ComboBox();
            this.pictureBoxToy = new System.Windows.Forms.PictureBox();
            this.labelToyData = new System.Windows.Forms.Label();
            this.buttonUse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelBuyToy = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dogica Pixel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Toy";
            // 
            // comboBoxToys
            // 
            this.comboBoxToys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToys.Font = new System.Drawing.Font("Dogica Pixel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxToys.FormattingEnabled = true;
            this.comboBoxToys.Location = new System.Drawing.Point(55, 81);
            this.comboBoxToys.Name = "comboBoxToys";
            this.comboBoxToys.Size = new System.Drawing.Size(276, 32);
            this.comboBoxToys.TabIndex = 1;
            this.comboBoxToys.SelectedIndexChanged += new System.EventHandler(this.comboBoxToys_SelectedIndexChanged);
            // 
            // pictureBoxToy
            // 
            this.pictureBoxToy.Location = new System.Drawing.Point(76, 164);
            this.pictureBoxToy.Name = "pictureBoxToy";
            this.pictureBoxToy.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxToy.TabIndex = 2;
            this.pictureBoxToy.TabStop = false;
            // 
            // labelToyData
            // 
            this.labelToyData.AutoSize = true;
            this.labelToyData.Font = new System.Drawing.Font("Dogica Pixel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToyData.Location = new System.Drawing.Point(104, 382);
            this.labelToyData.Name = "labelToyData";
            this.labelToyData.Size = new System.Drawing.Size(151, 16);
            this.labelToyData.TabIndex = 3;
            this.labelToyData.Text = "Toy\'s Data";
            // 
            // buttonUse
            // 
            this.buttonUse.Font = new System.Drawing.Font("Dogica Pixel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUse.Location = new System.Drawing.Point(106, 436);
            this.buttonUse.Name = "buttonUse";
            this.buttonUse.Size = new System.Drawing.Size(149, 50);
            this.buttonUse.TabIndex = 4;
            this.buttonUse.Text = "Use";
            this.buttonUse.UseVisualStyleBackColor = true;
            this.buttonUse.Click += new System.EventHandler(this.buttonUse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 615);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Don\'t have any?";
            // 
            // linkLabelBuyToy
            // 
            this.linkLabelBuyToy.AutoSize = true;
            this.linkLabelBuyToy.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBuyToy.Location = new System.Drawing.Point(244, 615);
            this.linkLabelBuyToy.Name = "linkLabelBuyToy";
            this.linkLabelBuyToy.Size = new System.Drawing.Size(89, 13);
            this.linkLabelBuyToy.TabIndex = 6;
            this.linkLabelBuyToy.TabStop = true;
            this.linkLabelBuyToy.Text = "Buy Here";
            this.linkLabelBuyToy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBuyToy_LinkClicked);
            // 
            // FormSelectToy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 661);
            this.Controls.Add(this.linkLabelBuyToy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUse);
            this.Controls.Add(this.labelToyData);
            this.Controls.Add(this.pictureBoxToy);
            this.Controls.Add(this.comboBoxToys);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSelectToy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Toy";
            this.Load += new System.EventHandler(this.FormSelectToy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxToys;
        private System.Windows.Forms.PictureBox pictureBoxToy;
        private System.Windows.Forms.Label labelToyData;
        private System.Windows.Forms.Button buttonUse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelBuyToy;
    }
}