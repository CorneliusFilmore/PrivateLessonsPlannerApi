using MediatR;
using PrivateLessonsPlannerApi.Commands;
using PrivateLessonsPlannerApi.Models;
using PrivateLessonsPlannerApi.Repositories;

namespace PrivateLessonsPlannerApi.Handlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, Student>
    {
        private readonly IStudentRepository _studentRepository;

        public CreateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<Student> Handle(CreateStudentCommand command, CancellationToken cancellationToken)
        {
            var studentDetails = new Student()
            {
                Name = command.Name,
                Surname = command.Surname,
                PhoneNumber = command.PhoneNumber,
                PhoneName = command.PhoneName
            };

            return await _studentRepository.AddStudentAsync(studentDetails);
        }
    }
}
