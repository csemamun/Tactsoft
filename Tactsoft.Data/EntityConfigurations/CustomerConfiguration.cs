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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Country).WithMany(x => x.Customers).HasForeignKey(x => x.CountryId);
            builder.HasOne(x => x.State).WithMany(x => x.Customers).HasForeignKey(x => x.StateId);
            builder.HasOne(x => x.City).WithMany(x => x.Customers).HasForeignKey(x => x.CityId);
        }
    }
}
