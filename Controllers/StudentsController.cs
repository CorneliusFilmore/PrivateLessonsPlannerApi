using MediatR;
using Microsoft.AspNetCore.Mvc;
using PrivateLessonsPlannerApi.Commands;
using PrivateLessonsPlannerApi.Models;
using PrivateLessonsPlannerApi.Queries;
using static Microsoft.AspNetCore.Http.StatusCodes;


namespace PrivateLessonsPlannerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator mediator;

        public StudentsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(Status200OK)]
        [ProducesResponseType(Status400BadRequest)]
        [ProducesResponseType(Status500InternalServerError)]
        public async Task<IActionResult> GetStudentListAsync()
        {
            var studentDetails = await mediator.Send(new GetStudentListQuery());

            return Ok(studentDetails);
        }

        [HttpGet("{studentId}")]
        [ProducesResponseType(Status200OK)]
        [ProducesResponseType(Status400BadRequest)]
        [ProducesResponseType(Status500InternalServerError)]
        public async Task<IActionResult> GetStudentByIdAsync(int studentId)
        {
            var studentDetails = await mediator.Send(new GetStudentByIdQuery() { Id = studentId });

            return Ok(studentDetails);
        }

        [HttpPost("add")]
        [ProducesResponseType(Status201Created)]
        [ProducesResponseType(Status400BadRequest)]
        [ProducesResponseType(Status500InternalServerError)]
        public async Task<IActionResult> AddStudentAsync(Student studentDetails)
        {
            var result = await mediator.Send(new CreateStudentCommand(
                studentDetails.Name,
                studentDetails.Surname,
                studentDetails.PhoneNumber,
                studentDetails.PhoneName));

            return Created(nameof(AddStudentAsync),studentDetails);
        }
    

        [HttpPut("update/{id}")]
        [ProducesResponseType(Status200OK)]
        [ProducesResponseType(Status204NoContent)]
        [ProducesResponseType(Status400BadRequest)]
        [ProducesResponseType(Status404NotFound)]
        [ProducesResponseType(Status500InternalServerError)]
        public async Task<IActionResult> UpdateStudentAsync(Student studentDetails)
        {
            var isStudentDetailUpdated = await mediator.Send(new UpdateStudentCommand(
               studentDetails.Id,
               studentDetails.Name,
               studentDetails.Surname,
               studentDetails.PhoneNumber,
               studentDetails.PhoneName));
            return Ok(isStudentDetailUpdated);
        }

        [HttpDelete("delete/{id}")]
        [ProducesResponseType(Status200OK)]
        [ProducesResponseType(Status204NoContent)]
        [ProducesResponseType(Status400BadRequest)]
        [ProducesResponseType(Status404NotFound)]
        [ProducesResponseType(Status500InternalServerError)]
        public async Task<IActionResult> DeleteStudentAsync(int Id)
        {
            return Ok(await mediator.Send(new DeleteStudentCommand() { Id = Id }));
        }
    }
}
