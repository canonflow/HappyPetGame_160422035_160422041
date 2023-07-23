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
    public partial class Coba : Form
    {
        Label label = new Label();
        PictureBox playerPic = new PictureBox();
        int currentMap = 1;
        bool up, right, down, left;
        public Coba()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
        }

        private void Coba_Load(object sender, EventArgs e)
        {
            MapBoundary.Init();
            label.Text = "INI LABEL";
            label.BackColor = Color.Transparent;
            label.Location = new Point(100, 100);
            label.AutoSize = true;
            label.Parent = this;
            
            playerPic.Image = Properties.Resources.test_gambar;
            playerPic.BackColor = Color.Transparent;
            playerPic.SizeMode = PictureBoxSizeMode.AutoSize;
            playerPic.Size = playerPic.Image.Size;
            //playerPic.Location = new Point((this.ClientSize.Width - playerPic.Width)/2, (this.ClientSize.Height - playerPic.Height)/2);
            playerPic.Location = new Point(500, 500);
            playerPic.Parent = this;
            playerPic.BringToFront();
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

                    if (GameUtils.IsMap2Point(mapValue))
                    {
                        Map2Point point = new Map2Point(GameUtils.SIZE_BOUNDARY, j, i);
                        point.Display(this);
                    }
                    */
                    
                    //listBox1.Items.Add(i + " " + j);
                    //listBox1.Items.Add(map[i][j]);
                }
            }
            
            
        }

        public void Init()
        {
            this.Size = new Size(960, 608);
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

        private void PlayerMovement_Tick(object sender, EventArgs e)
        {
           
        }

        private void Coba_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.W)
            {
                up = true;
            }

            if (e.KeyCode == Keys.S)
            {
                down = true;
            }

            if (e.KeyCode == Keys.A)
            {
                left = true;
            }

            if (e.KeyCode == Keys.D)
            {
                right = true;
            }
            */
            if (e.KeyCode == Keys.Right && currentMap == 1)
            {
                /*
                currentMap = 2;
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
                Map2 map2 = new Map2();
                this.Hide();
                map2.ShowDialog();
                this.Close();
            }
        }

        private void Coba_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = false;
            }

            if (e.KeyCode == Keys.S)
            {
                down = false;
            }

            if (e.KeyCode == Keys.A)
            {
                left = false;
            }

            if (e.KeyCode == Keys.D)
            {
                right = false;
            }
        }

        private void BackgroundMovement_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
