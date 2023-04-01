namespace PrivateLessonsPlannerApi.Models
{
    public class Student : BaseModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneName { get; set; }

    }
}
