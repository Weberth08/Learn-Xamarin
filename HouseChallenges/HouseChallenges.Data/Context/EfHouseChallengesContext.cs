using HouseChallenges.Data.Configs;
using HouseChallenges.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HouseChallenges.Data.Context
{
    public class EfHouseChallengesContext : DbContext
    {
        public EfHouseChallengesContext() : base("HouseChallenges")
        {

        }

        public DbSet<Activity> Activities;
        public DbSet<ActivityExecution> ActivityExecutions;
        public DbSet<HomeTask> HomeTasks;
        public DbSet<House> Houses;
        public DbSet<Person> Persons;


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            modelBuilder.Configurations.Add(new ActivityExecutionConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        /*
          public override int SaveChanges()
          {
              foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreationDate") != null))
              {
                  if (entry.State == EntityState.Added)
                  {
                      entry.Property("CreationDate").CurrentValue = DateTime.Now;
                  }

                  if (entry.State == EntityState.Modified)
                  {
                      entry.Property("CreationDate").IsModified = false;
                  }

              }
              return base.SaveChanges();
          }*/
    }
}
