using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    public partial class FormSelectEnemy : Form
    {
        public Enemy enemy;
        public FormSelectEnemy()
        {
            InitializeComponent();
        }

        private void FormSelectEnemy_Load(object sender, EventArgs e)
        {
            this.Size = new Size(880, 500);
            lblSelectEnemy.SizeMode = PictureBoxSizeMode.AutoSize;
            btnFightAsimole.Size = new Size(134, 40);
            btnFightBarrel.Size = new Size(134, 40);
            btnFightDemonPot.Size = new Size(134, 40);

            lblSelectEnemy.Location = new Point(
                    (this.ClientSize.Width - lblSelectEnemy.Width) / 2,
                    16
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFightAsimole_Click(object sender, EventArgs e)
        {
            enemy = new Enemy("Asimole", Auth.player().BattlePet.Level, GameUtils.BASE_ASIMOLE_DAMAGE, GameUtils.BASE_ASIMOLE_HP, GameUtils.BASE_ASIMOLE_ULTI, pictureBoxAsimole, 1);
            FormBattle formBattle = new FormBattle();
            formBattle.Owner = this;
            formBattle.ShowDialog();
        }

        private void btnFightBarrel_Click(object sender, EventArgs e)
        {
            enemy = new Enemy("Barrel", Auth.player().BattlePet.Level, GameUtils.BASE_BARREL_DAMAGE, GameUtils.BASE_BARREL_HP, GameUtils.BASE_BARREL_ULTI, pictureBoxBarrel);
            FormBattle formBattle = new FormBattle();
            formBattle.Owner = this;
            formBattle.ShowDialog();
        }

        private void btnFightDemonPot_Click(object sender, EventArgs e)
        {
            enemy = new Enemy("Demon Pot", Auth.player().BattlePet.Level, GameUtils.BASE_DEMON_POT_DAMAGE, GameUtils.BASE_DEMON_POT_HP, GameUtils.BASE_DEMON_POT_ULTI, pictureBoxDemonPot);
            FormBattle formBattle = new FormBattle();
            formBattle.Owner = this;
            formBattle.ShowDialog();
        }
    }
}
