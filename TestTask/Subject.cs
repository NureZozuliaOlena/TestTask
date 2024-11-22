namespace TestTask
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }

        public static List<Subject> Fill()
        {
            return new List<Subject>
            {
                new Subject { Id = 1, Name = "Math", StudentId = 1, Grade = 100, Date = DateTime.Now.AddDays(-1) },
                new Subject { Id = 2, Name = "History", StudentId = 2, Grade = 100, Date = DateTime.Now.AddDays(-2) },
                new Subject { Id = 3, Name = "Physics", StudentId = 3, Grade = 50, Date = DateTime.Now.AddDays(-3) },
                new Subject { Id = 4, Name = "Chemistry", StudentId = 1, Grade = 80, Date = DateTime.Now.AddDays(-4) },
                new Subject { Id = 5, Name = "Biology", StudentId = 2, Grade = 90, Date = DateTime.Now.AddDays(-5) },
                new Subject { Id = 6, Name = "Literature", StudentId = 3, Grade = 40, Date = DateTime.Now.AddDays(-6) },
                new Subject { Id = 7, Name = "Computer Science", StudentId = 1, Grade = 70, Date = DateTime.Now.AddDays(-7) }
            };
        }

        public static List<Subject> GetByStudentId(List<Subject> subjects, int studentId)
        {
            return subjects.Where(subject => subject.StudentId == studentId).ToList();
        }
    }
}
