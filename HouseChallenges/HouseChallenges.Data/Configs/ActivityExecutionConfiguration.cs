using HouseChallenges.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HouseChallenges.Data.Configs
{
    class ActivityExecutionConfiguration : EntityTypeConfiguration<ActivityExecution>
    {
        public ActivityExecutionConfiguration()
        {
            HasKey(act => act.Id);
            ConfigureFields();
            ConfigureRelationShip();
        }

        protected void ConfigureFields()
        {

            Property(p => p.ExecutionStatus)
                .IsRequired();

            Property(p => p.StartDateTime)
               .IsOptional();

            Property(p => p.EndDateTime)
              .IsOptional();

            Property(p => p.CancelDateTime)
              .IsOptional();

        }


        public void ConfigureRelationShip()
        {
            // 1 A : N Person
            HasRequired<Person>(p => p.Executor)
                .WithMany()
                .HasForeignKey(p => p.PersonId);

            // 1 A : N Activity
            HasRequired<Activity>(p => p.Activity)
                .WithMany()
                .HasForeignKey(p => p.ActivityId);
        }
    }

}
