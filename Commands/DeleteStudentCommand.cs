using MediatR;

namespace PrivateLessonsPlannerApi.Commands
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
