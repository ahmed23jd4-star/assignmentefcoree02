using assignmentefcore02.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentefcore02.confiquration
{
    internal class OrganizerProfileconfiqure : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.ToTable("OrganizerProfiles").HasKey(o => o.id);
            builder.Property(o => o.Biography).HasMaxLength(200).HasDefaultValue("aa");
            builder.Property(o => o.WebsiteUrl).HasMaxLength(100);
            builder.HasOne(o => o.Organizers)
                .WithOne(p => p.OrganizerProfilenav)
                .HasForeignKey<OrganizerProfile>(o => o.OrganizerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
