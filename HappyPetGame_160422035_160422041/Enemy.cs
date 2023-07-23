using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    public class Enemy
    {
        /*! Notes
         * Level ikut dengan BattlePet yang dilawan
         
         */
        #region FIELDS
        private string name;
        private PictureBox picture;
        private int hp;
        private int level;
        private int type;
        private int damage;
        private int ultimate;
        #endregion

        #region CONSTRUCTOR
        public Enemy(string name, int level, int baseDamage, int baseHp, int baseUlti, PictureBox image, int type = 99)
        {
            this.Name = name;
            this.Picture = image;
            this.Hp = baseHp + (GameUtils.ENEMY_HP_UPGRADE * (this.Level - 1));
            this.Level = level;
            if (type == 99)
            {
                this.Type = new Random().Next(7);
            }
            else
            {
                this.Type = type;
            }
            this.Damage = baseDamage + (GameUtils.ENEMY_DAMAGE_UPGRADE * (this.Level - 1));
            this.Ultimate = baseUlti + (GameUtils.ENEMY_ULTI_UPGRADE * (this.Level - 1));
        }

        #endregion

        #region PROPERTIES
        public string Name { get => name; set => name = value; }
        public PictureBox Picture { get => picture; set => picture = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Level { get => level; set => level = value; }
        public int Type { get => type; set => type = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Ultimate { get => ultimate; set => ultimate = value; }
        #endregion

        #region METHODS
        public string GetTypeName()
        {
            return GameUtils.TypeID[this.Type];
        }

        public int Attack(BattlePet pet)
        {
            int damage = this.Damage;
            if (this.Type == 0)
            {
                // !Stong 
                if (pet.Type == 1)
                {
                    damage += new Random().Next(10, 21);
                }
                //! Weak
                else if (pet.Type == 6)
                {
                    damage -= new Random().Next(10, 21);
                }
            }
            else if (this.Type == 1)
            {
                // !Stong 
                if (pet.Type == 2)
                {
                    damage += new Random().Next(10, 21);
                }
                //! Weak
                else if (pet.Type == 0)
                {
                    damage -= new Random().Next(10, 21);
                }
            }
            else if (this.Type == 2)
            {
                // !Stong 
                if (pet.Type == 3)
                {
                    damage += new Random().Next(10, 21);
                }
                //! Weak
                else if (pet.Type == 1)
                {
                    damage -= new Random().Next(10, 21);
                }
            }
            else if (this.Type == 3)
            {
                // !Stong 
                if (pet.Type == 4)
                {
                    damage += new Random().Next(10, 21);
                }
                //! Weak
                else if (pet.Type == 2)
                {
                    damage -= new Random().Next(10, 21);
                }
            }
            else if (this.Type == 4)
            {
                // !Stong 
                if (pet.Type == 5)
                {
                    damage += new Random().Next(10, 21);
                }
                //! Weak
                else if (pet.Type == 3)
                {
                    damage -= new Random().Next(10, 21);
                }
            }
            else if (this.Type == 5)
            {
                // !Stong 
                if (pet.Type == 6)
                {
                    damage += new Random().Next(10, 21);
                }
                //! Weak
                else if (pet.Type == 4)
                {
                    damage -= new Random().Next(10, 21);
                }
            }
            else if (this.Type == 6)
            {
                // !Stong 
                if (pet.Type == 0)
                {
                    damage += new Random().Next(10, 21);
                }
                //! Weak
                else if (pet.Type == 5)
                {
                    damage -= new Random().Next(10, 21);
                }
            }

            return damage;
        }

        public int UltimateDamage(BattlePet pet)
        {
            int damage = this.Ultimate;
            if (this.Type == 0)
            {
                // !Stong 
                if (pet.Type == 1)
                {
                    damage += new Random().Next(50, 71);
                }
                //! Weak
                else if (pet.Type == 6)
                {
                    damage -= new Random().Next(50, 71);
                }
            }
            else if (this.Type == 1)
            {
                // !Stong 
                if (pet.Type == 2)
                {
                    damage += new Random().Next(50, 71);
                }
                //! Weak
                else if (pet.Type == 0)
                {
                    damage -= new Random().Next(50, 71);
                }
            }
            else if (this.Type == 2)
            {
                // !Stong 
                if (pet.Type == 3)
                {
                    damage += new Random().Next(50, 71);
                }
                //! Weak
                else if (pet.Type == 1)
                {
                    damage -= new Random().Next(50, 71);
                }
            }
            else if (this.Type == 3)
            {
                // !Stong 
                if (pet.Type == 4)
                {
                    damage += new Random().Next(50, 71);
                }
                //! Weak
                else if (pet.Type == 2)
                {
                    damage -= new Random().Next(50, 71);
                }
            }
            else if (this.Type == 4)
            {
                // !Stong 
                if (pet.Type == 5)
                {
                    damage += new Random().Next(50, 71);
                }
                //! Weak
                else if (pet.Type == 3)
                {
                    damage -= new Random().Next(50, 71);
                }
            }
            else if (this.Type == 5)
            {
                // !Stong 
                if (pet.Type == 6)
                {
                    damage += new Random().Next(50, 71);
                }
                //! Weak
                else if (pet.Type == 4)
                {
                    damage -= new Random().Next(50, 71);
                }
            }
            else if (this.Type == 6)
            {
                // !Stong 
                if (pet.Type == 0)
                {
                    damage += new Random().Next(50, 71);
                }
                //! Weak
                else if (pet.Type == 5)
                {
                    damage -= new Random().Next(50, 71);
                }
            }

            return damage;
        }
        #endregion
    }
}
