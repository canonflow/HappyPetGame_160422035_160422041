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
    public partial class FormSignUp : Form
    {
        public List<Player> listOfPlayers = new List<Player>();

        public FormSignUp()
        {
            InitializeComponent();
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
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
        }

        private void buttonSignup_Click(object sender, EventArgs e)
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

        private void buttonLoginPage_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
