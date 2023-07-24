using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;

namespace HappyPetGame_160422035_160422041
{
    public partial class FormLogin : Form
    {
        #region FIELDS
        SoundPlayer soundPlayer = new SoundPlayer(@"music/wav/Title-Theme-The-Legend-of-Zelda.wav");
        public List<Player> listOfPlayers = new List<Player>();
        #endregion
        public FormLogin()
        {
            InitializeComponent();
        }

        #region METHODS
        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: Cek dan load file
            /*
            try
            {
                GameUtils.LoadData(out listOfPlayers);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            */

            buttonLogin.Size = new Size(130, 43);
            buttonSignupPage.Size = new Size(164, 43);
            buttonAbout.Size = new Size(182, 42);
            buttonAbout.Location = new Point(
                    (this.ClientSize.Width - buttonAbout.Width) / 2,
                    (this.ClientSize.Height - buttonAbout.Height) / 2
                );
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // TODO: Login
            try
            {
                //!User input
                string username = textBoxUsername.Text;

                //! Login
                if (Auth.Login(username))
                {
                    soundPlayer.Stop();
                    MessageBox.Show("Berhasil Login");
                    textBoxUsername.Text = "";
                    /*
                    Form1 form = new Form1();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                    */

                    Exp exp = new Exp();
                    exp.ShowDialog();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonSignupPage_Click(object sender, EventArgs e)
        {
            FormSignUp signUp = new FormSignUp();
            soundPlayer.Stop();
            this.Hide();
            signUp.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        protected override void OnActivated(EventArgs e)
        {
            soundPlayer.PlayLooping();
        }
        #endregion
    }
}
