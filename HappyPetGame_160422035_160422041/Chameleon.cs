using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422035_160422041
{
    [Serializable]
    public class Chameleon : Pet
    {
        #region FIELDS
        private Color currentColor;
        #endregion

        #region CONSTRUCTOR
        public Chameleon(string name, Image picture, Color currentColor) : base(name, picture)
        {
            this.CurrentColor = currentColor;
        }
        #endregion

        #region PROPERTIES
        public Color CurrentColor { get => currentColor; set => currentColor = value; }
        #endregion

        #region METHODS
        public override void Feed(ref Player player)
        {
            if (Health + 30 > 100)
            {
                Health = 100;
            }
            else
            {
                base.Health += 30;
            }

            if (Energy + 50 > 100)
            {
                Energy = 100;
            }
            else
            {
                base.Energy += 50;
            }

            player.Coins += (int)(0.5 * 30 * 100);
            player.Coins += (int)(0.5 * 50 * 100);
        }

        public override string DisplayData()
        {
            string data = base.DisplayData() +
                           "\nCurrent Color: " + this.CurrentColor + "\n";

            return data;
        }

        public void Sleep(ref Player player)
        {
            if (Health + 60 > 100)
            {
                Health = 100;
            }
            else
            {
                base.Health += 60;
            }

            if (Energy + 60 > 100)
            {
                Energy = 100;
            }
            else
            {
                base.Energy += 60;
            }

            player.Coins += (int)(0.5 * 60 * 100);
            player.Coins += (int)(0.5 * 60 * 100);
        }
        public void ChangeColor(Color newColor)
        {
            this.CurrentColor = newColor;
        }
        #endregion
    }
}