using MediatR;
using PrivateLessonsPlannerApi.Models;

namespace PrivateLessonsPlannerApi.Queries
{
    public class GetStudentListQuery : IRequest<List<Student>>
    {
    }
}
