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
    public partial class Map2 : Form
    {
        int currentMap = 2;
        public Map2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
        }

        private void Map2_Load(object sender, EventArgs e)
        {
            MapBoundary.Init();
            Init();
            LoadMap();
            DisplayBoundaries();
        }

        private void DisplayBoundaries()
        {
            List<List<long>> map = null;

            if (currentMap == 1)
            {
                map = MapBoundary.ImportMap1();
            }
            else if (currentMap == 2)
            {
                map = MapBoundary.ImportMap2();
            }
            else if (currentMap == 3)
            {
                map = MapBoundary.ImportMap3();
            }

            for (int i = 0; i < map.Count; i++)
            {
                for (int j = 0; j < map[i].Count; j++)
                {

                    long mapValue = map[i][j];
                    /*
                    if (GameUtils.IsBoundary(mapValue))
                    {
                        Boundary boundary = new Boundary(GameUtils.SIZE_BOUNDARY, j, i);
                        boundary.Display(this);
                    }

                    if (GameUtils.IsMap1Point(mapValue))
                    {
                        Map1Point point = new Map1Point(GameUtils.SIZE_BOUNDARY, j, i);
                        point.Display(this);
                    }

                    if (GameUtils.IsMap3Point(mapValue))
                    {
                        Map3Point point = new Map3Point(GameUtils.SIZE_BOUNDARY, j, i);
                        point.Display(this);
                    }
                    */

                }
            }


        }

        public void Init()
        {
            this.Size = new Size(960, 608);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadMap()
        {
            if (currentMap == 1)
            {
                this.BackgroundImage = Properties.Resources.mapFinalBener_1;
            }
            else if (currentMap == 2)
            {
                this.BackgroundImage = Properties.Resources.mapFinalBener_2;
            }
            else if (currentMap == 3)
            {
                this.BackgroundImage = Properties.Resources.mapFinalBener_3;
            }
        }

        private void Map2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && currentMap == 2)
            {
                /*
                currentMap = 1;
                foreach (Control control in this.Controls)
                {
                    if (control is PictureBox && (string)control.Tag == "boundary")
                    {
                        this.Controls.Remove(control);
                    }
                }
                LoadMap();
                DisplayBoundaries();
                */
                Coba map1 = new Coba();
                this.Hide();
                map1.ShowDialog();
                this.Close();
            }
        }

        private void Map2_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
