using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hack
{
    public partial class db_a7d8d7_testingContext : DbContext
    {
        public db_a7d8d7_testingContext()
        {
        }

        public db_a7d8d7_testingContext(DbContextOptions<db_a7d8d7_testingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FileCatalog> FileCatalogs { get; set; } = null!;
        public virtual DbSet<Lekal> Lekals { get; set; } = null!;
        public virtual DbSet<PrintValue> PrintValues { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<HackImages> Images { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SQL5105.site4now.net,1433;Initial Catalog=db_a7d8d7_testing;User Id=db_a7d8d7_testing_admin;Password=123321Ok");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileCatalog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.MomId).HasColumnName("momId");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<PrintValue>(entity =>
            {
                entity.ToTable("printValues");

                entity.HasIndex(e => e.UserId, "IX_printValues_UserId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PrintValues)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Fullname).HasColumnName("fullname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
