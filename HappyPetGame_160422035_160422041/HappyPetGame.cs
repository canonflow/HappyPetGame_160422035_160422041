﻿using System;
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
    public partial class HappyPetGame : Form
    {
        #region FIELDS
        public Player player;
        public Toy selectedToy = null;
        #endregion
        public HappyPetGame()
        {
            InitializeComponent();
        }

        #region METHODS
        private void HappyPetGame_Load(object sender, EventArgs e)
        {
            this.Size = new Size(982, 684);
            player = Auth.player();
            pictureBoxPet.Size = new Size(200, 200);
            pictureBoxPet.Image = player.HappyPet.Picture;
            pictureBoxPet.Location = new Point(
                    (this.ClientSize.Width - pictureBoxPet.Width) / 2,
                    155
                );

            pictureBoxPet.SizeMode = PictureBoxSizeMode.AutoSize;

            labelMyPet.Text = player.HappyPet.Name;
            labelCoin.Text = "Coins: " + player.Coins.ToString();
            labelPlayerName.Text = player.Username;
            labelHealth.Text = "Health: " + player.HappyPet.Health.ToString() + " %";
            labelEnergy.Text = "Energy: " +  player.HappyPet.Energy.ToString() + " %";
            labelHappiness.Text = "Happiness: " + player.HappyPet.Happiness.ToString() + " %";

            labelDate.Text = DateTime.Now.ToString();

            indikator.Start();

            if (player.HappyPet is Cat)
            {
                Cat cat = (Cat)player.HappyPet;
                buttonPlay.Enabled = true;
                buttonFeed.Enabled = true;
                buttonBath.Enabled = true;
                buttonSleep.Enabled = true;
                buttonVaccinate.Enabled = true;
                buttonClean.Enabled = false;
                buttonClean.Visible = false;
                labelTambahan.Text = "Vaccination Status: " + ((cat.VaccinateStatus) ? "Yes" : "No");
            }
            else if (player.HappyPet is Fish)
            {
                Fish fish = player.HappyPet as Fish;
                buttonPlay.Enabled = false;
                buttonPlay.Visible = false;
                buttonBath.Enabled = false;
                buttonBath.Visible = false;
                buttonFeed.Enabled = true;
                buttonVaccinate.Enabled = false;
                buttonVaccinate.Visible = false;
                buttonClean.Enabled = true;
                buttonSleep.Enabled = false;
                buttonSleep.Visible = false;
                labelTambahan.Text = "Environment: " + fish.Environment;
            }
            else if (player.HappyPet is Chameleon)
            {
                Chameleon chameleon = player.HappyPet as Chameleon;
                buttonPlay.Enabled = false;
                buttonPlay.Visible = false;
                buttonBath.Visible = false;
                buttonBath.Enabled = false;
                buttonBath.Visible = false;
                buttonFeed.Enabled = true;
                buttonVaccinate.Enabled = false;
                buttonVaccinate.Visible = false;
                buttonClean.Enabled = false;
                buttonClean.Visible = false;
                buttonSleep.Enabled = true;
                labelTambahan.Text = "Current Color: " + chameleon.CurrentColor;
            }
            else if (player.HappyPet is Bird)
            {
                Bird bird = player.HappyPet as Bird;
                buttonPlay.Enabled = true;
                buttonBath.Enabled = false;
                buttonBath.Visible = false;
                buttonFeed.Enabled = true;
                buttonVaccinate.Enabled = true;
                buttonClean.Enabled = true;
                buttonSleep.Enabled = true;
                labelTambahan.Text = "Vaccination Status: " + ((bird.VaccinateStatus) ? "Yes" : "No");
            }
            else if (player.HappyPet is Dog)
            {
                Dog dog = player.HappyPet as Dog;
                buttonPlay.Enabled = true;
                buttonBath.Enabled = true;
                buttonFeed.Enabled = true;
                buttonVaccinate.Enabled = true;
                buttonClean.Enabled = false;
                buttonClean.Visible = false;
                buttonSleep.Enabled = true;
                labelTambahan.Text = "Vaccination Status: " + ((dog.VaccinateStatus) ? "Yes" : "No");
            }
        }

        private void indikator_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString();
            if (player.HappyPet.Health - 5 < 0)
            {
                player.HappyPet.Health = 0;
            }
            else
            {
                player.HappyPet.Health -= 5;
            }

            if (player.HappyPet.Energy - 5 < 0)
            {
                player.HappyPet.Energy = 0;
            }
            else
            {
                player.HappyPet.Energy -= 5;
            }

            if (player.HappyPet.Happiness - 5 < 0)
            {
                player.HappyPet.Happiness = 0;
            }
            else
            {
                player.HappyPet.Happiness -= 5;
            }

            labelHealth.Text = "Health: " + player.HappyPet.Health.ToString() + " %";
            labelEnergy.Text = "Energy: " + player.HappyPet.Energy.ToString() + " %";
            labelHappiness.Text = "Happiness: " + player.HappyPet.Happiness.ToString() + " %";
            labelCoin.Text = "Coins: " + player.Coins.ToString();

            if (player.HappyPet is Cat)
            {
                Cat cat = (Cat)player.HappyPet;
                
                labelTambahan.Text = "Vaccination Status: " + ((cat.VaccinateStatus) ? "Yes" : "No");
            }
            else if (player.HappyPet is Fish)
            {
                Fish fish = player.HappyPet as Fish;
                
                labelTambahan.Text = "Environment: " + fish.Environment;
            }
            else if (player.HappyPet is Chameleon)
            {
                Chameleon chameleon = player.HappyPet as Chameleon;
                
                labelTambahan.Text = "Current Color: " + chameleon.CurrentColor;
            }
            else if (player.HappyPet is Bird)
            {
                Bird bird = player.HappyPet as Bird;
                
                labelTambahan.Text = "Vaccination Status: " + ((bird.VaccinateStatus) ? "Yes" : "No");
            }
            else if (player.HappyPet is Dog)
            {
                Dog dog = player.HappyPet as Dog;
                
                labelTambahan.Text = "Vaccination Status: " + ((dog.VaccinateStatus) ? "Yes" : "No");
            }


            if (player.HappyPet.GetHealthCondition() == "Very Poor" &&
                player.HappyPet.GetEnergyCondition() == "Weak" &&
                player.HappyPet.GetHappinessCondition() == "Unhappy")
            {
                indikator.Stop();
                player.HappyPet = null;
                player.Coins = 100;
                Auth.UpdateCurrentPlayer(player);
                MessageBox.Show("GAME OVER! Your Pet is very poor, weak, and unhappy.");
                this.Close();
            }

        }

        private void HappyPetGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            indikator.Stop();
            player.LastPlay = DateTime.Now;
            Auth.UpdateCurrentPlayer(player);
        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            try
            {
                player.HappyPet.Feed(ref player);
                Auth.UpdateCurrentPlayer(player);
                ShowIndi();
                if (player.HappyPet is Cat)
                {
                    pictureBoxPet.Image = Properties.Resources.Feed_Cat_Animation;
                }
                else if (player.HappyPet is Chameleon)
                {
                    pictureBoxPet.Image = Properties.Resources.Feed_Chameleon_Animation;
                }
                else if (player.HappyPet is Bird)
                {
                    pictureBoxPet.Image = Properties.Resources.Feed_Bird_Animation;
                }
                else if (player.HappyPet is Dog)
                {
                    pictureBoxPet.Image = Properties.Resources.Feed_Dog_Animation;
                }
                else if (player.HappyPet is Fish)
                {
                    pictureBoxPet.Image = Properties.Resources.Feed_Fish_Animation;
                }
                
                game.Stop();
                game.Start();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonBath_Click(object sender, EventArgs e)
        {
            try
            {
                if (player.HappyPet is Cat)
                {
                    Cat cat = (Cat)player.HappyPet;
                    cat.Bath(ref player);
                    player.HappyPet = cat;
                    Auth.UpdateCurrentPlayer(player);
                    ShowIndi();
                    pictureBoxPet.Image = Properties.Resources.Bath_Cat_Animation;
                    game.Stop();
                    game.Start();
                }
                else if (player.HappyPet is Dog)
                {
                    Dog dog = player.HappyPet as Dog;
                    dog.Bath(ref player);
                    player.HappyPet = dog;
                    Auth.UpdateCurrentPlayer(player);
                    ShowIndi();
                    pictureBoxPet.Image = Properties.Resources.Bath_Dog_Animation;
                    game.Stop();
                    game.Start();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonSleep_Click(object sender, EventArgs e)
        {
            try
            {
                if (player.HappyPet is Cat)
                {
                    Cat cat = (Cat)player.HappyPet;
                    cat.Sleep(ref player);
                    player.HappyPet = cat;
                    Auth.UpdateCurrentPlayer(player);
                    ShowIndi();
                    pictureBoxPet.Image = Properties.Resources.Sleep_Cat_Animation;
                    game.Stop();
                    game.Start();
                }
                else if (player.HappyPet is Chameleon)
                {
                    Chameleon chameleon = player.HappyPet as Chameleon;
                    chameleon.Sleep(ref player);
                    player.HappyPet = chameleon;
                    Auth.UpdateCurrentPlayer(player);
                    ShowIndi();
                    pictureBoxPet.Image = Properties.Resources.Sleep_Chameleon_Animation;
                }
                else if (player.HappyPet is Bird)
                {
                    Bird bird = player.HappyPet as Bird;
                    bird.Sleep(ref player);
                    player.HappyPet = bird;
                    Auth.UpdateCurrentPlayer(player);
                    ShowIndi();
                    pictureBoxPet.Image = Properties.Resources.Sleep_Bird_Animation;
                }
                else if (player.HappyPet is Dog)
                {
                    Dog dog = player.HappyPet as Dog;
                    dog.Sleep(ref player);
                    player.HappyPet = dog;
                    Auth.UpdateCurrentPlayer(player);
                    ShowIndi();
                    pictureBoxPet.Image = Properties.Resources.Sleep_Dog_Animation;
                    game.Stop();
                    game.Start();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (player.HappyPet is Cat)
                {
                    FormSelectToy selectToy = new FormSelectToy();
                    selectToy.Owner = this;
                    selectToy.ShowDialog();
                    ShowIndi();
                }
                //! Terbang
                else if (player.HappyPet is Bird)
                {
                    Bird bird = player.HappyPet as Bird;
                    bird.Play(ref player);
                    player.HappyPet = bird;
                    Auth.UpdateCurrentPlayer(player);
                    ShowIndi();
                    pictureBoxPet.Image = Properties.Resources.Flying_Bird_Animation;
                    game.Stop();
                    game.Start();
                }
                else if (player.HappyPet is Dog)
                {
                    FormSelectToy selectToy = new FormSelectToy();
                    selectToy.Owner = this;
                    selectToy.ShowDialog();
                    ShowIndi();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonVaccinate_Click(object sender, EventArgs e)
        {
            try
            {
                if (player.HappyPet is Cat)
                {
                    Cat cat = (Cat)player.HappyPet;
                    cat.Vaccinate(ref player);
                    player.HappyPet = cat;
                    Auth.UpdateCurrentPlayer(player);
                    ShowIndi();
                    pictureBoxPet.Image = Properties.Resources.Vaccinate_Cat_Animation;
                    game.Stop();
                    game.Start();
                }
                else if (player.HappyPet is Bird)
                {
                    Bird bird = player.HappyPet as Bird;
                    bird.Vaccinate(ref player);
                    player.HappyPet = bird;
                    Auth.UpdateCurrentPlayer(player);
                    ShowIndi();
                    pictureBoxPet.Image = Properties.Resources.Vaccinate_Bird_Animation;
                    game.Stop();
                    game.Start();
                }
                else if (player.HappyPet is Dog)
                {
                    Dog dog = player.HappyPet as Dog;
                    dog.Vaccinate(ref player);
                    player.HappyPet = dog;
                    Auth.UpdateCurrentPlayer(player);
                    ShowIndi();
                    pictureBoxPet.Image = Properties.Resources.Vaccinate_Dog_Animation;
                    game.Stop();
                    game.Start();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            try
            {
                if (player.HappyPet is Fish)
                {
                    Fish fish = player.HappyPet as Fish;
                    fish.Clean(ref player);
                    player.HappyPet = fish;
                    Auth.UpdateCurrentPlayer(player);
                    ShowIndi();
                    pictureBoxPet.Image = Properties.Resources.Clean_Fish_Animation;
                    game.Stop();
                    game.Start();
                }
                else if (player.HappyPet is Bird)
                {
                    Bird bird = player.HappyPet as Bird;
                    bird.Clean(ref player);
                    player.HappyPet = bird;
                    Auth.UpdateCurrentPlayer(player);
                    ShowIndi();
                    pictureBoxPet.Image = Properties.Resources.Clean_Bird_Animation;
                    game.Stop();
                    game.Start();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void game_Tick(object sender, EventArgs e)
        {

            if (player.HappyPet is Cat)
            {
                pictureBoxPet.Image = Properties.Resources.Idle_Cat_Animation;
            }
            else if (player.HappyPet is Chameleon)
            {
                pictureBoxPet.Image = Properties.Resources.Idle_Chameleon_Animation;
            }
            else if (player.HappyPet is Bird)
            {
                pictureBoxPet.Image = Properties.Resources.bird_idle_200;
            }
            else if (player.HappyPet is Dog)
            {
                pictureBoxPet.Image = Properties.Resources.Idle_Dog_Animation;
            }
            else if (player.HappyPet is Fish)
            {
                pictureBoxPet.Image = Properties.Resources.Idle_Fish_Animation;
            }
        }
        
        public void UseToy()
        {
            if (player.HappyPet is Cat)
            {
                if (selectedToy.Name == "Bone")
                {
                    pictureBoxPet.Image = Properties.Resources.Play_Bone_Cat_Animation;
                    selectedToy = null;
                    game.Stop();
                    game.Start();
                    selectedToy = null;
                }
                else if (selectedToy.Name == "Blue Marble")
                {
                    pictureBoxPet.Image = Properties.Resources.Play_Cat_Animation_Blue_Marble;
                    selectedToy = null;
                    game.Stop();
                    game.Start();
                    selectedToy = null;
                }
                else if (selectedToy.Name == "Yarn")
                {
                    pictureBoxPet.Image = Properties.Resources.Play_Yarn_Cat_Animation;
                    selectedToy = null;
                    game.Stop();
                    game.Start();
                    selectedToy = null;
                }
            }
            else if (player.HappyPet is Dog)
            {
                if (selectedToy.Name == "Bone")
                {
                    pictureBoxPet.Image = Properties.Resources.Play_Bone_Dog_Animation;
                    selectedToy = null;
                    game.Stop();
                    game.Start();
                    selectedToy = null;
                }
                else if (selectedToy.Name == "Blue Marble")
                {
                    pictureBoxPet.Image = Properties.Resources.Play_Dog_Animation_Blue_Marble;
                    selectedToy = null;
                    game.Stop();
                    game.Start();
                    selectedToy = null;
                }
                else if (selectedToy.Name == "Yarn")
                {
                    pictureBoxPet.Image = Properties.Resources.Play_Yarn_Dog_Animation;
                    selectedToy = null;
                    game.Stop();
                    game.Start();
                    selectedToy = null;
                }
            }
        }

        private void ShowIndi()
        {
            labelHealth.Text = "Health: " + player.HappyPet.Health.ToString() + " %";
            labelEnergy.Text = "Energy: " + player.HappyPet.Energy.ToString() + " %";
            labelHappiness.Text = "Happiness: " + player.HappyPet.Happiness.ToString() + " %";
        }
        #endregion
    }
}
