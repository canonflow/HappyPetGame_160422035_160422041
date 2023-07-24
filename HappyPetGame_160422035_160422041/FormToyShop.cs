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
    public partial class FormToyShop : Form
    {
        HappyPetGame happyPetGame;
        Toy newToy;
        string name = "";
        int price = 0;
        int benefit = 0;
        Image picture;
        public FormToyShop()
        {
            InitializeComponent();
        }

        private void FormToyShop_Load(object sender, EventArgs e)
        {
            happyPetGame = (HappyPetGame)this.Owner;

            this.Size = new Size(839, 519);
            buttonBuy.Location = new Point(
                    (this.ClientSize.Width - buttonBuy.Width) / 2,
                    390
                );

            radioButtonBlueMarble.Checked = false;
            radioButtonYarn.Checked = false;
            labelBlueMarble.Text = "";
            labelYarn.Text = "";

            name = "Bone";
            price = 3000;
            benefit = 10;
            picture = pictureBoxBone.Image;

            newToy = new Toy(name, price, benefit, picture);
            labelBone.Text = newToy.DisplayData();
        }

        private void radioButtonBone_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonBlueMarble.Checked = false;
            radioButtonYarn.Checked = false;
            labelBlueMarble.Text = "";
            labelYarn.Text = "";

            name = "Bone";
            price = 3000;
            benefit = 10;
            picture = pictureBoxBone.Image;

            newToy = new Toy(name, price, benefit, picture);
            labelBone.Text = newToy.DisplayData();
        }

        private void radioButtonBlueMarble_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonBone.Checked = false;
            radioButtonYarn.Checked = false;
            labelBone.Text = "";
            labelYarn.Text = "";

            name = "Blue Marble";
            price = 5000;
            benefit = 10;
            picture = pictureBoxBlueMarble.Image;

            newToy = new Toy(name, price, benefit, picture);
            labelBlueMarble.Text = newToy.DisplayData();
        }

        private void radioButtonYarn_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonBone.Checked = false;
            radioButtonBlueMarble.Checked = false;
            labelBone.Text = "";
            labelBlueMarble.Text = "";

            name = "Yarn";
            price = 7000;
            benefit = 15;
            picture = pictureBoxYarnToy.Image;

            newToy = new Toy(name, price, benefit, picture);
            labelYarn.Text = newToy.DisplayData();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            Player player = happyPetGame.player;
            Pet pet = player.HappyPet;
            pet.ListOfToys.Add(newToy);
            player.HappyPet = pet;

            happyPetGame.player = player;
            Auth.UpdateCurrentPlayer(player);
            this.Close();
        }
    }
}
