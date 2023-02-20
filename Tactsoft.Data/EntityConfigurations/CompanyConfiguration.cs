using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Entities;

namespace Tactsoft.Data.EntityConfigurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Country).WithMany(x => x.Companies).HasForeignKey(e => e.CountryId);
            builder.HasOne(x => x.State).WithMany(x => x.Companies).HasForeignKey(e => e.StateId);
            builder.HasOne(x => x.City).WithMany(x => x.Companies).HasForeignKey(e => e.CityId);
        }
    }
}
