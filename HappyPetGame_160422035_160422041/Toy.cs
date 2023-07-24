using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422035_160422041
{
    [Serializable]
    public class Toy
    {
        #region FIELDS
        private string name;
        private int price;
        private int benefit;
        private Image picture;
        #endregion

        #region CONSTRUCTOR
        public Toy(string name, int price, int benefit, Image picture)
        {
            this.Name = name;
            this.Price = price;
            this.Benefit = benefit;
            this.Picture = picture;
        }
        #endregion

        #region PROPERTIES
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Benefit { get => benefit; set => benefit = value; }
        public Image Picture { get => picture; set => picture = value; }
        #endregion

        #region METHODS
        public string DisplayData()
        {
            string data = this.Name +
                          "\n" + this.Price + " coins" +
                          "\n" + this.Benefit + " %";

            return data;
        }
        #endregion
    }
}