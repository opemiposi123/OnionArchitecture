using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class StudentDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public DateTime Datejoined { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateJoined { get; set; }
        public string AddmissionNumber { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    public class CreateStudent
    {
        public string FirstName { get; set; }
        public string AddmissionNumber { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DateJoined { get; set; } = DateTime.Now;
        public string PhoneNumber { get; set; }

    }
    public class UpdateStudent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
    }
}
