using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace trevel
{
    public partial class trevelContext : DbContext
    {
        public trevelContext()
        {
        }

        public trevelContext(DbContextOptions<trevelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StatusTask> StatusTasks { get; set; } = null!;
        public virtual DbSet<Task> Tasks { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=trevel;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatusTask>(entity =>
            {
                entity.ToTable("StatusTask");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("Task");

                entity.Property(e => e.Desck).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PublicDate).HasColumnType("date");

                entity.HasOne(d => d.IdOwnerNavigation)
                    .WithMany(p => p.TaskIdOwnerNavigations)
                    .HasForeignKey(d => d.IdOwner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_User2");

                entity.HasOne(d => d.IdStatusTaskNavigation)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.IdStatusTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_StatusTask");

                entity.HasOne(d => d.IdWorkerNavigation)
                    .WithMany(p => p.TaskIdWorkerNavigations)
                    .HasForeignKey(d => d.IdWorker)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_User3");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("First_Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.Login).HasMaxLength(50);

                entity.Property(e => e.Pass).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.SecondName)
                    .HasMaxLength(50)
                    .HasColumnName("Second_Name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
