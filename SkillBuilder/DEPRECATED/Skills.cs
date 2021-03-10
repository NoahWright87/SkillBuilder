using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Drawing;

namespace SkillBuilder
{
    

    
    //[XmlInclude(typeof(SkillTechniqueInfo)), XmlInclude(typeof(SkillModifierInfo))]
    

    //public class SkillSet
    //{
    //    public String Name { get; set; }
    //    public List<Skill> Skills { get; set; }
    //}

    

    
    

    
    

    

    ///// <summary>
    ///// Used to store the settings for parts, such as their descriptions, what
    ///// mod can be used with which technique, etc
    ///// </summary>
    //class SkillData
    //{
    //    private static SkillData _current;
    //    public static SkillData Current
    //    {
    //        get
    //        {
    //            if (_current == null)
    //            {
    //                _current = new SkillData();
    //            }
    //            return _current;
    //        }
    //    }

    //    const String settingsFile = "skillsettings.xml";

    //    public Dictionary<int, ASkillPart> availableParts;
    //    //public Dictionary<int, List<int>> validTechniques;
    //    //public Dictionary<int, List<int>> validModifiers;
    //    public float modCostFactor;
    //    public float techCostFactor;

    //    public static Boolean TryLoad()
    //    {
    //        if (File.Exists(settingsFile))
    //        {
    //            XmlReader reader = XmlReader.Create(settingsFile);
    //            XmlSerializer serializer = new XmlSerializer(typeof(SkillData));

    //            try
    //            {
    //                _current = (SkillData)serializer.Deserialize(reader);
    //            }
    //            catch
    //            {
    //                return false;
    //            }
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //    public static void Save()
    //    {
    //        if (!File.Exists(settingsFile))
    //        {
    //            File.Create(settingsFile);
    //        }

    //        XmlWriter writer = XmlWriter.Create(settingsFile);
    //        XmlSerializer serializer = new XmlSerializer(typeof(SkillData));

    //        serializer.Serialize(writer, Current);
    //    }
    //}

    //class Skill
    //{
    //    String name;
    //    List<SkillTechnique> techniques;

    //    public ResourceCost Cost
    //    {
    //        get
    //        {
    //            return null;
    //        }
    //    }
    //    public String Description
    //    {
    //        get
    //        {
    //            return null;
    //        }
    //    }


    //}

    //abstract class ASkillPart
    //{
    //    public int id;
    //    public String name;
    //    public String description;
    //    public ResourceCost cost;
    //}
    //class ResourceCost
    //{
    //    public float health;
    //    public float mana;
    //    public float stamina;
    //}

    //class SkillTechnique : ASkillPart
    //{
    //    List<SkillModifier> modifiers;
    //    public String followupTransition;

    //}
    ///// <summary>
    ///// Contains constants for the various techniques available.
    ///// </summary>
    //class SkillTechniques
    //{
    //    public readonly SkillTechnique BasicAttack = new SkillTechnique();
    //}

    //class SkillModifier : ASkillPart
    //{

    //}
    ///// <summary>
    ///// Contains constants for the various modifiers available.
    ///// </summary>
    //class SkillModifiers
    //{
    //    public readonly SkillModifier Multishot = new SkillModifier();
    //    public readonly SkillModifier Fire = new SkillModifier();
    //}
}
