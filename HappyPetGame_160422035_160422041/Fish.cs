using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422035_160422041
{
    [Serializable]
    public class Fish : Pet
    {
         #region FIELDS
        private string environment;

        #endregion

        #region CONSTRUCTOR
        public Fish(string name, Image picture, string environment) : base(name, picture)
        {
            this.Environment = environment;
        }
        #endregion

        #region PROPERTIES
        public string Environment { get => environment; set => environment = value; }
        #endregion

        #region METHODS
        public override void Feed(ref Player player)
        {
            if (Health + 20 > 100)
            {
                Health = 100;
            }
            else
            {
                base.Health += 20;
            }

            if (Energy + 40 > 100)
            {
                Energy = 100;
            }
            else
            {
                base.Energy += 40;
            }

            player.Coins += (int)(0.5 * 20 * 100);
            player.Coins += (int)(0.5 * 40 * 100);
        }

        public override string DisplayData()
        {
            string data = base.DisplayData() +
                          "\nEnvironment: " + this.Environment + "\n";

            return data;
        }

        public void Clean(ref Player player)
        {
            if (player.Coins >= 500)
            {
                if (Health + 60 > 100)
                {
                    Health = 100;
                }
                else
                {
                    base.Health += 60;
                }

                if (Happiness + 50 > 100)
                {
                    Happiness = 100;
                }
                else
                {
                    base.Happiness += 50;
                }

                player.Coins -= 500;

                player.Coins += (int)(0.5 * 60 * 100);
                player.Coins += (int)(0.5 * 50 * 100);
            }
            else
            {
                throw new ArgumentException("Not Enough coins.Clean cost = 500 coins");
            }
        }
        #endregion
    }
}