using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    public partial class FormUpgradeBattlePet : Form
    {
        Player player;
        public FormUpgradeBattlePet()
        {
            InitializeComponent();
            this.Size = new Size(739, 606);
            player = Auth.player();
            pictureBoxPet.Location = new Point(
                    (this.ClientSize.Width - pictureBoxPet.Width) / 2,
                    75
                );

            pictureBoxPet.Image = player.BattlePet.PetImage;
            buttonUpgrade.Location = new Point(
                    (this.ClientSize.Width - buttonUpgrade.Width) / 2,
                    405
                );

            buttonExit.Location = new Point(562, 405);
            labelLevel.Text = player.BattlePet.Level + "/50";
            labelCoins.Text = player.PetDefenderCoins.ToString();

        }

        private void buttonUpgrade_Click(object sender, EventArgs e)
        {
            try
            {
                BattlePet battlePet = player.BattlePet;
                battlePet.Upgrade(ref player);
                player.BattlePet = battlePet;
                Auth.UpdateCurrentPlayer(player);

                labelLevel.Text = battlePet.Level + "/50";
                labelCoins.Text = player.PetDefenderCoins.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
