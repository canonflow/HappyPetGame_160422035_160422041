using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    public partial class HappyPetHome : Form
    {
        public HappyPetHome()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //! Kalo player punya pet
            if (Auth.player().HappyPet != null)
            {
                HappyPetGame game = new HappyPetGame();
                game.ShowDialog();
            }
            else
            {
                FormSelectPet selectPet = new FormSelectPet();
                selectPet.ShowDialog();
            }
        }

        private void buttonResetGame_Click(object sender, EventArgs e)
        {
            FormSelectPet selectPet = new FormSelectPet();
            Player player = Auth.player();
            player.HappyPet = null;
            player.Coins = 100;  //! Blm yakin, kalo di ppt gini
            Auth.UpdateCurrentPlayer(player);
            selectPet.ShowDialog();
        }

        private void HappyPetHome_Load(object sender, EventArgs e)
        {
            this.Size = new Size(616, 405);
            buttonPlay.Size = new Size(160, 35);
            buttonResetGame.Size = new Size(129, 27);
            pictureBoxTitle.Size = new Size(297, 51);
            pictureBoxTitle.Location = new Point(
                    (this.ClientSize.Width - pictureBoxTitle.Width) / 2,
                    12
                );

            buttonPlay.Location = new Point(
                    (this.ClientSize.Width - buttonPlay.Width) / 2,
                    141
                );

            buttonResetGame.Location = new Point(
                    (this.ClientSize.Width - buttonResetGame.Width ) / 2,
                    328
                );
        }
    }
}
