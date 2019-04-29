using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GraphQl.DotNetCore.MyApp.Models
{
    public partial class AgilityInsightContext : DbContext
    {
        public AgilityInsightContext()
        {
        }

        public AgilityInsightContext(DbContextOptions<AgilityInsightContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminUsers> AdminUsers { get; set; }
        public virtual DbSet<ExecutiveUsers> ExecutiveUsers { get; set; }
        public virtual DbSet<FieldProductMapping> FieldProductMapping { get; set; }
        public virtual DbSet<Fields> Fields { get; set; }
        public virtual DbSet<PracticeOptions> PracticeOptions { get; set; }
        public virtual DbSet<ProductStates> ProductStates { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<QuadrantFieldValues> QuadrantFieldValues { get; set; }
        public virtual DbSet<QuadrantFieldValuesAudit> QuadrantFieldValuesAudit { get; set; }
        public virtual DbSet<Quadrants> Quadrants { get; set; }
        public virtual DbSet<Reference> Reference { get; set; }
        public virtual DbSet<RisksAndImpediments> RisksAndImpediments { get; set; }
        public virtual DbSet<RisksAndImpedimentsAudit> RisksAndImpedimentsAudit { get; set; }
        public virtual DbSet<SavedScoreCard> SavedScoreCard { get; set; }
        public virtual DbSet<SavedScoreCardAudit> SavedScoreCardAudit { get; set; }
        public virtual DbSet<TeamCategory> TeamCategory { get; set; }
        public virtual DbSet<TeamScoreCardTemplate> TeamScoreCardTemplate { get; set; }
        public virtual DbSet<UserTokenCaches> UserTokenCaches { get; set; }

        // Unable to generate entity type for table 'dbo.FieldsAudit'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.QuadrantsAudit'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ScoreCardStates'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TeamCategoryAudit'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TeamScoreCardTemplateAudit'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TeamType'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=PRO-LP030\\sqlexpress;initial catalog=AgilityInsight;integrated security=True;MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminUsers>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExecutiveUsers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FieldProductMapping>(entity =>
            {
                entity.HasOne(d => d.Field)
                    .WithMany(p => p.FieldProductMapping)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FieldForeignKey");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.FieldProductMapping)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductForeignKey");
            });

            modelBuilder.Entity<Fields>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FieldInfo).IsRequired();

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.QuadrantNavigation)
                    .WithMany(p => p.Fields)
                    .HasForeignKey(d => d.Quadrant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Fields__Quadrant__403A8C7D");
            });

            modelBuilder.Entity<PracticeOptions>(entity =>
            {
                entity.Property(e => e.Option)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProductStates>(entity =>
            {
                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<QuadrantFieldValues>(entity =>
            {
                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.QuadrantName).HasMaxLength(100);

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.QuadrantFieldValues)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuadrantFieldValues_Fields");

                entity.HasOne(d => d.Quadrant)
                    .WithMany(p => p.QuadrantFieldValues)
                    .HasForeignKey(d => d.QuadrantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuadrantFieldValues_Quadrants");

                entity.HasOne(d => d.SavedScore)
                    .WithMany(p => p.QuadrantFieldValues)
                    .HasForeignKey(d => d.SavedScoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuadrantFieldValues_SavedScoreCardNew");
            });

            modelBuilder.Entity<QuadrantFieldValuesAudit>(entity =>
            {
                entity.Property(e => e.Action).HasMaxLength(100);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.QuadrantName).HasMaxLength(100);

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.QuadrantFieldValuesAudit)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__QuadrantF__Field__44FF419A");

                entity.HasOne(d => d.Quadrant)
                    .WithMany(p => p.QuadrantFieldValuesAudit)
                    .HasForeignKey(d => d.QuadrantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__QuadrantF__Quadr__45F365D3");

                entity.HasOne(d => d.SavedScore)
                    .WithMany(p => p.QuadrantFieldValuesAudit)
                    .HasForeignKey(d => d.SavedScoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__QuadrantF__Saved__46E78A0C");
            });

            modelBuilder.Entity<Quadrants>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reference>(entity =>
            {
                entity.Property(e => e.Type).IsRequired();

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<RisksAndImpediments>(entity =>
            {
                entity.Property(e => e.ActualEndDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Ownership).HasMaxLength(200);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.ScoreCard)
                    .WithMany(p => p.RisksAndImpediments)
                    .HasForeignKey(d => d.ScoreCardId)
                    .HasConstraintName("FK_SprintComments_SavedScoreCardNew");
            });

            modelBuilder.Entity<RisksAndImpedimentsAudit>(entity =>
            {
                entity.Property(e => e.Action).HasMaxLength(100);

                entity.Property(e => e.ActualEndDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Ownership).HasMaxLength(200);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.ScoreCard)
                    .WithMany(p => p.RisksAndImpedimentsAudit)
                    .HasForeignKey(d => d.ScoreCardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RisksAndI__Score__49C3F6B7");
            });

            modelBuilder.Entity<SavedScoreCard>(entity =>
            {
                entity.Property(e => e.Auditor).HasMaxLength(100);

                entity.Property(e => e.CreatedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerFeedback).IsUnicode(false);

                entity.Property(e => e.FinishDate).HasColumnType("date");

                entity.Property(e => e.ImpactScore)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductOwner)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScrumMaster).HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TeamRating)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SavedScoreCardAudit>(entity =>
            {
                entity.Property(e => e.Action).HasMaxLength(100);

                entity.Property(e => e.Auditor).HasMaxLength(100);

                entity.Property(e => e.CustomerFeedback).IsUnicode(false);

                entity.Property(e => e.FinishDate).HasColumnType("date");

                entity.Property(e => e.ImpactScore)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ProductOwner).HasMaxLength(100);

                entity.Property(e => e.ScrumMaster).HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TeamId).HasMaxLength(200);

                entity.Property(e => e.TeamRating)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.ScoreCard)
                    .WithMany(p => p.SavedScoreCardAudit)
                    .HasForeignKey(d => d.ScoreCardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SavedScor__Score__4AB81AF0");
            });

            modelBuilder.Entity<TeamCategory>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TeamCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamCategory_PracticeCategories");
            });

            modelBuilder.Entity<TeamScoreCardTemplate>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.TeamScoreCardTemplate)
                    .HasForeignKey(d => d.FieldId)
                    .HasConstraintName("FK__TeamScore__Field__4E88ABD4");

                entity.HasOne(d => d.Quadrant)
                    .WithMany(p => p.TeamScoreCardTemplate)
                    .HasForeignKey(d => d.QuadrantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TeamScore__Quadr__4F7CD00D");
            });

            modelBuilder.Entity<UserTokenCaches>(entity =>
            {
                entity.HasKey(e => e.UserTokenCacheId);

                entity.Property(e => e.CacheBits).HasColumnName("cacheBits");

                entity.Property(e => e.LastWrite).HasColumnType("datetime");

                entity.Property(e => e.WebUserUniqueId).HasColumnName("webUserUniqueId");
            });
        }
    }
}
