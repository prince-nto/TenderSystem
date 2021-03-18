using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TenderSystem.Models;

namespace TenderSystem.Configurations
{
    public class TenderConfiguration : IEntityTypeConfiguration<Tender>
    {
        public void Configure(EntityTypeBuilder<Tender> builder)
        {
            builder.ToTable("Tenders");

            builder.Property(p => p.Description).HasMaxLength(100).IsRequired();
            builder.HasOne(p => p.StateOrgan).WithMany().HasForeignKey(p => p.StateOrganId);
        }
    }
}
