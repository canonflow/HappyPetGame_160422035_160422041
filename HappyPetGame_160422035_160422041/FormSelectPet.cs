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
    public partial class FormSelectPet : Form
    {
        Player player;
        public FormSelectPet()
        {
            InitializeComponent();
        }

        private void FormSelectPet_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1319, 630);
            player = Auth.player();
            comboBoxEnvironment.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pet newPet;

                if (radioButtonCat.Checked)
                {
                    newPet = new Cat(textBoxPetName.Text, Properties.Resources.Idle_Cat_Animation);
                }

                else if (radioButtonFish.Checked)
                {
                    string environment = comboBoxEnvironment.Text;
                    newPet = new Fish(textBoxPetName.Text, Properties.Resources.Idle_Fish_Animation, environment);
                }

                else if (radioButtonChameleon.Checked)
                {
                    Color currentColor = Color.Green;
                    newPet = new Chameleon(textBoxPetName.Text, Properties.Resources.Idle_Chameleon_Animation, currentColor);
                }

                else if (radioButtonBird.Checked)
                {
                    newPet = new Bird(textBoxPetName.Text, Properties.Resources.bird_idle_2001);
                }

                else
                {
                    newPet = new Dog(textBoxPetName.Text, Properties.Resources.Idle_Dog_Animation);
                }

                player.HappyPet = newPet;
                Auth.UpdateCurrentPlayer(player);

                HappyPetGame game = new HappyPetGame();
                this.Hide();
                game.ShowDialog();
                this.Close();
            }

            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void radioButtonFish_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvi.Visible = true;
            comboBoxEnvironment.Visible = true;
        }

        private void radioButtonCat_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvi.Visible = false;
            comboBoxEnvironment.Visible = false;
        }

        private void radioButtonChameleon_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvi.Visible = false;
            comboBoxEnvironment.Visible = false;
        }

        private void radioButtonBird_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvi.Visible = false;
            comboBoxEnvironment.Visible = false;
        }

        private void radioButtonDog_CheckedChanged(object sender, EventArgs e)
        {
            labelEnvi.Visible = false;
            comboBoxEnvironment.Visible = false;
        }
    }
}
