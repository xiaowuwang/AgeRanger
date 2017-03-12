using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeRanger.Core.Model
{
    public class AgeGroup
    {
        public virtual int Id { get; set; }
        public virtual int MinAge { get; set; }
        public virtual int MaxAge { get; set; }

        public virtual string Description { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}] {1} {2} {3}", Id, MinAge, MaxAge, Description);
        }
    }
}
