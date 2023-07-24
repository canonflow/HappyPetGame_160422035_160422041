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
    public partial class FormToyShop : Form
    {
        HappyPetGame happyPetGame;
        Toy newToy;
        string name = "";
        int price = 0;
        int benefit = 0;
        Image picture;
        public FormToyShop()
        {
            InitializeComponent();
        }

        private void FormToyShop_Load(object sender, EventArgs e)
        {
            happyPetGame = (HappyPetGame)this.Owner;
        }
    }
}
