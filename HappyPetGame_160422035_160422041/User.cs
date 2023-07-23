using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    public class User
    {
        #region FIELDS
        private PictureBox picture = new PictureBox();
        private bool isMove = false;

        #endregion

        #region CONSTRUCTOR
        public User(Point location)
        {
            this.Picture.Location = location;
            this.Picture.Tag = "user";
            this.Picture.Image = Properties.Resources.test_gambar;
        }
        #endregion

        #region PROPERTIES
        public PictureBox Picture { get => picture; set => picture = value; }
        public bool IsMove {  get => isMove; set => isMove = value; }
        #endregion

        #region METHODS
        public void Display(Control form)
        {
            Picture.Parent = form;
            Picture.SizeMode = PictureBoxSizeMode.AutoSize;
            Picture.BackColor = Color.Transparent;
            Picture.BringToFront();
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
        #endregion
    }
}
