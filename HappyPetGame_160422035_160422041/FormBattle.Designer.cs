namespace HappyPetGame_160422035_160422041
{
    partial class FormBattle
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
            this.pictureBoxBattlePet = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.game = new System.Windows.Forms.Timer(this.components);
            this.panelBTK = new System.Windows.Forms.Panel();
            this.buttonKertas = new System.Windows.Forms.Button();
            this.buttonGunting = new System.Windows.Forms.Button();
            this.buttonBatu = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelUserChoice = new System.Windows.Forms.Label();
            this.labelEnemyChoice = new System.Windows.Forms.Label();
            this.labelKeputusan = new System.Windows.Forms.Label();
            this.labelBattlePetHp = new System.Windows.Forms.Label();
            this.labelEnemyHp = new System.Windows.Forms.Label();
            this.panelAttack = new System.Windows.Forms.Panel();
            this.buttonUltimate = new System.Windows.Forms.Button();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelHasilAkhir = new System.Windows.Forms.Label();
            this.labelBattlePetUltimate = new System.Windows.Forms.Label();
            this.labelEnemyUltimate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattlePet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            this.panelBTK.SuspendLayout();
            this.panelAttack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBattlePet
            // 
            this.pictureBoxBattlePet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBattlePet.Location = new System.Drawing.Point(12, 270);
            this.pictureBoxBattlePet.Name = "pictureBoxBattlePet";
            this.pictureBoxBattlePet.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxBattlePet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBattlePet.TabIndex = 0;
            this.pictureBoxBattlePet.TabStop = false;
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnemy.Location = new System.Drawing.Point(788, 333);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(119, 137);
            this.pictureBoxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEnemy.TabIndex = 1;
            this.pictureBoxEnemy.TabStop = false;
            // 
            // game
            // 
            this.game.Enabled = true;
            this.game.Interval = 1000;
            this.game.Tick += new System.EventHandler(this.game_Tick);
            // 
            // panelBTK
            // 
            this.panelBTK.BackColor = System.Drawing.Color.Transparent;
            this.panelBTK.Controls.Add(this.buttonKertas);
            this.panelBTK.Controls.Add(this.buttonGunting);
            this.panelBTK.Controls.Add(this.buttonBatu);
            this.panelBTK.Location = new System.Drawing.Point(293, 467);
            this.panelBTK.Name = "panelBTK";
            this.panelBTK.Size = new System.Drawing.Size(412, 82);
            this.panelBTK.TabIndex = 2;
            // 
            // buttonKertas
            // 
            this.buttonKertas.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKertas.Location = new System.Drawing.Point(327, 13);
            this.buttonKertas.Name = "buttonKertas";
            this.buttonKertas.Size = new System.Drawing.Size(82, 31);
            this.buttonKertas.TabIndex = 2;
            this.buttonKertas.Text = "Kertas";
            this.buttonKertas.UseVisualStyleBackColor = true;
            this.buttonKertas.Click += new System.EventHandler(this.buttonKertas_Click);
            // 
            // buttonGunting
            // 
            this.buttonGunting.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGunting.Location = new System.Drawing.Point(158, 13);
            this.buttonGunting.Name = "buttonGunting";
            this.buttonGunting.Size = new System.Drawing.Size(96, 31);
            this.buttonGunting.TabIndex = 1;
            this.buttonGunting.Text = "Gunting";
            this.buttonGunting.UseVisualStyleBackColor = true;
            this.buttonGunting.Click += new System.EventHandler(this.buttonGunting_Click);
            // 
            // buttonBatu
            // 
            this.buttonBatu.Font = new System.Drawing.Font("Dogica Pixel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatu.Location = new System.Drawing.Point(3, 13);
            this.buttonBatu.Name = "buttonBatu";
            this.buttonBatu.Size = new System.Drawing.Size(82, 31);
            this.buttonBatu.TabIndex = 0;
            this.buttonBatu.Text = "Batu";
            this.buttonBatu.UseVisualStyleBackColor = true;
            this.buttonBatu.Click += new System.EventHandler(this.buttonBatu_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.Transparent;
            this.labelCount.Font = new System.Drawing.Font("Dogica Pixel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(425, 26);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(153, 21);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "Count: 5";
            // 
            // labelUserChoice
            // 
            this.labelUserChoice.AutoSize = true;
            this.labelUserChoice.BackColor = System.Drawing.Color.Transparent;
            this.labelUserChoice.Font = new System.Drawing.Font("Dogica Pixel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserChoice.Location = new System.Drawing.Point(34, 26);
            this.labelUserChoice.Name = "labelUserChoice";
            this.labelUserChoice.Size = new System.Drawing.Size(0, 27);
            this.labelUserChoice.TabIndex = 4;
            // 
            // labelEnemyChoice
            // 
            this.labelEnemyChoice.AutoSize = true;
            this.labelEnemyChoice.BackColor = System.Drawing.Color.Transparent;
            this.labelEnemyChoice.Font = new System.Drawing.Font("Dogica Pixel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnemyChoice.Location = new System.Drawing.Point(799, 26);
            this.labelEnemyChoice.Name = "labelEnemyChoice";
            this.labelEnemyChoice.Size = new System.Drawing.Size(0, 27);
            this.labelEnemyChoice.TabIndex = 5;
            // 
            // labelKeputusan
            // 
            this.labelKeputusan.AutoSize = true;
            this.labelKeputusan.BackColor = System.Drawing.Color.Transparent;
            this.labelKeputusan.Font = new System.Drawing.Font("Dogica Pixel", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeputusan.Location = new System.Drawing.Point(393, 120);
            this.labelKeputusan.Name = "labelKeputusan";
            this.labelKeputusan.Size = new System.Drawing.Size(0, 35);
            this.labelKeputusan.TabIndex = 6;
            // 
            // labelBattlePetHp
            // 
            this.labelBattlePetHp.AutoSize = true;
            this.labelBattlePetHp.BackColor = System.Drawing.Color.Transparent;
            this.labelBattlePetHp.Font = new System.Drawing.Font("Dogica Pixel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBattlePetHp.Location = new System.Drawing.Point(62, 120);
            this.labelBattlePetHp.Name = "labelBattlePetHp";
            this.labelBattlePetHp.Size = new System.Drawing.Size(0, 37);
            this.labelBattlePetHp.TabIndex = 7;
            // 
            // labelEnemyHp
            // 
            this.labelEnemyHp.AutoSize = true;
            this.labelEnemyHp.BackColor = System.Drawing.Color.Transparent;
            this.labelEnemyHp.Font = new System.Drawing.Font("Dogica Pixel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnemyHp.Location = new System.Drawing.Point(791, 120);
            this.labelEnemyHp.Name = "labelEnemyHp";
            this.labelEnemyHp.Size = new System.Drawing.Size(0, 37);
            this.labelEnemyHp.TabIndex = 8;
            // 
            // panelAttack
            // 
            this.panelAttack.BackColor = System.Drawing.Color.Transparent;
            this.panelAttack.Controls.Add(this.buttonUltimate);
            this.panelAttack.Controls.Add(this.buttonAttack);
            this.panelAttack.Location = new System.Drawing.Point(347, 270);
            this.panelAttack.Name = "panelAttack";
            this.panelAttack.Size = new System.Drawing.Size(298, 134);
            this.panelAttack.TabIndex = 9;
            // 
            // buttonUltimate
            // 
            this.buttonUltimate.Font = new System.Drawing.Font("Dogica Pixel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUltimate.Location = new System.Drawing.Point(34, 63);
            this.buttonUltimate.Name = "buttonUltimate";
            this.buttonUltimate.Size = new System.Drawing.Size(243, 39);
            this.buttonUltimate.TabIndex = 1;
            this.buttonUltimate.Text = "Ultimate";
            this.buttonUltimate.UseVisualStyleBackColor = true;
            this.buttonUltimate.Click += new System.EventHandler(this.buttonUltimate_Click);
            // 
            // buttonAttack
            // 
            this.buttonAttack.Font = new System.Drawing.Font("Dogica Pixel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttack.Location = new System.Drawing.Point(52, 3);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(208, 39);
            this.buttonAttack.TabIndex = 0;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelHasilAkhir
            // 
            this.labelHasilAkhir.AutoSize = true;
            this.labelHasilAkhir.BackColor = System.Drawing.Color.Transparent;
            this.labelHasilAkhir.Font = new System.Drawing.Font("Dogica Pixel", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasilAkhir.Location = new System.Drawing.Point(245, 26);
            this.labelHasilAkhir.Name = "labelHasilAkhir";
            this.labelHasilAkhir.Size = new System.Drawing.Size(0, 48);
            this.labelHasilAkhir.TabIndex = 10;
            // 
            // labelBattlePetUltimate
            // 
            this.labelBattlePetUltimate.AutoSize = true;
            this.labelBattlePetUltimate.BackColor = System.Drawing.Color.Transparent;
            this.labelBattlePetUltimate.Font = new System.Drawing.Font("Dogica Pixel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBattlePetUltimate.Location = new System.Drawing.Point(49, 212);
            this.labelBattlePetUltimate.Name = "labelBattlePetUltimate";
            this.labelBattlePetUltimate.Size = new System.Drawing.Size(0, 21);
            this.labelBattlePetUltimate.TabIndex = 11;
            // 
            // labelEnemyUltimate
            // 
            this.labelEnemyUltimate.AutoSize = true;
            this.labelEnemyUltimate.BackColor = System.Drawing.Color.Transparent;
            this.labelEnemyUltimate.Font = new System.Drawing.Font("Dogica Pixel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnemyUltimate.Location = new System.Drawing.Point(727, 212);
            this.labelEnemyUltimate.Name = "labelEnemyUltimate";
            this.labelEnemyUltimate.Size = new System.Drawing.Size(0, 21);
            this.labelEnemyUltimate.TabIndex = 12;
            // 
            // FormBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyPetGame_160422035_160422041.Properties.Resources.bg_battle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.labelEnemyUltimate);
            this.Controls.Add(this.labelBattlePetUltimate);
            this.Controls.Add(this.labelHasilAkhir);
            this.Controls.Add(this.panelAttack);
            this.Controls.Add(this.labelEnemyHp);
            this.Controls.Add(this.labelBattlePetHp);
            this.Controls.Add(this.labelKeputusan);
            this.Controls.Add(this.labelEnemyChoice);
            this.Controls.Add(this.labelUserChoice);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.panelBTK);
            this.Controls.Add(this.pictureBoxEnemy);
            this.Controls.Add(this.pictureBoxBattlePet);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle Arena";
            this.Load += new System.EventHandler(this.FormBattle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattlePet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            this.panelBTK.ResumeLayout(false);
            this.panelAttack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBattlePet;
        private System.Windows.Forms.PictureBox pictureBoxEnemy;
        private System.Windows.Forms.Timer game;
        private System.Windows.Forms.Panel panelBTK;
        private System.Windows.Forms.Button buttonKertas;
        private System.Windows.Forms.Button buttonGunting;
        private System.Windows.Forms.Button buttonBatu;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelUserChoice;
        private System.Windows.Forms.Label labelEnemyChoice;
        private System.Windows.Forms.Label labelKeputusan;
        private System.Windows.Forms.Label labelBattlePetHp;
        private System.Windows.Forms.Label labelEnemyHp;
        private System.Windows.Forms.Panel panelAttack;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button buttonUltimate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelHasilAkhir;
        private System.Windows.Forms.Label labelBattlePetUltimate;
        private System.Windows.Forms.Label labelEnemyUltimate;
    }
}