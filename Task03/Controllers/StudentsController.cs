using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task03.Models;
using Task03.Services;

namespace Task03.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IDatabaseService fileService;

        public StudentsController(IDatabaseService fileService)
        {
            this.fileService = fileService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            return Ok(FileService.students);
        }

        [HttpGet("{ID}")]
        public async Task<IActionResult> GetStudentByID([FromRoute] int ID)
        {
            Student student;
            try
            {
                student = fileService.GetStudentByID(ID);
            } catch (StudentNotFoundException exception)
            {
                return NotFound(exception.Message);
            } catch (Exception)
            {
                return BadRequest("Something went wrong! Try to check entered data!");
            }
            return Ok(student);
        }

        [HttpPut("{ID}")]
        public async Task<IActionResult> ChangeSomeDataOfStudentByID([FromRoute]int ID, [FromBody]Student student)
        {
            try
            {
                fileService.ChangeSomeDataByID(ID, student);
            } catch (StudentNotFoundException exception)
            {
                return NotFound(exception.Message);
            } catch (NotModyfingPropertyException exception)
            {
                return BadRequest(exception.Message);
            } catch (Exception)
            {
                return BadRequest("Something went wrong! Try to check entered data!");
            }
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody]Student student)
        {
            try
            {
                fileService.AddStudent(student);
            } catch (StudentAlreadyFoundException exception)
            {
                return BadRequest(exception.Message);
            } catch (Exception)
            {
                return BadRequest("Something went wrong! Try to check entered data!");
            }
            return Ok($"Student s{student.ID} succsesfully added!");
        }

        [HttpDelete("{ID}")]
        public async Task<IActionResult> RemoveStudentByID([FromRoute]int ID)
        {
            try
            {
                fileService.RemoveStudentByID(ID);
            }
            catch (StudentNotFoundException exception)
            {
                return NotFound(exception.Message);
            }
            catch (Exception)
            {
                return BadRequest("Something went wrong! Try to check entered data!");
            }
            return Ok($"Student s{ID} succsesfully removed!");
        }
    }
}