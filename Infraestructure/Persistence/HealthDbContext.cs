using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Infraestructure.Persistence.Configurations;
using Application.common.interfaces;

namespace Infraestructure.Persistence
{
    public class HealthDbContext : DbContext, IApplicationDbContext
    {
        public HealthDbContext(DbContextOptions<HealthDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HealthDbContext).Assembly);
        }
    }
}
