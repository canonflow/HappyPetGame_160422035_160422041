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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(1280, 720);       
        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.W)
            {
                player.Top -= GameUtils.PLAYER_MOVEMENT;
            }
            if (e.KeyCode == Keys.S)
            {
                player.Top += GameUtils.PLAYER_MOVEMENT;
            }

            if (e.KeyCode == Keys.A)
            {
                player.Left -= GameUtils.PLAYER_MOVEMENT;
            }

            if (e.KeyCode == Keys.D)
            {
                player.Left += GameUtils.PLAYER_MOVEMENT;
            }
            */
        }

        private void Home_KeyUp(object sender, KeyEventArgs e)
        {

        }

        
    }
}
