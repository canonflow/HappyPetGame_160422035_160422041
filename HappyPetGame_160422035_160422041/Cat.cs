using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422035_160422041
{
    [Serializable]
    public class Cat : Pet
    {
        #region FIELDS
        private bool vaccinateStatus;
        #endregion

        #region CONSTRUCTOR
        public Cat(string name, Image picture) : base(name, picture)
        {
            VaccinateStatus = false;
        }
        #endregion

        #region PROPERTIES
        public bool VaccinateStatus { get => vaccinateStatus; set => vaccinateStatus = value; }
        #endregion

        #region METHODS
        public override string DisplayData()
        {
            /*
            string status = "No";

            if (this.VaccinateStatus)
            {
                status = "Yes";
            }
            */

            string status = (this.VaccinateStatus) ? "Yes" : "No";

            string data = base.DisplayData() + "\nVaccination Status: " + status;

            return data;
        }

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
            
            if (Energy + 30 > 100)
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
        public void Play(ref Player player)
        {
            if (Happiness + 50 > 100)
            {
                Happiness = 100;
            }
            else
            {
                base.Happiness += 50;
            }
            
            if (Energy - 30 < 0)
            {
                Energy = 0;
            }
            else
            {
                base.Energy -= 30;
            }
            player.Coins += (int)(0.5 * 50 * 100);
        }

        public void Sleep(ref Player player)
        {
            if (Happiness + 20 > 100)
            {
                Happiness = 100;
            }
            else
            {
                base.Happiness += 20;
            }

            if (Energy + 70 > 100)
            {
                Energy = 100;
            }
            else
            {
                base.Energy += 70;
            }

            player.Coins += (int)(0.5 * 70 * 100);
            player.Coins += (int)(0.5 * 20 * 100);
        }

        public void Bath(ref Player player)
        {
            if (Health + 30 > 100)
            {
                Health = 100;
            }
            else
            {
                base.Health += 30;
            }

            player.Coins += (int)(0.5 * 30 * 100);
        }

        public void Vaccinate(ref Player player)
        {
            if (this.VaccinateStatus == false)
            {
                if (player.Coins >= 1000)
                {
                    if (Health + 40 > 100)
                    {
                        Health = 100;
                    }
                    else
                    {
                        base.Health += 40;
                    }

                    if (Happiness - 10 < 0)
                    {
                        Happiness = 0;
                    }
                    else
                    {
                        base.Happiness -= 10;
                    }

                    player.Coins -= 1000;
                    this.VaccinateStatus = true;

                    player.Coins += (int)(0.5 * 40 * 100);
                }
                else
                {
                    throw new ArgumentException("Not Enough coins. Vaccination cost = 1000 coins");
                }
            }
            else
            {
                throw new ArgumentException("Your pet has already vaccinated!");
            }
        }
        #endregion
    }
}