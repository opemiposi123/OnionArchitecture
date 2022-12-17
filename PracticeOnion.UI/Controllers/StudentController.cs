using Application.Dtos;
using Application.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace PracticeOnion.UI.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        #region Crud Student

        [HttpGet("student/create")]
        public IActionResult CreateStudent() =>
            View();
        
        [HttpPost("student/create")]
        public async Task<IActionResult> CreateStudent([FromForm] CreateStudent createStudent)
        {
            try
            {
                var response = await _studentService.Create(createStudent);
                return RedirectToAction("ViewStudent", "Student");
            }
            catch
            {
                return Ok(new
                {
                    status = "error",
                    message = "Something happened. Please try again later."
                });
            }

        }

        [HttpGet("student")]
        public async Task<IActionResult> ViewStudent()
        {
            var instances =
            await _studentService.LoadAllStudent();
            return View(instances);
        }

        [HttpGet("student/data")]
        public async Task<IActionResult> LoadStudentAsync()
        {
            var instances =
                await _studentService.LoadAllStudent();
            return View(instances);
        }

        [HttpGet("student/{id}")]
        public async Task<IActionResult> ViewStudentDetail([FromRoute] Guid id)
        {
            var instance = await _studentService.LoadStudentDetail(id);

            return instance == null
                       ? (IActionResult)NotFound()
                       : View(instance);
        }

        [HttpGet("student/{id}/edit")]
        public async Task<IActionResult> EditStudentAsync(Guid id)
        {
            var instance = await _studentService.LoadStudentDetail(id);

            if (instance == null)
            {
                return NotFound();
            }

            return View(instance);
        }

        [HttpPost("student/{id}/edit")]
        public async Task<IActionResult> EditStudent([FromRoute] Guid id, [FromForm] UpdateStudent update   )
        {
            try
            {
                var response = await _studentService.Update(id, update);
                return RedirectToAction("ViewStudent", "Student");
            }
            catch
            {
                return Ok(new
                {
                    status = "error",
                    message = "Something happened. Please try again later."
                });
            }
        }

        [HttpPost("student/{id}/delete")]
        public async Task<IActionResult> DeleteStudent(Guid id)
        {
            try
            {
                var response = await _studentService.Delete(id);
                return RedirectToAction("ViewStudent", "Student");
            }
            catch
            {
                return Ok(new
                {
                    status = "error",
                    message = "Something happened. Please try again later."
                });
            }
        }

        #endregion
    }
}
