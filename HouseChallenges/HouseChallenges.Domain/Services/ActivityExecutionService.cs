using HouseChallenges.Domain.Entities;
using HouseChallenges.Domain.Interfaces.Services;
using HouseChallenges.Domain.Interfaces.UnitOfWork;

namespace HouseChallenges.Domain.Services
{
    public class ActivityExecutionService : ServiceBase<ActivityExecution>, IActivityExecutionService
    {
        public ActivityExecutionService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public ActivityExecution Create(Person executor, Activity activity)
        {


            //TODO:MOVE IT TO A FACTORY
            var activityExecution = new ActivityExecution(executor, activity);
            UnitOfWork.ActivityExecutionRepository.Add(activityExecution);
            UnitOfWork.Commit();
            return activityExecution;

        }

        public void Cancel(ActivityExecution activityExecution, Person executor)
        {

            activityExecution.Cancel(executor);
            UnitOfWork.ActivityExecutionRepository.Update(activityExecution);
            UnitOfWork.Commit();

        }

        public void Execute(ActivityExecution activityExecution, Person executor)
        {

            activityExecution.Execute(executor);
            UnitOfWork.ActivityExecutionRepository.Update(activityExecution);
            UnitOfWork.Commit();

        }

        public void Finish(ActivityExecution activityExecution, Person executor)
        {

            activityExecution.Finish(executor);
            UnitOfWork.ActivityExecutionRepository.Update(activityExecution);
            UnitOfWork.Commit();

        }

        public void PerformPartially(ActivityExecution activityExecution, Person executor)
        {

            activityExecution.PerformPartially(executor);
            UnitOfWork.ActivityExecutionRepository.Update(activityExecution);
            UnitOfWork.Commit();

        }

        public void Start(ActivityExecution activityExecution, Person executor)
        {

            activityExecution.Start(executor);
            UnitOfWork.ActivityExecutionRepository.Update(activityExecution);
            UnitOfWork.Commit();

        }
    }
}
