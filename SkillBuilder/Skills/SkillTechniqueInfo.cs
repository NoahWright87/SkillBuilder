using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBuilder.Skills
{
    public class SkillTechniqueInfo : SkillPartInfo
    {
        public enum TechniqueType
        {
            Action,
            ProjectileSpawn,
            ActorSpawn
        }

        public TechniqueType TechType { get; set; }

        public String AnimationDescription { get { return Description; } }
        public String CreatedEffectDescription { get { return Description2; } }
        public String TransitionDescription { get { return Description3; } }


        //public String TransitionDescription { get; set; }
        //public String AnimationDescription { get; set; }
        //public String CreatedObjectDescription { get; set; }

        public SkillTechniqueInfo()
            : base("<NEW TECHNIQUE>", "", "", "", new ResourceAmount(0, 0, 0))
        {

        }
    }
}
