using MediatR;

namespace PrivateLessonsPlannerApi.Commands
{
    public class UpdateStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public string PhoneName { get; set; }

        public UpdateStudentCommand(int id, string name, string surname, int phoneNumber, string phoneName)
        {
            Id = id;
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            PhoneName = phoneName;
        }
    }
}
