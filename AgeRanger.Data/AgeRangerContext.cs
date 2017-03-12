using AgeRanger.Core.Model;
using AgeRanger.Data.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeRanger.Data
{
    public class AgeRangerContext : DbContext
    {
        public AgeRangerContext():base("name = AgeRangerContext")
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<AgeGroup> AgeGroups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new AgeGroupMap());
        }
    }
}
