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

namespace HappyPetGame_160422035_160422041
{
    public partial class FormLogin : Form
    {
        public List<Player> listOfPlayers = new List<Player>();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: Cek dan load file
            try
            {
                GameUtils.LoadData(out listOfPlayers);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // TODO: Login
            try
            {
                //!User input
                string username = textBoxUsername.Text;

                //! Login
                if (GameUtils.Login(username, this))
                {
                    MessageBox.Show("Berhasil Login");
                    Form1 form = new Form1();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
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
            this.Hide();
            signUp.ShowDialog();
            this.Close();
        }
    }
}
