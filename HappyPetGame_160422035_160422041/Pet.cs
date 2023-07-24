using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422035_160422041
{
    [Serializable]
    public abstract class Pet
    {
        #region FIELDS
        private string name;
        private int health;
        private int energy;
        private int happiness;
        private Image picture;
        //private Player player;
        private List<Toy> listOfToys;
        #endregion

        #region CONSTRUCTOR
        public Pet(string name, Image picture)
        {
            this.Name = name;
            this.Health = 100;
            this.Energy = 100;
            this.Happiness = 100;
            this.Picture = picture;
            this.ListOfToys = new List<Toy>();
        }
        #endregion


        #region PROPERTIES
        public string Name { get => name; set => name = value; }
        public int Health { get => health; set => health = value; }
        public int Energy { get => energy; set => energy = value; }
        public int Happiness { get => happiness; set => happiness = value; }
        public Image Picture { get => picture; set => picture = value; }
        public List<Toy> ListOfToys { get => listOfToys; set => listOfToys = value; }

        #endregion

        #region METHODS
        public abstract void Feed(ref Player player);

        public virtual string DisplayData()
        {
            string data = this.Name +
                          "\nHealth: " + this.Health + " %" +
                          "\nEnergy: " + this.Energy + " %" +
                          "\nHappiness: " + this.Happiness + " %";

            return data;
        }

        public string GetHealthCondition()
        {
            string condition = "";

            if (this.Health > 80)
            {
                condition = "Very Good";
            }
            else if (this.Health >= 61)
            {
                condition = "Good";
            }
            else if (this.Health >= 26)
            {
                condition = "Poor";
            }
            else
            {
                condition = "Very Poor";
            }

            return condition;
        }

        public string GetEnergyCondition()
        {
            string condition = "";

            if (this.Energy >= 76)
            {
                condition = "Strong";
            }
            else if (this.Energy >= 51)
            {
                condition = "Moderate";
            }
            else
            {
                condition = "Weak";
            }

            return condition;
        }

        public string GetHappinessCondition()
        {
            string condition = "";

            if (this.Happiness >= 61)
            {
                condition = "Happy";
            }
            else
            {
                condition = "Unhappy";
            }

            return condition;
        }

        public void BuyToy(ref Player player, Toy newToy)
        {
            if (player.Coins >= newToy.Price)
            {
                this.ListOfToys.Add(newToy);
                player.Coins -= newToy.Price;
                this.Happiness += newToy.Benefit;
            }
            else
            {
                throw new ArgumentException("Not enough coins. Toy's price = " + newToy.Price);
            }
        }
        #endregion
    }
}