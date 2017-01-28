using HouseChallenges.Domain.Commands;
using HouseChallenges.Domain.Entities;
using HouseChallenges.Domain.Interfaces.Repositories;
using HouseChallenges.Domain.Interfaces.Services;


namespace HouseChallenges.Domain.Services
{
    public class ActivityExecutionService : ServiceBase<ActivityExecution>, IActivityExecutionService
    {
        private readonly IActivityExecutionRepository _repository;
        private readonly IPersonRepository _personRepository;
        private readonly IActivityRepository _activityRepository;
        public ActivityExecutionService(IActivityExecutionRepository repository,
            IPersonRepository personRepository, IActivityRepository activityRepository) : base(repository)
        {
            _repository = repository;
            _personRepository = personRepository;
            _activityRepository = activityRepository;
        }


        public void Execute(ExecuteActivityCommand command)
        {
            var activityExecution = GetActivityExecution(command.ActivityExecutionId);
            var executor = GetPerson(command.ExecutorId);
            activityExecution.Execute(executor);

        }

        public void Finish(FinishActivityExecutionCommand command)
        {
            var activityExecution = GetActivityExecution(command.ActivityExecutionId);
            var executor = GetPerson(command.PersonId);
            activityExecution.Finish(executor);
            Update(activityExecution);
        }

        public void Start(StartActivityExecutionCommand command)
        {
            var activityExecution = GetActivityExecution(command.ActivityExecutionId);
            var executor = GetPerson(command.PersonId);
            activityExecution.Start(executor);
            Update(activityExecution);
        }

        public ActivityExecution Create(CreateActivityExecutionCommand command)
        {
            var executor = GetPerson(command.ExecutorId);
            var activity = GetActivity(command.ActivityId);
            var execution = new ActivityExecution(executor, activity);
            Add(execution);
            return execution;
        }

        public void Cancel(CancelActivityExecutionCommand command)
        {

            var activityExecution = GetActivityExecution(command.ActivityExecutionId);
            var executor = GetPerson(command.PersonId);
            activityExecution.Cancel(executor);
            Update(activityExecution);
        }

        public void PerformPartially(PerformExecutionPartiallyCommand command)
        {

            var activityExecution = GetActivityExecution(command.ActivityExecutionId);
            var executor = GetPerson(command.PersonId);
            activityExecution.PerformPartially(executor);
            Update(activityExecution);
        }

        #region Private Methods

        private Person GetPerson(int personId) => _personRepository.Find(personId);

        private ActivityExecution GetActivityExecution(int activityExecutionId) => _repository.Find(activityExecutionId);

        private Activity GetActivity(int activityId) => _activityRepository.Find(activityId);


        #endregion



    }
}
