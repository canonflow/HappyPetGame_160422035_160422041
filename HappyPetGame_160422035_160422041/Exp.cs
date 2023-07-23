using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    public partial class Exp : Form
    {
        int currentMap = 1;
        bool render = true;
        bool run = false;
        bool change = false;

        char lastPress = 'W';
        bool move;
        List<Boundary> listOfBoundaries = new List<Boundary>();
        List<MapPoint> listOfMapPoints = new List<MapPoint>();  // !Biar loopingnya dikit
        User user;
        Panel panel;

        Dictionary<char, Dictionary<string, bool>> keys = GameUtils.ImportKeys();
        public Exp()
        {
            MapBoundary.Init();
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            Init();
            LoadMap();
            panel = new Panel();
            panel.Location = new Point(0, 0);
            panel.Size = this.Size;
            panel.BackgroundImage = Properties.Resources.Loading;
            panel.Parent = this;
            user = new User(new Point(420, 200));
            user.Display(this);
            panel.BringToFront();
        }
        public void Init()
        {
            this.Size = new Size(960+16, 608+30);
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

                    if (GameUtils.IsBoundary(mapValue))
                    {
                        Boundary boundary = new Boundary(GameUtils.SIZE_BOUNDARY, j, i);
                        Invoke(new Action(() => boundary.Display(this)));
                        Invoke(new Action(() => listOfBoundaries.Add(boundary)));
                        //boundary.Display(this);
                    }

                    MapPoint point = null;

                    if (GameUtils.IsMap1Point(mapValue))
                    {
                        point = new Map1Point(GameUtils.SIZE_BOUNDARY, j, i, Color.Blue);
                        Invoke(new Action(() => point.Display(this)));
                    }

                    if (GameUtils.IsMap2Point(mapValue))
                    {
                        point = new Map2Point(GameUtils.SIZE_BOUNDARY, j, i, Color.Purple);
                        Invoke(new Action(() => point.Display(this)));
                        //point.Display(this);
                    }

                    if (GameUtils.IsMap3Point(mapValue))
                    {
                        point = new Map3Point(GameUtils.SIZE_BOUNDARY, j, i, Color.Orange);
                        Invoke(new Action(() => point.Display(this)));
                    }

                    if (point != null)
                    {
                        Invoke(new Action(() => listOfMapPoints.Add(point)));
                    }

                    //listBox1.Items.Add(i + " " + j);
                    //listBox1.Items.Add(map[i][j]);
                }
            }
        }

        private void RemoveBoundaries()
        {
            List<Control> controlsToRemove = new List<Control>();
            foreach (Control control in this.Controls)
            {
                if (
                    control is PictureBox && (string)control.Tag == "boundary" ||
                    control is PictureBox && (string)control.Tag == "map1" ||
                    control is PictureBox && (string)control.Tag == "map2" ||
                    control is PictureBox && (string)control.Tag == "map3"
                )
                {
                    controlsToRemove.Add(control);
                }
            }

            foreach (Control control in controlsToRemove)
            {
                Invoke(new Action(() => this.Controls.Remove(control)));
            }

            Invoke(new Action(() => listOfBoundaries = new List<Boundary>()));
            Invoke(new Action(() => listOfMapPoints = new List<MapPoint>()));
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            //TODO: Bersihin Boundaries karena ada perpindahan MAP
            //! Kalo lagi RemoveBoundaries TIDAK BOLEH pindah MAP, klo nggak bakal ngebug
            if (change)
            {
                LoadMap();
                await GameUtils.Render(RemoveBoundaries);
                change = false;
                render = true;
                //await GameUtils.Render(DisplayBoundaries);
            }

            //if (change) return;

            //TODO: Setelah bersihin, render Boundaries beru berdasarkan MAP baru
            if (render)
            {
                //await Render2(DisplayBoundaries);
                await GameUtils.Render(DisplayBoundaries);
                render = false;
                panel.Dispose();  //! Hapus Panel Loading
            }

            // TODO: Kalo masih render Boundaries baru, DITUNGGU
            if (render) return;

            this.Text = "( " + user.Picture.Left + " , " + user.Picture.Top + " )";
            move = true;

            #region PLAYER CONTROL
            // TODO: Cek Key apa yang terakhir ditekan dan check apakah AKAN bertabrakan dengan BOUND sesuai dengan arah-nya
            if (keys['W']["pressed"] && lastPress == 'W')
            {
                /*
                foreach (Boundary boundary in listOfBoundaries)
                {
                    if (user.IsCollision(boundary, lastPress, GameUtils.MARGIN_ERROR))
                    {
                        move = false;
                        break;
                    }
                }*/
                
                await GameUtils.Render(() =>
                {
                    foreach (Boundary boundary in listOfBoundaries)
                    {
                        if (user.IsCollision(boundary, lastPress, GameUtils.MARGIN_ERROR))
                        {
                            move = false;
                            break;
                        }
                    }
                });
                


                if (move)
                {
                    user.MoveUp(GameUtils.PLAYER_MOVEMENT);
                }

            }
            else if (keys['A']["pressed"] && lastPress == 'A')
            {

                await GameUtils.Render(CollisionDetection);

                if (move)
                {
                    user.MoveLeft(GameUtils.PLAYER_MOVEMENT);
                }

            }
            else if (keys['S']["pressed"] && lastPress == 'S')
            {
                await GameUtils.Render(CollisionDetection);


                if (move)
                {
                    user.MoveDown(GameUtils.PLAYER_MOVEMENT);
                }

            }
            else if (keys['D']["pressed"] && lastPress == 'D')
            {
                await GameUtils.Render(CollisionDetection);


                if (move)
                {
                    user.MoveRight(GameUtils.PLAYER_MOVEMENT);
                }

            }

            #endregion

            #region MAP SWITCH
            foreach (MapPoint point in listOfMapPoints)
            {
                if (user.Picture.Bounds.IntersectsWith(point.Picture.Bounds))
                {
                    //! Kalo point tersebut menuju ke point 1 
                    if (point is Map1Point)
                    {
                        Map1Point newPoint = (Map1Point)point;
                        //TODO: Pindah dari map 2 ke map 1
                        if (currentMap == 2)
                        {
                            currentMap = 1;
                            user.Picture.Location = GameUtils.UserNextLocation(2, 1);
                            change = true;  //! Ganti MAP buat trigger di timer
                            panel = new Panel();
                            panel.Size = this.Size;
                            panel.Location = new Point(0, 0);
                            panel.BackColor = Color.LightGray;
                            panel.Parent = this;
                            panel.BringToFront();
                        }
                    }
                    else if (point is Map2Point)
                    {
                        Map2Point nePoint = (Map2Point)point;

                        //TODO: Pindah dari map 1 ke map 2
                        if (currentMap == 1)
                        {
                            currentMap = 2;
                            user.Picture.Location = GameUtils.UserNextLocation(1, 2);
                            change = true;  //! Ganti MAP buat trigger di timer
                            panel = new Panel();
                            panel.Size = this.Size;
                            panel.Location = new Point(0, 0);
                            panel.BackColor = Color.LightGray;
                            panel.Parent = this;
                            panel.BringToFront();
                        }
                        //TODO: Pindah dari map 3 ke map 2
                        else if (currentMap == 3)
                        {
                            currentMap = 2;
                            change = true;  //! Ganti MAP buat trigger di timer
                            user.Picture.Location = GameUtils.UserNextLocation(3, 2);
                            panel = new Panel();
                            panel.Size = this.Size;
                            panel.Location = new Point(0, 0);
                            panel.BackColor = Color.LightGray;
                            panel.Parent = this;
                            panel.BringToFront();
                        }
                    }
                    else if (point is Map3Point)
                    {
                        Map3Point newPoint = (Map3Point)point;
                        //TODO: Pindah dari map 2 ke map 3
                        if (currentMap == 2)
                        {
                            currentMap = 3;
                            user.Picture.Location = GameUtils.UserNextLocation(2, 3);
                            change = true;  //! Ganti MAP buat trigger di timer
                            panel = new Panel();
                            panel.Size = this.Size;
                            panel.Location = new Point(0, 0);
                            panel.BackColor = Color.LightGray;
                            panel.Parent = this;
                            panel.BringToFront();
                        }
                    }

                }
            }
            #endregion
        }

        #region GAME KEY DOWN
        private void Exp_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    keys['W']["pressed"] = true;
                    lastPress = 'W';
                    break;
                case Keys.A:
                    keys['A']["pressed"] = true;
                    lastPress = 'A';
                    break;
                case Keys.S:
                    keys['S']["pressed"] = true;
                    lastPress = 'S';
                    break;
                case Keys.D:
                    keys['D']["pressed"] = true;
                    lastPress = 'D';
                    break;
            }

        }
        #endregion

        #region GAME KEY UP
        private void Exp_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (move && lastPress == 'W')
                    {
                        keys['W']["pressed"] = false;
                    }
                    break;
                case Keys.A:
                    if (move && lastPress == 'A')
                    {
                        keys['A']["pressed"] = false;
                    }
                    break;
                case Keys.S:
                    if (move && lastPress == 'S')
                    {
                        keys['S']["pressed"] = false;
                    }
                    break;
                case Keys.D:
                    if (move && lastPress == 'D')
                    {
                        keys['D']["pressed"] = false;
                    }
                    break;
            }
        }
        #endregion

        #region COLLISIONS DETECTION
        private void CollisionDetection()
        {
            foreach (Boundary boundary in listOfBoundaries)
            {
                if (user.IsCollision(boundary, lastPress, GameUtils.MARGIN_ERROR))
                {
                    move = false;
                    break;
                }
            }
        }
        #endregion
    }
}
