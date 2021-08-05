
using CreditInfo.CandidateExam.Core.Entities;

using Microsoft.EntityFrameworkCore;

namespace CreditInfo.CandidateExam.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Contract> Contracts { get; set; }

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
        }
    }
}
