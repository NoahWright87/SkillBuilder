using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBuilder.Skills
{
    public abstract class SkillPartInfo
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Description2 { get; set; }
        public String Description3 { get; set; }
        public ResourceAmount Cost { get; set; }

        public SkillPartInfo() : this("", "", "", "", new ResourceAmount()) { }
        public SkillPartInfo(String name, String description, String description2, String description3, ResourceAmount cost)
        {
            this.Id = GetNextId();
            this.Name = name;
            this.Description = description;
            this.Description2 = description2;
            this.Description3 = description3;
            this.Cost = cost;
        }
        protected int GetNextId()
        {
            return GameData.Current.NextPartId++;
        }

        public override string ToString()
        {
            return String.Format("{0}) {1}", Id, Name);
        }
    }
}
