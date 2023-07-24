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
    public partial class FormCreateBattlePet : Form
    {
        #region FIELDS
        BattlePet battlePet;
        Image image;
        #endregion
        public FormCreateBattlePet()
        {
            InitializeComponent();
        }

        #region METHODS
        private void FormCreateBattlePet_Load(object sender, EventArgs e)
        {
            this.Size = new Size(856, 500);

            btnPlay.Location = new Point(
                    (this.ClientSize.Width - btnPlay.Width) / 2,
                    390
                );

            image = pictureBoxCat.Image;
            battlePet = new BattlePet(textBoxName.Text, image);
        }

        private void radioButtonCat_CheckedChanged(object sender, EventArgs e)
        {
            image = pictureBoxCat.Image;
            battlePet = new BattlePet(textBoxName.Text, image);
        }


        private void radioButtonBird_CheckedChanged(object sender, EventArgs e)
        {
            image = pictureBoxBird.Image;
            battlePet = new BattlePet(textBoxName.Text, image);
        }

        private void radioButtonChameleon_CheckedChanged(object sender, EventArgs e)
        {
            image = pictureBoxChameleon.Image;
            battlePet = new BattlePet(textBoxName.Text, image);
        }

        private void radioButtonDog_CheckedChanged(object sender, EventArgs e)
        {
            image = pictureBoxDog.Image;
            battlePet = new BattlePet(textBoxName.Text, image);
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                Player player = Auth.player();
                player.BattlePet = battlePet;
                player.PetDefenderCoins = 500;
                Auth.UpdateCurrentPlayer(player);

                //BattleArena battleArena = new BattleArena();
                FormSelectEnemy selectEnemy = new FormSelectEnemy();
                this.Hide();
                selectEnemy.ShowDialog();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        #endregion
    }
}
