using InterbetTestAppplicationRepository.Models;
using System;
using System.Data.Entity;

namespace InterbetTestAppplicationRepository
{
    public interface IApplicationDbContext : IDisposable
    {

    }
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public virtual DbSet<CorporatePayment> EchocastPodcasts { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}