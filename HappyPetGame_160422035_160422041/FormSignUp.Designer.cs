namespace HappyPetGame_160422035_160422041
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSignupPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dogica Pixel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUsername.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(109, 50);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(163, 19);
            this.textBoxUsername.TabIndex = 8;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Image = global::HappyPetGame_160422035_160422041.Properties.Resources.login;
            this.buttonLogin.Location = new System.Drawing.Point(109, 382);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(98, 35);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonSignupPage
            // 
            this.buttonSignupPage.BackColor = System.Drawing.Color.Transparent;
            this.buttonSignupPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignupPage.FlatAppearance.BorderSize = 0;
            this.buttonSignupPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSignupPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSignupPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignupPage.Image = global::HappyPetGame_160422035_160422041.Properties.Resources.SignUp;
            this.buttonSignupPage.Location = new System.Drawing.Point(125, 84);
            this.buttonSignupPage.Name = "buttonSignupPage";
            this.buttonSignupPage.Size = new System.Drawing.Size(123, 35);
            this.buttonSignupPage.TabIndex = 9;
            this.buttonSignupPage.UseVisualStyleBackColor = false;
            this.buttonSignupPage.Click += new System.EventHandler(this.buttonSignupPage_Click);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyPetGame_160422035_160422041.Properties.Resources.bg_signup;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 442);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonSignupPage);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonSignupPage;
        private System.Windows.Forms.Button buttonLogin;
    }
}