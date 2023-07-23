using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyPetGame_160422035_160422041
{
    public class Skill
    {
        #region FIELDS
        private string name;
        private int type;
        private int damage;
        private int skillLevel;
        #endregion

        #region CONSTRUCTOR
        public Skill(string name, int type, int damage)
        {
            this.Name = name;
            this.Type = type;
            this.Damage = damage;
            this.SkillLevel = 1;  //! Default
        }
        #endregion

        #region PROPERTIES
        public string Name { get => name; set => name = value; }
        public int Type { get => type; set => type = value; }
        public int Damage { get => damage; set => damage = value; }
        public int SkillLevel { get => skillLevel; set => skillLevel = value; }
        #endregion

        #region METHODS
        public void UpgradeLevel()
        {
            this.SkillLevel++;  //! +1
            this.Damage += GameUtils.SKILL_DAMAGE_FOR_UPGRADE;  //! +5
        }

        public string GetSkillTypeName()
        {
            return GameUtils.TypeID[this.Type];
        }
        #endregion
    }
}
