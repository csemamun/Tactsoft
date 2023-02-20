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
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.Company).WithMany(x=>x.Items).HasForeignKey(x=>x.CompanyId);
            builder.HasOne(x=>x.SubCategory).WithMany(x=>x.Items).HasForeignKey(x=>x.SubCategoryId);
            builder.HasOne(x=>x.Unit).WithMany(x=>x.Items).HasForeignKey(x=>x.UnitId);
        }
    }
}
