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
    internal class eventconfiqure : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("events").HasKey(e => e.id);
            builder.Property(e => e.Title).HasColumnType("varchar(50)");
            builder.Property(e => e.endtime).IsRequired(false);
            builder.HasOne(e => e.organizers)
                .WithMany(o => o.events)
                .HasForeignKey(e => e.organizerid);
        }
    }
}
