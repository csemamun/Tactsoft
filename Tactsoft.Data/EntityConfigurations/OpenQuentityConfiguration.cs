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
    public class OpenQuentityConfiguration : IEntityTypeConfiguration<OpenQuantity>
    {
        public void Configure(EntityTypeBuilder<OpenQuantity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Item).WithMany(x => x.OpenQuantities).HasForeignKey(x => x.ItemId);

        }
    }
}
