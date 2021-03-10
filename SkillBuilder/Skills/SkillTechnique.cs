using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBuilder.Skills
{
    public class SkillTechnique : SkillPart
    {
        //private SkillTechnique next;
        private SkillTechniqueInfo TechniqueInfo { get; set; }
        public override SkillPartInfo PartInfo
        {
            get
            {
                return TechniqueInfo;
            }
            set
            {
                TechniqueInfo = (SkillTechniqueInfo)value;
            }
        }
        public List<SkillModifier> Modifiers { get; set; }
        public ResourceAmount TotalCost
        {
            get
            {
                ResourceAmount result = PartInfo.Cost;
                uint count = 0;

                foreach (SkillModifier m in Modifiers)
                {
                    result += m.PartInfo.Cost;
                    count += m.Count;
                }

                result *= 1 + (count * GameData.Current.ModifierCostFactor);

                return result;
            }
        }
        //public String AnimationDescription { get { return TechniqueInfo.AnimationDescription; } }
        //public String TransitionDescription { get { return TechniqueInfo.TransitionDescription; } }
        //public String CreatedObjectDescription { get { return TechniqueInfo.CreatedObjectDescription; } }

        public SkillTechnique() : base() { }
        public SkillTechnique(SkillTechniqueInfo info, uint count)
            : base(info, count)
        {
            this.Modifiers = new List<SkillModifier>();
        }

        //public override void Draw(Graphics g, Point mousePos)
        //{
        //    base.Draw(g, mousePos);

        //    if (next == null)
        //    {
        //        //TODO: Draw empty square
        //    }
        //    else
        //    {
        //        next.Draw(g, mousePos);
        //    }
        //}

        public override string ToString()
        {
            String s = this.TechniqueInfo.Name;

            return this.TechniqueInfo.Name;
        }

        public string ToString(String transition, String lastActor, String lastProjectile)
        {
            if (transition.Length > 0) transition += ", ";
            String objectToUse = lastProjectile;
            if (TechniqueInfo.TechType == SkillTechniqueInfo.TechniqueType.Action || lastProjectile == null || lastProjectile.Length <= 0)
            {
                objectToUse = lastActor;
            }
            if (objectToUse.Length > 0) objectToUse += " ";

            String adjectiveText = "";
            String directionText = "";
            String frequencyText = "";

            foreach (SkillModifier mod in Modifiers)
            {
                SkillModifierInfo info = (SkillModifierInfo)mod.PartInfo;
                //switch (info.ModType)
                //{
                //    case SkillModifierInfo.ModifierType.Modifier:
                //        if (adjectiveText.Length > 0) adjectiveText += ", ";
                //        adjectiveText += info.AdjectiveDescription;
                //        break;
                //    case SkillModifierInfo.ModifierType.Directional:
                //        if (directionText.Length > 0) directionText += ", ";
                //        directionText += info.DirectionDescription;
                //        break;
                //    case SkillModifierInfo.ModifierType.Frequency:
                //        if (frequencyText.Length > 0) frequencyText += ", ";
                //        frequencyText += info.FrequencyDescription;
                //        break;
                //}
                if (info.AdjectiveDescription.Length > 0)
                {
                    if (adjectiveText.Length > 0) adjectiveText += ", ";
                    adjectiveText += info.AdjectiveDescription;
                }
                if (info.DirectionDescription.Length > 0)
                {
                    if (directionText.Length > 0) directionText += ", ";
                    directionText += info.DirectionDescription;
                }
                if (info.FrequencyDescription.Length > 0)
                {
                    if (frequencyText.Length > 0) frequencyText += ", ";
                    frequencyText += info.FrequencyDescription;
                }
            }
            if (adjectiveText.Length > 0) adjectiveText += " ";
            if (frequencyText.Length > 0) frequencyText += " ";
            if (directionText.Length > 0) directionText += " ";

            


            return String.Format("{0}{1}{2}{3}{4}{5}{6}",
                transition, //0
                objectToUse, //1
                frequencyText, //2
                TechniqueInfo.AnimationDescription + ((TechniqueInfo.AnimationDescription.Length > 0) ? " " : ""), //3
                adjectiveText, //4
                TechniqueInfo.CreatedEffectDescription + ((directionText.Length > 0) ? " " : ""), //5
                directionText); //6
        }
    }
}
