using Application.Dtos;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetById(Guid id);
        Student GetByAdmissionNo(string admissionNo);
        Student GetByIdOrAdmissionNo(Guid id, string admissionNo);
        Task<List<StudentDto>> GetAllStudentDto();
        Task<StudentDto?> LoadStudentDetailAsync(Guid id);
        Student AddStudent(Student student);
        Student DeleteAsync(Student student);
        Student UpdateAsync(Student student); 
    }
}
