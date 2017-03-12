using AgeRanger.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeRanger.Data.Models.Mapping
{
    class AgeGroupMap : EntityTypeConfiguration<AgeGroup>
    {
        public AgeGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);
            // Properties
            // Table & Column Mappings
            this.ToTable("AgeGroup");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MinAge).HasColumnName("MinAge");
            this.Property(t => t.MaxAge).HasColumnName("MaxAge");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
