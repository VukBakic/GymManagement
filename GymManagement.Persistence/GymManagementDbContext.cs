using GymManagement.Domain;
using GymManagement.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Persistence
{
    internal class GymManagementDbContext : DbContext
    {
        public GymManagementDbContext(DbContextOptions<GymManagementDbContext> options) :base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GymManagementDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entry.Entity.DateModified = DateTime.Now;
                if(entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
            }


            return base.SaveChangesAsync(cancellationToken);
        }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseType> ExercisesTypes { get; set; }
    }
}
