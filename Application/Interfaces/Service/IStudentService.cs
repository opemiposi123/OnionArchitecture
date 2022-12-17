using Application.Dtos;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Service
{
    public interface IStudentService
    {
        Task<CreateEditResponse> Create(CreateStudent request);
        Task<List<StudentDto>> LoadAllStudent();
        Task<StudentDto> LoadStudentDetail(Guid id);
        Task<CreateEditResponse> Update(Guid id, UpdateStudent updateStudentDto);
        Task<CreateEditResponse> Delete(Guid id);
    }
}
