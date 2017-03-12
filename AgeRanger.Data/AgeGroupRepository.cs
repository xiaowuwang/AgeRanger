using AgeRanger.Core.Interfaces;
using AgeRanger.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeRanger.Data
{
    public class AgeGroupRepository : IAgeGroupRepository
    {
        private readonly AgeRangerContext _context;

        public AgeGroupRepository(AgeRangerContext context)
        {
            _context = context;
        }
        public IEnumerable<AgeGroup> ListAgeGroup()
        {
            return _context.AgeGroups.ToList();
        }
    }
}
