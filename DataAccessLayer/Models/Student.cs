namespace MVCProject.DataAccessLayer.Models
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public ICollection<TeacherStudent> TeacherStudents { get; set; } = new List<TeacherStudent>();


    }
}
