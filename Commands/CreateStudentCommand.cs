using MediatR;
using PrivateLessonsPlannerApi.Models;

namespace PrivateLessonsPlannerApi.Commands
{
    public class CreateStudentCommand : IRequest<Student>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public string PhoneName { get; set; }

        public CreateStudentCommand(string name, string surname, int phoneNumber, string phoneName)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            PhoneName = phoneName;
        }
    }
}
