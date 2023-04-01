using MediatR;
using PrivateLessonsPlannerApi.Models;

namespace PrivateLessonsPlannerApi.Commands
{
    public class CreateStudentCommand : IRequest<Student>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneName { get; set; }

        public CreateStudentCommand(string name, string surname, string phoneNumber, string phoneName)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            PhoneName = phoneName;
        }
    }
}
