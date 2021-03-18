using Microsoft.EntityFrameworkCore;
using TenderSystem.Configurations;
using TenderSystem.Models;

namespace TenderSystem.Data
{
    public class TenderContext : DbContext
    {
        public TenderContext(DbContextOptions<TenderContext> options) : base(options)
        { }

        public DbSet<TenderBidSubmissionProduct> TenderBidSubmissionProducts { get; set; }
        public DbSet<CompanyUser> CompanyUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<TenderBidSubmission> TenderBidSubmissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<StateOrgan> StateOrgans { get; set; }
        public DbSet<Tender> Tenders { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
        }
    }
}
