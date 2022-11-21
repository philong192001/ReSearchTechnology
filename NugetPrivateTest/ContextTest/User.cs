using System.ComponentModel.DataAnnotations;

namespace NugetPrivateTest.ContextTest
{
    public class User
    {
        [Key]
        public int AClientCode { get; set; }
        public int Name { get; set; }

        public Address Address { get; set; }
    }
    public class Address
    {
        public int Id { get; set; }
        public int MyProperty { get; set; }
    }
}
