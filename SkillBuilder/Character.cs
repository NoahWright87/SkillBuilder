using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBuilder
{
    public class Character
    {
        public String Name { get; set; }
        public List<Skills.Skill> Skills { get; set; }
        //set of passives
        //set of gear
        //set of attributes (str, dex, etc)
        public ResourceAmount Resources { get; set; }

        public Character()
        {
            this.Name = "New Character";
            this.Skills = new List<Skills.Skill>();
            this.Resources = new ResourceAmount(50, 50, 50);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
