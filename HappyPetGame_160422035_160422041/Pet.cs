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
        private string health;
        private string energy;
        private string happiness;
        private Image picture;
        private Player player;
        private List<Toy> listOfToys;

        //! For PET DEFENDER MODE
        private int healthPoint;
        private int levelAttack1;
        private int damageAttack1;
        private int levelAttack2;
        private int damageAttack2;
        private int levelAttack3;
        private int damageAttack3;
        #endregion

        #region CONSTRUCTOR
        public Pet()
        {

        }
        #endregion

        #region PROPERTIES

        #endregion

        #region METHODS

        #endregion
    }
}