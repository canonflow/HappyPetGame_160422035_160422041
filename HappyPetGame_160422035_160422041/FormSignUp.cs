using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    public partial class FormSignUp : Form
    {
        #region FIELDS
        SoundPlayer soundPlayer = new SoundPlayer(@"music/wav/Title-Theme-The-Legend-of-Zelda.wav");
        public List<Player> listOfPlayers = new List<Player>();
        #endregion

        public FormSignUp()
        {
            InitializeComponent();
        }

        #region METHODS
        private void FormSignUp_Load(object sender, EventArgs e)
        {
            this.Size = new Size(395, 481);
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
            buttonLogin.Location = new Point(
                    (this.ClientSize.Width - buttonLogin.Width) / 2,
                    382
                );
        }

        private void buttonSignupPage_Click(object sender, EventArgs e)
        {
            try
            {
                //! User input
                string username = textBoxUsername.Text;

                if (Auth.SignUp(username))
                {
                    MessageBox.Show("Berhasil Membuat Player");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            FormLogin login = new FormLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        protected override void OnActivated(EventArgs e)
        {
            soundPlayer.PlayLooping();
        }
        #endregion
    }
}
