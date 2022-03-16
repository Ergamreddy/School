using Microsoft.AspNetCore.Mvc;
using School1.Repositories;
using School1.DTO;
using School1.Models;
// using static School1.DTO.teacherDto;

namespace School1.Controllers;

[ApiController]
[Route("[controller]")]
public class TeacherController : ControllerBase
{
    private readonly ITeacherRepository _teacher;
    private readonly ILogger<TeacherController> _logger;

    private readonly IStudentRepository _student;

    public TeacherController(ILogger<TeacherController> logger, ITeacherRepository teacher, IStudentRepository student)
    {
        _logger = logger;

        _teacher = teacher;

        _student = student;


    }
    [HttpGet]

    public async Task<ActionResult<List<teacherDto>>> GetAllusers()
    {
        var teachersList = await _teacher.GetList();

        var dtoList = teachersList.Select(x => x.asDto);

        return Ok(dtoList);
    }

    [HttpGet("{teacher_id}")]

    public async Task<ActionResult<teacherDto>> GetUserById([FromRoute] long teacher_id)
    {
        var teacher = await _teacher.GetById(teacher_id);

        if (teacher is null)
            return NotFound("No user found with given teacher_id");


        var dto = teacher.asDto;

        dto.Student = await _student.GetList(teacher.TeacherId);

        return Ok(dto);
    }

    [HttpPost]
    public async Task<ActionResult<teacherDto>> CreateUser([FromBody] teacherDto.UsersCreateDto Data)
    {

        var toCreateUser = new Teacher
        {
            Name = Data.Name,
            Surname = Data.Surname,
            Mobile = Data.Mobile,
            SubjectId = Data.SubjectId,


        };

        var createdUser = await _teacher.Create(toCreateUser);

        return StatusCode(StatusCodes.Status201Created, createdUser.asDto);
    }




    [HttpPut("{teacher_id}")]

    public async Task<ActionResult> UpdateUser([FromRoute] long teacher_id,
    [FromBody] UserUpdateDto Data)
    {
        var existing = await _teacher.GetById(teacher_id);
        if (existing is null)
            return NotFound("No user found with given teacher id");

        var toUpdateUser = existing with
        {
            Surname = Data.Surname,
            Mobile = Data.Mobile,

        };

        var didUpdate = await _teacher.Update(toUpdateUser);

        if (!didUpdate)
            return StatusCode(StatusCodes.Status500InternalServerError, "Could not update user");

        return NoContent();
    }


    [HttpDelete("{teacher_id}")]

    public async Task<ActionResult> DeleteUser([FromRoute] long teacher_id)
    {
        var existing = await _teacher.GetById(teacher_id);

        if (existing is null)
            return NotFound("No user found with given teacher id");

        var didDelete = await _teacher.Delete(teacher_id);

        return NoContent();

    }
}