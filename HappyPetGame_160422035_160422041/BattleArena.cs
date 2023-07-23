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
    public partial class BattleArena : Form
    {
        public BattleArena()
        {
            InitializeComponent();
        }

        private void BattleArena_Load(object sender, EventArgs e)
        {
            this.Size = new Size(880, 500);
            btnPlay.Size = new Size(215, 55);
            lblBatleArena.SizeMode = PictureBoxSizeMode.AutoSize;
            
            btnPlay.Location = new Point(
                    (this.ClientSize.Width - btnPlay.Width)/2,
                    (this.ClientSize.Height - btnPlay.Height - 30)
                );

            lblBatleArena.Location = new Point(
                    (this.ClientSize.Width - lblBatleArena.Width)/2,
                    16
                );
        }

        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            btnPlay.BackgroundImage = Properties.Resources.play_hover;
        }


        private void btnPlay_MouseEnter_1(object sender, EventArgs e)
        {
            btnPlay.BackgroundImage = Properties.Resources.play_hover;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.BackgroundImage = Properties.Resources.play;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            FormSelectEnemy selectEnemy = new FormSelectEnemy();
            this.Hide();
            selectEnemy.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
