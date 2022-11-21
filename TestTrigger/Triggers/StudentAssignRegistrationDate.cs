using EntityFrameworkCore.Triggered;
using TestTrigger.Context;

namespace TestTrigger.Triggers
{
    public class StudentAssignRegistrationDate : IBeforeSaveTrigger<Student>
    {
        public Task BeforeSave(ITriggerContext<Student> context, CancellationToken cancellationToken)
        {
            if (context.ChangeType == ChangeType.Added)
            {
                context.Entity.RegistrationDate = DateTime.Today;
            }

            return Task.CompletedTask;
        }
    }
}
