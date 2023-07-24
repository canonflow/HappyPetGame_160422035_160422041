using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    public class GameId
    {
        #region FIELDS
        private PictureBox picture = new PictureBox();
        private int x;
        private int y;
        private int size;
        #endregion

        #region CONSTRUCTOR
        public GameId(int size, int x, int y, string tag)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            Picture.Width = this.size;
            Picture.Height = this.size;
            Picture.BackColor = Color.Transparent;
            Picture.Tag = tag;
        }
        #endregion

        #region PROPERTIES
        public PictureBox Picture { get => picture; set => picture = value; }
        #endregion

        #region METHODS
        public void Display(Control form)
        {
            //form.Controls.Add(Picture);
            Picture.Parent = form;
            Picture.Location = new Point(this.x * this.size, this.y * this.size);
        }
        #endregion
    }
}
