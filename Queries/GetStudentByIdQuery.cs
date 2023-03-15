using MediatR;
using PrivateLessonsPlannerApi.Models;

namespace PrivateLessonsPlannerApi.Queries
{
    public class GetStudentByIdQuery : IRequest<Student>
    {
        public int Id { get; set; }
    }
}
