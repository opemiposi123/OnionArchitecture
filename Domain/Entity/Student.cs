using Domain.Enums;

namespace Domain.Entity
{
    public  class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AddmissionNumber { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public DateTime DateJoined { get; set; } = DateTime.Now;
        public string PhoneNumber { get; set; }
    }
}
