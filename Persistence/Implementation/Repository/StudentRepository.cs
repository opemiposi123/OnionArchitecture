using Application.Dtos;
using Application.Interfaces.Repository;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Implementation.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public StudentRepository(ApplicationDbContext dbContex)
        {
            _dbContext = dbContex;
        }
        public List<Student> GetAllStudents()
        {
            return _dbContext.Students.ToList();
        }

        public async Task<List<StudentDto>> GetAllStudentDto()
        {
            return await _dbContext.Students.Select(x => new StudentDto
            {
                Id = x.Id,
                AddmissionNumber = x.AddmissionNumber,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email
            }).ToListAsync();
        }

        public async Task<StudentDto?> LoadStudentDetailAsync(Guid id) =>
            await _dbContext.Students
                            .Where(x => x.Id == id)
                            .Select(x => new StudentDto
                            {
                                Id = x.Id,
                                AddmissionNumber = x.AddmissionNumber,
                                FirstName = x.FirstName,
                                LastName = x.LastName,
                                MiddleName = x.MiddleName,
                                PhoneNumber = x.PhoneNumber,
                                DateOfBirth = x.DateOfBirth,
                                Email = x.Email,
                                Gender = x.Gender,
                                Datejoined = x.DateJoined
                            })
                            .FirstOrDefaultAsync();

        public Student GetByAdmissionNo(string admissionNo)
        {
            return _dbContext.Students.Where(s => s.AddmissionNumber == admissionNo).FirstOrDefault();

        }

        public Student GetById(Guid id)
        {
            return _dbContext.Students.Where(s => s.Id == id).FirstOrDefault();
        }

        public Student GetByIdOrAdmissionNo(Guid id, string admissionNo)
        {
            return _dbContext.Students.Where(s => s.Id == id || s.AddmissionNumber == admissionNo).FirstOrDefault();
        }

        public Student AddStudent(Student student)
        {
            _dbContext.Add(student);
            _dbContext.SaveChanges();
            return student;
        }
        public Student DeleteAsync(Student student)
        {
            _dbContext.Remove(student); 
            _dbContext.SaveChanges();
            return student;
        }

        public Student UpdateStudent(Student student)
        {
            _dbContext.SaveChanges();
            return student;
        }

        public Student UpdateAsync(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
