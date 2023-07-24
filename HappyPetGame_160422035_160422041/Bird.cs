using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422035_160422041
{
    [Serializable]
    public class Bird : Pet
    {
        #region FIELDS
        private bool fly;
        private bool vaccinateStatus;
        #endregion

        #region CONSTRUCTORS
        public Bird(string petName, Image picture) : base(petName, picture)
        {
            Fly = false;
            VaccinateStatus = false;
        }
        #endregion

        #region PROPERTIES
        public bool Fly { get => fly; set => fly = value; }
        public bool VaccinateStatus { get => vaccinateStatus; set => vaccinateStatus = value; }
        #endregion

        #region METHODS
        public override string DisplayData()
        {
            string flyState = "On Foot";

            if (Fly == true)
            {
                flyState += "Flying";
            }
            return base.DisplayData() + "\n          Flying State : " + flyState;
        }

        public override void Feed(ref Player player)
        {
            if (Health + 10 > 100)
            {
                Health = 100;
            }
            else
            {
                Health += 10;
            }
            
            if (Energy + 20 > 100)
            {
                Energy = 100;
            }
            else
            {
                base.Energy += 20;
            }

            player.Coins += (int)(0.5 * 10 * 100);
            player.Coins += (int)(0.5 * 20 * 100);
        }

        public void Play(ref Player player)
        {
            if (Fly == false)
            {
                if (player.Coins >= 5000)
                {
                    if (Happiness + 40 > 100)
                    {
                        Happiness = 100;
                    }
                    else
                    {
                        Happiness += 40;
                    }
                    
                    if (Energy - 70 < 0)
                    {
                        Energy = 0;
                    }
                    else
                    {
                        base.Energy -= 70;
                    }

                    Fly = true;
                    player.Coins += (int)(0.5 * 40 * 100);
                }

                else
                {
                    throw new Exception("Not enough coins. Playing cost = 5000 coins.");
                }
            }

            else
            {
                throw new Exception("Your pet has already been played.");
            }
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
                    Health += 60;
                }

                if (Happiness + 50 > 100)
                {
                    Happiness = 100;
                }
                else
                {
                    Happiness += 50;
                }

                player.Coins -= 500;
                player.Coins += (int)(0.5 * 60 * 100);
                player.Coins += (int)(0.5 * 50 * 100);
            }

            else
            {
                throw new Exception("Not enough coins. Cleaning cost 500 coins.");
            }
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