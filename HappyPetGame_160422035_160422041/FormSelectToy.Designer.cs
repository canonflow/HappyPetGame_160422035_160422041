namespace HappyPetGame_160422035_160422041
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectToy));
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
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.comboBoxToys.Location = new System.Drawing.Point(41, 66);
            this.comboBoxToys.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxToys.Name = "comboBoxToys";
            this.comboBoxToys.Size = new System.Drawing.Size(208, 32);
            this.comboBoxToys.TabIndex = 1;
            this.comboBoxToys.SelectedIndexChanged += new System.EventHandler(this.comboBoxToys_SelectedIndexChanged);
            // 
            // pictureBoxToy
            // 
            this.pictureBoxToy.Location = new System.Drawing.Point(57, 133);
            this.pictureBoxToy.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxToy.Name = "pictureBoxToy";
            this.pictureBoxToy.Size = new System.Drawing.Size(150, 162);
            this.pictureBoxToy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxToy.TabIndex = 2;
            this.pictureBoxToy.TabStop = false;
            // 
            // labelToyData
            // 
            this.labelToyData.AutoSize = true;
            this.labelToyData.Font = new System.Drawing.Font("Dogica Pixel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToyData.Location = new System.Drawing.Point(78, 310);
            this.labelToyData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelToyData.Name = "labelToyData";
            this.labelToyData.Size = new System.Drawing.Size(151, 16);
            this.labelToyData.TabIndex = 3;
            this.labelToyData.Text = "Toy\'s Data";
            // 
            // buttonUse
            // 
            this.buttonUse.Font = new System.Drawing.Font("Dogica Pixel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUse.Location = new System.Drawing.Point(80, 354);
            this.buttonUse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUse.Name = "buttonUse";
            this.buttonUse.Size = new System.Drawing.Size(112, 41);
            this.buttonUse.TabIndex = 4;
            this.buttonUse.Text = "Use";
            this.buttonUse.UseVisualStyleBackColor = true;
            this.buttonUse.Click += new System.EventHandler(this.buttonUse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 500);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Don\'t have any?";
            // 
            // linkLabelBuyToy
            // 
            this.linkLabelBuyToy.AutoSize = true;
            this.linkLabelBuyToy.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBuyToy.Location = new System.Drawing.Point(183, 500);
            this.linkLabelBuyToy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelBuyToy.Name = "linkLabelBuyToy";
            this.linkLabelBuyToy.Size = new System.Drawing.Size(89, 13);
            this.linkLabelBuyToy.TabIndex = 6;
            this.linkLabelBuyToy.TabStop = true;
            this.linkLabelBuyToy.Text = "Buy Here";
            this.linkLabelBuyToy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBuyToy_LinkClicked);
            // 
            // FormSelectToy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(298, 537);
            this.Controls.Add(this.linkLabelBuyToy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUse);
            this.Controls.Add(this.labelToyData);
            this.Controls.Add(this.pictureBoxToy);
            this.Controls.Add(this.comboBoxToys);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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