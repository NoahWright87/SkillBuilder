using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBuilder.Skills
{
    public class Skill
    {
        public String Name { get; set; }
        public List<SkillTechnique> Techniques { get; set; }
        public ResourceAmount TotalCost
        {
            get
            {
                ResourceAmount result = new ResourceAmount();

                foreach (SkillTechnique t in Techniques)
                {
                    result += t.TotalCost;
                }

                result *= 1 + ((Techniques.Count - 1) * GameData.Current.TechniqueCostFactor);

                return result;
            }
        }

        public Skill()
        {
            Name = "";
            Techniques = new List<SkillTechnique>();
        }

        public override string ToString()
        {
            String s = "";

            //if (Techniques.Count > 0)
            //{
            //    s += "First, " + Techniques[0].ToString();
            //}
            //foreach (SkillTechnique tech in Techniques.Skip(1))
            //{
            //    s += ", then " + tech.ToString();
            //}

            String transition = "";
            String lastActor = "Player";
            String lastProjectile = "";

            //if (Techniques.Count > 0)
            //{
            //    s += Techniques[0].ToString();
            //}
            //foreach (SkillTechnique tech in Techniques.Skip(1))
            foreach (SkillTechnique tech in Techniques)
            {
                if (s.Length > 0) s += ".  ";

                s += tech.ToString(transition, lastActor, lastProjectile);

                SkillTechniqueInfo info = (SkillTechniqueInfo)tech.PartInfo;

                switch (info.TechType)
                {
                    case SkillTechniqueInfo.TechniqueType.Action:
                        //Nothing changes
                        break;
                    case SkillTechniqueInfo.TechniqueType.ActorSpawn:
                        lastActor = info.CreatedEffectDescription;
                        break;
                    case SkillTechniqueInfo.TechniqueType.ProjectileSpawn:
                        lastProjectile = info.CreatedEffectDescription;
                        break;
                }

                transition = info.TransitionDescription;

                //if (tech.TransitionDescription != null && tech.TransitionDescription.Length > 0)
                //{
                //    transition = tech.TransitionDescription;
                //}
                //if (tech.CreatedObjectDescription != null && tech.CreatedObjectDescription.Length > 0)
                //{
                //    lastActor = tech.CreatedObjectDescription;
                //}


            }

            return s;
        }

        private static String[] mod1Options = new String[] { "charges up, then", "continuously" };
        private static String[] mod2Options = new String[] { "fast", "fiery", "large, icey", "sharp" };
        private static String[] mod3Options = new String[] { "backwards", "towards enemy", "in random directions" };

        private static String[] tech1Options = new String[] { "launches a", "performs a", "spews forth a", "summons a" };
        private static String[] tech2Options = new String[] { "ball of mana", "leap", "weapon", "clone of himself" };
        private static String[] tech3Options = new String[] { "On impact", "After striking", "When he lands", "Once spawned" };

        private static String[] actorOptions = new String[] { "Player", "Summoned creature", "Trap", "Manaball" };
        private static String[] transitionOptions = new String[] { "On impact", "After striking", "When he lands", "Once spawned" };
        
        public static String GetExampleDescription(String mod1, String mod2, String mod3, String tech1, String tech2, String tech3, String lastActor, String transition)
        {
            return String.Format("{0}, {1} {2} {3} {4} {5} {6}.  {7}, some other ability happens.",
                GetRandomOptionText(transitionOptions, transition), //0
                GetRandomOptionText(actorOptions, lastActor), //1
                GetRandomOptionText(mod1Options, mod1), //2
                GetRandomOptionText(tech1Options, tech1), //3
                GetRandomOptionText(mod2Options, mod2), //4
                GetRandomOptionText(tech2Options, tech2), //5
                GetRandomOptionText(mod3Options, mod3), //6
                GetRandomOptionText(tech3Options, tech3)); //7
        }
        private static String GetRandomOptionText(String[] optionArray, String providedText)
        {
            if (providedText != null && providedText.Length > 0)
            {
                return providedText;
            }
            else
            {
                return optionArray[Program.rand.Next(optionArray.Length)];
            }
        }

        //public void Draw(Graphics g, Point mousePos)
        //{
        //    //TODO: Draw description / name / cost somewhere?
        //    if (Techniques.Count > 0)
        //    {
        //        Techniques[0].Draw(g, mousePos);
        //    }
        //}
    }
}
