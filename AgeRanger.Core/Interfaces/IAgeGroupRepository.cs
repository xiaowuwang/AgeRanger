using AgeRanger.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeRanger.Core.Interfaces
{
    public interface IAgeGroupRepository
    {
        IEnumerable<AgeGroup> ListAgeGroup();
    }
}
