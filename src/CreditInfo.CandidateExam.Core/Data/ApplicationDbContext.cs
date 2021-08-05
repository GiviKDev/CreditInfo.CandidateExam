
using CreditInfo.CandidateExam.Core.Entities;

using Microsoft.EntityFrameworkCore;

namespace CreditInfo.CandidateExam.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Contract> Contracts { get; set; }

        public virtual DbSet<Individual> Individuals { get; set; }

        public virtual DbSet<IndividualContract> IndividualContracts { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contract>(b =>
            {
                b.OwnsOne(t => t.CurrentBalance, ot =>
                {
                    ot.Property(p => p.Value).HasPrecision(18, 4);
                });

                b.OwnsOne(t => t.InstallmentAmount, ot =>
                {
                    ot.Property(p => p.Value).HasPrecision(18, 4);
                });

                b.OwnsOne(t => t.OriginalAmount, ot =>
                {
                    ot.Property(p => p.Value).HasPrecision(18, 4);
                });

                b.OwnsOne(t => t.OverdueBalance, ot =>
                {
                    ot.Property(p => p.Value).HasPrecision(18, 4);
                });
            });

            modelBuilder.Entity<Individual>(b =>
            {
                b.OwnsOne(t => t.IdentificationNumbers);
            });

            modelBuilder.Entity<IndividualContract>(b =>
            {
                b.HasKey(t => new { t.IndividualId, t.ContractId });

                b.HasOne(t => t.Individual)
                    .WithMany(t => t.IndividualContracts)
                    .HasForeignKey(t => t.IndividualId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasOne(t => t.Contract)
                    .WithMany(t => t.IndividualContracts)
                    .HasForeignKey(t => t.ContractId)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
