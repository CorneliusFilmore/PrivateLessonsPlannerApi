using Microsoft.EntityFrameworkCore;
using PrivateLessonsPlannerApi.Data;
using PrivateLessonsPlannerApi.Models;

namespace PrivateLessonsPlannerApi.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DbContextClass _dbContext;
        public StudentRepository(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Student> AddStudentAsync(Student student)
        {
            var result = _dbContext.Students.Add(student);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteStudentAsync(int id)
        {
            var filteredData = _dbContext.Students.Where(x => x.Id == id).FirstOrDefault();
            _dbContext.Students.Remove(filteredData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await _dbContext.Students.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Student>> GetStudentListAsync()
        {
            return await _dbContext.Students.ToListAsync();
        }

        public async Task<int> UpdateStudentAsync(Student student)
        {
            _dbContext.Students.Update(student);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
