using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SkillBuilder
{
    class Skill
    {
        string name; //given by the user
        SkillPiece firstPiece;
        
        public Skill()
        {
            firstPiece = new SkillPiece(Skills.BASIC_ATTACK);
        }

        public void Draw(Graphics g)
        {
            firstPiece.Draw(g);
        }

        public int Complexity
        {
            get
            {
                //TODO: Determine complexity of a skill
                return 0;
            }
        }
    }

    class Skills
    {
        public const SkillInfo BASIC_ATTACK = new SkillInfo("Basic Attack", SkillInfo.SkillClass.Melee, "Swing your weapon{mod}.", "On impact, ");
        public const SkillInfo MOD_FAST = new SkillInfo("Fast", SkillInfo.SkillClass.MeleeMod, "10% faster", "");
    }


    class SkillDepot
    {
        private SkillDepot _instance;
        public SkillDepot Depot
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SkillDepot();
                }
                return _instance;
            }
        }

        

        public SkillDepot()
        {

        }
    }

    class SkillInfo
    {
        public enum SkillClass
        {
            Melee,
            RangedAttack,
            MagicAttack,
            MeleeMod,
            RangedMod,
            MagicMod
        }

        SkillClass skillClass;
        List<SkillClass> allowedModifiers;
        List<SkillClass> allowedTechniques;

        String name;
        String description;
        String followUpDescription;

        #region getters

        public String Name
        {
            get
            {
                return name;
            }
        }
        public String Description
        {
            get
            {
                return description;
            }
        }
        public String FollowUpDescription
        {
            get
            {
                return followUpDescription;
            }
        }
        public List<SkillClass> AllowedModifiers
        {
            get
            {
                return allowedModifiers;
            }
        }
        public List<SkillClass> AllowedTechniques
        {
            get
            {
                return allowedTechniques;
            }
        }

        #endregion

        public SkillInfo(String name, SkillClass skillClass, String description, String followUpDescription)
        {
            this.name = name;
            this.skillClass = skillClass;
            this.description = description;
            this.followUpDescription = followUpDescription;
        }

        public void SetChildRules(List<SkillClass> allowedModifiers, List<SkillClass> allowedTechniques)
        {
            this.allowedModifiers = allowedModifiers;
            this.allowedTechniques = allowedTechniques;
        }
    }

    class SkillPiece
    {
        int count;  //Will end up always being one in this demo

        SkillInfo skillInfo;
        
        List<SkillPiece> modifiers;
        SkillPiece nextTechnique;
        PointF pos;

        const float Height = 50;
        const float Width = 100;
        static Font defaultFont = new Font("Arial", 10);

        public SkillPiece(SkillInfo skillInfo)
        {
            this.skillInfo = skillInfo;
        }

        public static List<SkillPiece> GetPossibleModifiers(SkillPiece parent)
        {
            return null;
        }
        public static List<SkillPiece> GetPossibleTechniques(SkillPiece parent)
        {
            return null;
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.White, pos.X, pos.Y, Width, Height);
            g.DrawString(skillInfo.Name, defaultFont, Brushes.White, pos);

            foreach (SkillPiece mod in modifiers)
            {
                mod.Draw(g);
            }
            if (nextTechnique != null)
            {
                nextTechnique.Draw(g);
            }
        }

        public String EffectText()
        {
            String text = skillInfo.Description;

            if (modifiers.Count > 0)
            {
                String modText = "";
                foreach (SkillPiece mod in modifiers)
                {
                    modText += mod.EffectText() + ". ";
                }
                text = text.Replace("{mod}", modText);
            }
            if (nextTechnique != null)
            {
                text += skillInfo.FollowUpDescription;
                return nextTechnique.EffectText(text);
            }
            return text;
        }
        public String EffectText(String parentEffect)
        {
            return parentEffect + EffectText();
        }
    }

    
}
