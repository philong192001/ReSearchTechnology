using Microsoft.EntityFrameworkCore;
using StringToDecimalKafka.Trigger;

namespace StringToDecimalKafka
{
    public class Student
    {
        public int Id { get; set; }

        public string DisplayName { get; set; }

        public DateTime RegistrationDate { get; set; }
    }

    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseOracle("Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 10.26.7.21)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = tradingt))); User ID = trd; Password = trd1234")
                .UseTriggers(triggerOptions => {
                    triggerOptions.AddTrigger<StudentAssignRegistrationDate>();
                });

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Student> Students { get; set; }
    }
}
