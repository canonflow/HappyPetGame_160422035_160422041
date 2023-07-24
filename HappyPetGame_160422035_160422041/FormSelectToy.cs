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
    public partial class FormSelectToy : Form
    {
        HappyPetGame happyPetGame;
        public FormSelectToy()
        {
            InitializeComponent();
        }

        private void FormSelectToy_Load(object sender, EventArgs e)
        {
            happyPetGame = (HappyPetGame)this.Owner;
            pictureBoxToy.Location = new Point(
                    (this.ClientSize.Width - pictureBoxToy.Width)/2,
                    165
                );

            buttonUse.Location = new Point(
                    (this.ClientSize.Width - buttonUse.Width) / 2,
                    436
                );

            comboBoxToys.DataSource = happyPetGame.player.HappyPet.ListOfToys;
            comboBoxToys.DisplayMember = "Name";

            if (comboBoxToys.Items.Count > 0)
            {
                comboBoxToys.SelectedIndex = 0;
                Toy toy = (Toy)comboBoxToys.SelectedItem;
                pictureBoxToy.Image = toy.Picture;
                labelToyData.Text = toy.DisplayData();
            }
        }

        private void comboBoxToys_SelectedIndexChanged(object sender, EventArgs e)
        {
            Toy toy = (Toy)comboBoxToys.SelectedItem;
            pictureBoxToy.Image = toy.Picture;
            labelToyData.Text = toy.DisplayData();
        }

        private void buttonUse_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxToys.SelectedItem != null)
                {
                    Toy toy = (Toy)comboBoxToys.SelectedItem;
                    Pet pet = happyPetGame.player.HappyPet;
                    if (pet is Cat)
                    {
                        Cat cat = pet as Cat;
                        Player player = happyPetGame.player;

                        happyPetGame.selectedToy = toy;
                        happyPetGame.UseToy();
                        cat.Play(ref player, toy.Benefit);
                        cat.ListOfToys.Remove(toy);
                        player.HappyPet = cat;

                        happyPetGame.player = player;
                        Auth.UpdateCurrentPlayer(player);
                        this.Close();
                    }
                    else if (pet is Dog)
                    {
                        Dog dog = pet as Dog;
                        Player player = happyPetGame.player;

                        happyPetGame.selectedToy = toy;
                        happyPetGame.UseToy();
                        dog.Play(ref player, toy.Benefit);
                        dog.ListOfToys.Remove(toy);
                        player.HappyPet = dog;

                        happyPetGame.player = player;
                        Auth.UpdateCurrentPlayer(player);
                        this.Close();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void linkLabelBuyToy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormToyShop toyShop = new FormToyShop();
            toyShop.Owner = this.Owner;
            this.Hide();
            toyShop.ShowDialog();
            this.Close();
        }
    }
}
