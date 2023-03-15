using MediatR;
using PrivateLessonsPlannerApi.Commands;
using PrivateLessonsPlannerApi.Repositories;

namespace PrivateLessonsPlannerApi.Handlers
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, int>
    {
        private readonly IStudentRepository _studentRepository;

        public UpdateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<int> Handle(UpdateStudentCommand command, CancellationToken cancellationToken)
        {
            var studentDetails = await _studentRepository.GetStudentByIdAsync(command.Id);
            if (studentDetails == null)
                return default;

            studentDetails.Name = command.Name;
            studentDetails.Surname = command.Surname;
            studentDetails.PhoneNumber = command.PhoneNumber;
            studentDetails.PhoneName = command.PhoneName;

            return await _studentRepository.UpdateStudentAsync(studentDetails);
        }
    }
}
