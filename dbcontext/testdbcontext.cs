using assignmentefcore02.confiquration;
using assignmentefcore02.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentefcore02.dbcontext
{
    internal class testdbcontext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHubDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Organizer> EventOrganizers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<badge>(entity =>
            {
                entity.ToTable("badges").HasKey(e => e.id);
                entity.HasOne(e => e.attendnav)
                .WithOne(b => b.badgenav)
                .HasForeignKey<badge>(b => b.attendid);

            }
            );
            modelBuilder.ApplyConfiguration(new eventconfiqure());
            modelBuilder.ApplyConfiguration(new OrganizerProfileconfiqure());
            
        }

    }
}
