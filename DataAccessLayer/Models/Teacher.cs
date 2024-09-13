namespace MVCProject.DataAccessLayer.Models
{
    public class Teacher : BaseEntity
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public ICollection<TeacherStudent> TeacherStudents { get; set; } = new List<TeacherStudent>();

    }
}
