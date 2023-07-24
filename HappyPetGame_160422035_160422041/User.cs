using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    [Serializable]
    public class User
    {
        #region FIELDS
        [NonSerialized]
        private PictureBox picture = new PictureBox();
        private Image userImage;
        private bool isMove = false;
        private Point lastLocation;

        #endregion

        #region CONSTRUCTOR
        public User()
        {
            //this.Picture.Location = location;
            //this.LastLocation = location;
            //this.Picture.Tag = "user";
            //this.Picture.Image = Properties.Resources.test_gambar;
            this.UserImage = GameUtils.PLAYER_IDLE_IMAGES['S'];
        }
        #endregion

        #region PROPERTIES
        public PictureBox Picture { get => picture; set => picture = value; }
        public Image UserImage {  get => userImage; set => userImage = value; }
        public Point LastLocation { get => lastLocation; set => lastLocation = value; }
        public bool IsMove {  get => isMove; set => isMove = value; }
        #endregion

        #region METHODS
        public void Display(Control form)
        {
            Picture.Image = UserImage;
            Picture.Location = GameUtils.USER_STARTING_POINT_BEGIN;
            Picture.Tag = "user";
            Picture.Parent = form;
            Picture.SizeMode = PictureBoxSizeMode.AutoSize;
            Picture.BackColor = Color.Transparent;
            Picture.BringToFront();
        }

        public void Save()
        {
            this.Picture.Location = LastLocation;
        }

        public bool IsCollision(Boundary boundary, char dir, int range)
        {
            return GameUtils.ImportCollisionCheck(this, boundary, dir, range);
        }

        public void MoveUp(int x)
        {
            if (Picture.Top > 0)
            {
                Picture.Top -= x;
            }
        }

        public void MoveDown(int x)
        {
            if (Picture.Top + Picture.Height < Picture.Parent.ClientSize.Height)
            {
                Picture.Top += x;
            }
        }

        public void MoveRight(int x)
        {
            if (Picture.Left + Picture.Width < Picture.Parent.ClientSize.Width)
            {
                Picture.Left += x;
            }
        }

        public void MoveLeft(int x)
        {
            if (Picture.Left > 0)
            {
                Picture.Left -= x;
            }
        }

        public void SetPlayerImage(bool move, char dir)
        {
            if (move)
            {
                this.Picture.Image = GameUtils.PLAYER_RUN_IMAGES[dir];
                IsMove = true;
            }
            else
            {
                this.Picture.Image = GameUtils.PLAYER_IDLE_IMAGES[dir];
                IsMove = false;
            }

        }
        #endregion
    }
}
