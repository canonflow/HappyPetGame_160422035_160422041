using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    public abstract class MapPoint
    {
        #region FIELDS
        private PictureBox picture = new PictureBox();
        private int x;
        private int y;
        private int size;
        #endregion

        #region CONSTRUCTOR
        public MapPoint(int size, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            Picture.Width = this.size;
            Picture.Height = this.size;
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
