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
        public List<Player> listOfPlayers;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameUtils.LoadData(out listOfPlayers);

            labelPlayerUsername.Text = GameUtils.player().Username;
        }
    }
}
