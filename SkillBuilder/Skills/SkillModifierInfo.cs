using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBuilder.Skills
{
    public class SkillModifierInfo : SkillPartInfo
    {
        public enum ModifierType
        {
            Frequency,
            Modifier,
            Directional
        }
        public ModifierType ModType { get; set; }

        public String FrequencyDescription { get { return Description; } }
        public String AdjectiveDescription { get { return Description2; } }
        public String DirectionDescription { get { return Description3; } }

        public SkillModifierInfo()
            : base("<NEW MODIFIER>", "", "", "", new ResourceAmount(0, 0, 0))
        {

        }
    }
}
