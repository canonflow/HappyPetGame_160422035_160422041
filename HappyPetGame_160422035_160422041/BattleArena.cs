using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace HappyPetGame_160422035_160422041
{
    public partial class BattleArena : Form
    {
        SoundPlayer player = new SoundPlayer(@"music/wav/Sinnoh-Frontier-Brain.wav");
        public BattleArena()
        {
            InitializeComponent();
        }

        private void BattleArena_Load(object sender, EventArgs e)
        {
            this.Size = new Size(880, 500);
            btnPlay.Size = new Size(215, 55);
            buttonReset.Size = new Size(172, 55);
            lblBatleArena.SizeMode = PictureBoxSizeMode.AutoSize;
            
            btnPlay.Location = new Point(
                    (this.ClientSize.Width - btnPlay.Width)/2,
                    (this.ClientSize.Height - btnPlay.Height - 30)
                );

            buttonReset.Location = new Point(
                    (this.ClientSize.Width - buttonReset.Width - 20),
                    (this.ClientSize.Height - buttonReset.Height - 20)
                );

            lblBatleArena.Location = new Point(
                    (this.ClientSize.Width - lblBatleArena.Width)/2,
                    16
                );

            labelPoin.Text = Auth.player().Points.ToString();

            //player.PlayLooping();
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
            try
            {
                if (Auth.player().BattlePet != null)
                {
                    FormSelectEnemy selectEnemy = new FormSelectEnemy();
                    this.Hide();
                    selectEnemy.ShowDialog();
                    this.Close();
                }
                else
                {
                    FormCreateBattlePet create = new FormCreateBattlePet();
                    this.Hide();
                    create.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Stop();
            this.Close();
        }

        protected override void OnActivated(EventArgs e)
        {
            player.PlayLooping();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            try
            {
                FormCreateBattlePet create = new FormCreateBattlePet();
                this.Hide();
                create.ShowDialog();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
