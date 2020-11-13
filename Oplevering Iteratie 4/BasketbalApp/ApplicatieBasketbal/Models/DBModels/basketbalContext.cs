using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApplicatieBasketbal.Models.DBModels
{
    public partial class basketbalContext : DbContext
    {
        public basketbalContext()
        {
        }

        public basketbalContext(DbContextOptions<basketbalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Speler> Speler { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Port=3306;User=root;Password=root;Database=basketbal");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Speler>(entity =>
            {
                entity.ToTable("speler");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActiveTeam)
                    .HasColumnName("Active Team")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Assists).HasColumnType("varchar(45)");

                entity.Property(e => e.Blocks).HasColumnType("varchar(45)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(45)");

                entity.Property(e => e.Games).HasColumnType("varchar(45)");

                entity.Property(e => e.LastName).HasColumnType("varchar(45)");

                entity.Property(e => e.Points).HasColumnType("varchar(45)");

                entity.Property(e => e.Rebounds).HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.Idteam)
                    .HasName("PRIMARY");

                entity.ToTable("team");

                entity.Property(e => e.Idteam).HasColumnName("idteam");

                entity.Property(e => e.Name).HasColumnType("varchar(45)");

                entity.Property(e => e.Player).HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Password).HasColumnType("varchar(45)");

                entity.Property(e => e.Username).HasColumnType("varchar(45)");
            });
        }
    }
}
