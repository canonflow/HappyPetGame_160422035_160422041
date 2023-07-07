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
    public partial class Form1 : Form
    {
        //public List<Player> listOfPlayers;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelCoin.Text = Auth.player().Coins.ToString();
            labelPlayerUsername.Text = Auth.player().Username;
        }


        private void UpdatePlayerInformation()
        {
            labelCoin.Text = Auth.player().Coins.ToString();
            labelPlayerUsername.Text = Auth.player().Username;
        }

        private void buttonUpdateCoin_Click(object sender, EventArgs e)
        {
            int coin = int.Parse(textBoxCoin.Text);
            Player player = Auth.player();
            player.Coins += coin;

            Auth.UpdateCurrentPlayer(player);
            UpdatePlayerInformation();
            textBoxCoin.Text = "";
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();

            Auth.SignOut();

            this.Hide();
            formLogin.ShowDialog();
            this.Close();

        }
    }
}
