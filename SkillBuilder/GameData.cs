using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using SkillBuilder.Skills;

namespace SkillBuilder
{
    /// <summary>
    /// This stores and retrieves all data about the game.  Characters and their skills, game settings, etc.
    /// </summary>
    [XmlInclude(typeof(SkillTechniqueInfo))
    , XmlInclude(typeof(SkillModifierInfo))
    , XmlInclude(typeof(SkillTechnique))
    , XmlInclude(typeof(SkillModifier))
    , XmlInclude(typeof(Skill))
    , XmlInclude(typeof(Character))]
    public class GameData
    {
        private static GameData _instance;
        public static GameData Current
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameData();
                    GameData.Load();
                }
                return _instance;
            }
        }

        const String filename = "skilldata.xml";

        public float ModifierCostFactor = 0.1F;
        public float TechniqueCostFactor = 0.1F;
        public int NextPartId = 0;

        //public List<SkillPartInfo> PartsInfo { get; set; }
        public List<SkillPartInfo> ModsInfo { get; set; }
        public List<SkillPartInfo> TechsInfo { get; set; }
        public List<Character> Characters { get; set; }


        private GameData()
        {
            //TODO: Fill in defaults, if there are any
            ModsInfo = new List<SkillPartInfo>();
            TechsInfo = new List<SkillPartInfo>();
            Characters = new List<Character>();

        }

        public static void Load()
        {
            if (!TryLoad())
            {
                CreateDefault();
                _instance.Save();
            }
        }

        private static bool TryLoad()
        {
            try
            {
                if (File.Exists(filename))
                {
                    try
                    {
                        //TODO: Actually load the file and return true
                        XmlSerializer serializer = new XmlSerializer(typeof(GameData));
                        XmlReader reader = XmlReader.Create(filename);

                        _instance = (GameData)serializer.Deserialize(reader);

                        reader.Close();
                    }
                    catch
                    {
                        return false;
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {

            }
            return false;
        }
        public void Save()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(GameData));
                XmlWriter writer = XmlWriter.Create(filename);

                serializer.Serialize(writer, _instance);
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        private static void CreateDefault()
        {
            _instance = new GameData();
            _instance.Save();
        }
    }
}
