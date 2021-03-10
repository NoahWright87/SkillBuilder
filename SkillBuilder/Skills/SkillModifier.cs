using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBuilder.Skills
{
    public class SkillModifier : SkillPart
    {
        private SkillModifierInfo ModInfo { get; set; }
        public override SkillPartInfo PartInfo
        {
            get
            {
                return ModInfo;
            }
            set
            {
                ModInfo = (SkillModifierInfo)value;
            }
        }
        //public Boolean IsDirectional { get { return (ModInfo.ModType == SkillModifierInfo.ModifierType.Directional); } }

        public SkillModifier() : base() { }
        public SkillModifier(SkillPartInfo info, uint count) : base(info, count) { }
    }
}
