using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    [Serializable]
    public class BattlePet
    {
        /*!NOTES
            Jika level diupgrade, maka ultimate juga diupgrade (+10)
            HP: 480<= x <= 220 [Random]
            Type: 0 -> 6 [Random]
            Ultimate: 120 <= x <= 150 [Random]

            Ganti skill [Random] dan level skill-nya jadi 1 [kereset]
         */
        #region FIELDS
        private string name;
        //private PictureBox picture = new PictureBox();
        private Image petImage;
        private int hp;
        private int level;
        private int type;
        private Skill petSkill;
        private int ultimate;
        #endregion

        #region CONSTRUCTOR
        public BattlePet(string name, Image image)
        {
            this.Name = name;
            /*
            this.Picture.Image = image;
            this.Picture.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Picture.Tag = "Battle Pet";
            this.Picture.BackColor = Color.Transparent;
            */
            this.PetImage = image;
            //! HP: 480= x <= 520
            this.Hp = new Random().Next(480, 521);
            this.Level = 1;
            //! Type: 0 -> 6
            this.Type = new Random().Next(7);
            this.PetSkill = GameUtils.LIST_OF_SKILLS[new Random().Next(GameUtils.LIST_OF_SKILLS.Count)];
            //! Ultimate: 120 <= x <= 150
            this.Ultimate = new Random().Next(120, 151);
        }
        #endregion

        #region PROPERTIES
        public string Name { get => name; set => name = value; }
        //public PictureBox Picture { get => picture; set => picture = value; }
        public Image PetImage { get => petImage; set => petImage = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Level { get => level; set => level = value; }
        public int Type { get => type; set => type = value; }
        public Skill PetSkill { get => petSkill; set => petSkill = value; }
        public int Ultimate { get => ultimate; set => ultimate = value; }
        #endregion

        #region METHODS
        public void Upgrade()
        {
            this.Level++;  //! +1
            this.Ultimate += GameUtils.ULTIMATE_FOR_UPGRADE;  //! +10
            this.Hp += GameUtils.HP_UPGRADE;
            this.PetSkill.UpgradeLevel();
        }

        public string GetTypeName()
        {
            return GameUtils.TypeID[this.Type];
        }

        public void ChangeSkill()
        {
            this.PetSkill = GameUtils.LIST_OF_SKILLS[new Random().Next(0, 7)];
        }

        public int Attack(Enemy enemy)
        {
            int damage = this.PetSkill.Damage;
            if (this.PetSkill.Type == 0)
            {
                // !Stong 
                if (enemy.Type == 1)
                {
                    damage += new Random().Next(10, 21);
                }
                //! Weak
                else if (enemy.Type == 6)
                {
                    damage -= new Random().Next(10, 21);
                }
            }
            else if (this.PetSkill.Type == 1)
            {
                // !Stong 
                if (enemy.Type == 2)
                {
                    damage += new Random().Next(10, 21);
                }
                //! Weak
                else if (enemy.Type == 0)
                {
                    damage -= new Random().Next(10, 21);
                }
            }
            else if (this.PetSkill.Type == 2)
            {
                // !Stong 
                if (enemy.Type == 3)
                {
                    damage += new Random().Next(10, 21);
                }
                //! Weak
                else if (enemy.Type == 1)
                {
                    damage -= new Random().Next(10, 21);
                }
            }
            else if (this.PetSkill.Type == 3)
            {
                // !Stong 
                if (enemy.Type == 4)
                {
                    damage += new Random().Next(10, 21);
                }
                //! Weak
                else if (enemy.Type == 2)
                {
                    damage -= new Random().Next(10, 21);
                }
            }
            else if (this.PetSkill.Type == 4)
            {
                // !Stong 
                if (enemy.Type == 5)
                {
                    damage += new Random().Next(10, 21);
                }
                //! Weak
                else if (enemy.Type == 3)
                {
                    damage -= new Random().Next(10, 21);
                }
            }
            else if (this.PetSkill.Type == 5)
            {
                // !Stong 
                if (enemy.Type == 6)
                {
                    damage += new Random().Next(10, 21);
                }
                //! Weak
                else if (enemy.Type == 4)
                {
                    damage -= new Random().Next(10, 21);
                }
            }
            else if (this.PetSkill.Type == 6)
            {
                // !Stong 
                if (enemy.Type == 0)
                {
                    damage += new Random().Next(10, 21);
                }
                //! Weak
                else if (enemy.Type == 5)
                {
                    damage -= new Random().Next(10, 21);
                }
            }

            return damage;
        }

        public int UltimateDamage(Enemy enemy)
        {
            int damage = this.Ultimate;

            if (this.Type == 0)
            { 
                //! Strong
                if (enemy.Type == 1)
                {
                    damage += new Random().Next(50, 71);
                }
                //! Weak
                else if (enemy.Type == 6)
                {
                    damage -= new Random().Next(50, 70);
                }
            }
            else if (this.Type == 1)
            {
                //! Strong
                if (enemy.Type == 2)
                {
                    damage += new Random().Next(50, 71);
                }
                //! Weak
                else if (enemy.Type == 0)
                {
                    damage -= new Random().Next(50, 70);
                }
            }
            else if (this.Type == 2)
            {
                //! Strong
                if (enemy.Type == 3)
                {
                    damage += new Random().Next(50, 71);
                }
                //! Weak
                else if (enemy.Type == 1)
                {
                    damage -= new Random().Next(50, 70);
                }
            }
            else if (this.Type == 3)
            {
                //! Strong
                if (enemy.Type == 4)
                {
                    damage += new Random().Next(50, 71);
                }
                //! Weak
                else if (enemy.Type == 2)
                {
                    damage -= new Random().Next(50, 70);
                }
            }
            else if (this.Type == 4)
            {
                //! Strong
                if (enemy.Type == 5)
                {
                    damage += new Random().Next(50, 71);
                }
                //! Weak
                else if (enemy.Type == 3)
                {
                    damage -= new Random().Next(50, 70);
                }
            }
            else if (this.Type == 5)
            {
                //! Strong
                if (enemy.Type == 6)
                {
                    damage += new Random().Next(50, 71);
                }
                //! Weak
                else if (enemy.Type == 4)
                {
                    damage -= new Random().Next(50, 70);
                }
            }
            else if (this.Type == 6)
            {
                //! Strong
                if (enemy.Type == 0)
                {
                    damage += new Random().Next(50, 71);
                }
                //! Weak
                else if (enemy.Type == 5)
                {
                    damage -= new Random().Next(50, 70);
                }
            }

            return damage;
        }
        #endregion
    }
}
