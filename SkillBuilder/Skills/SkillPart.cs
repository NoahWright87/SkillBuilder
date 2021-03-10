using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBuilder.Skills
{
    public abstract class SkillPart
    {
        public uint Count { get; set; }
        public virtual SkillPartInfo PartInfo { get; set; }
        //private Point pos;

        public SkillPart() : this(null, 0) { }
        public SkillPart(SkillPartInfo info, uint count)
        {
            this.PartInfo = info;
            this.Count = count;
        }
    }
}
