using NugetPrivateTest.ContextTest;

namespace NugetPrivateTest.Trigger
{
    public class StudentAssignRegistrationDate : IBeforeSaveTrigger<Student>
    {
        public Task BeforeSave(ITriggerContext<Student> context, CancellationToken cancellationToken)
        {
            if (context.ChangeType == ChangeType.Added)
            {
                context.Entity.RegistrationDate = DateTime.Now;
            }

            return Task.CompletedTask;
        }
    }
}

