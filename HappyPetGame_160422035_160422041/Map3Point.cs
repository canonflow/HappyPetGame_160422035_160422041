using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    public class Map3Point : MapPoint
    {
        #region FIELDS
        #endregion

        #region CONSTRUCTOR
        public Map3Point(int size, int x, int y, Color color) : base(size, x, y)
        {
            Picture.BackColor = color;
            Picture.Tag = "map3";
        }
        #endregion

        #region METHODS
        #endregion
    }
}
