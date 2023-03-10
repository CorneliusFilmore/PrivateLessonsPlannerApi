namespace PrivateLessonsPlannerApi.Models
{
    public class PrivateLesson : BaseModel
    {
        public float Duration { get; set; }
        public string ClassLevel { get; set; }
        public Student Student { get; set; }
        public List<HomeWork> HomeWork { get; set; }
        public DateTime Date { get; set; }
    }
}
