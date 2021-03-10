using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBuilder
{
    public class ResourceAmount
    {
        public float health;
        public float mana;
        public float stamina;

        public ResourceAmount() : this(0, 0, 0) { }
        public ResourceAmount(float health, float mana, float stamina)
        {
            this.health = health;
            this.mana = mana;
            this.stamina = stamina;
        }

        public override string ToString()
        {
            String returnString = "";

            if (this.health > 0)
            {
                returnString += health + " Health";
            }
            if (this.mana > 0)
            {
                if (returnString.Length > 0)
                {
                    returnString += ", ";
                }
                returnString += mana + " Mana";
            }
            if (this.stamina > 0)
            {
                if (returnString.Length > 0)
                {
                    returnString += ", ";
                }
                returnString += stamina + " Stamina";
            }
            if (returnString.Length <= 0)
            {
                returnString = "Nothing";
            }

            return returnString;
        }

        public static ResourceAmount operator +(ResourceAmount rc1, ResourceAmount rc2)
        {
            return new ResourceAmount(rc1.health + rc2.health,
                                    rc1.mana + rc2.mana,
                                    rc1.stamina + rc2.stamina);
        }
        public static ResourceAmount operator *(ResourceAmount rc, float num)
        {
            return new ResourceAmount(rc.health * num, rc.mana * num, rc.stamina * num);
        }
    }
}
