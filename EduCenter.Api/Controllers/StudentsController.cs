using EduCenter.Domain.Commons;
using EduCenter.Domain.Configurations;
using EduCenter.Domain.Entities.Students;
using EduCenter.Domain.Enums;
using EduCenter.Service.DTOs.Students;
using EduCenter.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduCenter.Api.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService studentService;
        public StudentsController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpPost]
        public async Task<ActionResult<BaseResponse<Student>>> Create(StudentForCreationDto studentDto)
        {
            var result = await studentService.CreateAsync(studentDto);

            return StatusCode(result.Code ?? result.Error.Code.Value, result);
        }

        [HttpGet]
        public async Task<ActionResult<BaseResponse<IEnumerable<Student>>>> GetAll([FromQuery] PaginationParams @params)
        {

            var result = await studentService.GetAllAsync(@params);

            return StatusCode(result.Code ?? result.Error.Code.Value, result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BaseResponse<Student>>> Get(Guid id)
        {
            var result = await studentService.GetAsync(p => p.Id == id);

            return StatusCode(result.Code ?? result.Error.Code.Value, result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<BaseResponse<Student>>> Update(Guid id, StudentForCreationDto studentDto)
        {
            var result = await studentService.UpdateAsync(id, studentDto);

            return StatusCode(result.Code ?? result.Error.Code.Value, result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<BaseResponse<bool>>> Delete(Guid id)
        {
            var result = await studentService.DeleteAsync(p => p.Id == id && p.State != ItemState.Deleted);

            return StatusCode(result.Code ?? result.Error.Code.Value, result);
        }

    }
}
