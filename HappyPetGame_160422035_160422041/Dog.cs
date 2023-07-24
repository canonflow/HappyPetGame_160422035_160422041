using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422035_160422041
{
    [Serializable]
    public class Dog : Pet
    {
        #region FIELDS
        private bool vaccinateStatus;
        #endregion

        #region CONSTRUCTORS
        public Dog(string petName, Image picture) : base(petName, picture)
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
            string status = "No";

            if (VaccinateStatus == true)
            {
                status = "Yes";
            }
            return base.DisplayData() + "\n          Vaccination Status : " + status;
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

        public void Play(ref Player player, int benefit)
        {
            if (Happiness + benefit > 100)
            {
                Happiness = 100;
            }
            else
            {
               base.Happiness += benefit;
            }

            if (Energy - 30 < 0)
            {
                Energy = 0;
            }
            else
            {
                base.Energy -= 30;
            }

            player.Coins += (int)(0.5 * benefit * 100);
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

            player.Coins += (int)(0.5 * 20 * 100);
            player.Coins += (int)(0.5 * 70 * 100);
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
            if (VaccinateStatus == false)
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

                    VaccinateStatus = true;
                    player.Coins -= 1000;
                }

                else
                {
                    throw new Exception("Not enough coins. Vaccination cost = 1000 coins.");
                }
            }

            else
            {
                throw new Exception("Your pet has already been vaccinated.");
            }
        }
        #endregion
    }
}