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
    public class WareHouseConfiguration : IEntityTypeConfiguration<WareHouse>
    {
        public void Configure(EntityTypeBuilder<WareHouse> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Company).WithMany(x => x.WareHouses).HasForeignKey(x => x.CompanyId);
            builder.HasOne(x => x.Country).WithMany(x => x.WareHouses).HasForeignKey(x => x.CountryId);
        }
    }
}
