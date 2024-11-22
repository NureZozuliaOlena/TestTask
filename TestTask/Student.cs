namespace TestTask
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>();
        public double AverageGrade { get; set; }
        public Grant Grant { get; set; }

        public static List<Student> Fill()
        {
            return new List<Student>
            {
                new Student { Id = 1, FirstName = "Petro", SecondName = "Petrov", Age = 19 },
                new Student { Id = 2, FirstName = "Pavel", SecondName = "Bondarenko", Age = 21 },
                new Student { Id = 3, FirstName = "Maria", SecondName = "Petrenko", Age = 20 }
            };
        }

        public void SetSubjects(List<Subject> subjects)
        {
            Subjects = Subject.GetByStudentId(subjects, Id);
        }

        public void CalculateAverageGrade()
        {
            if (Subjects.Any())
            {
                AverageGrade = Subjects.Average(subject => subject.Grade);
            }
        }

        public void SetGrant()
        {
            if (AverageGrade < 60)
            {
                Grant = Grant.None;
            }
            else if (AverageGrade >= 60 && AverageGrade < 90)
            {
                Grant = Grant.Regular;
            }
            else
            {
                Grant = Grant.Increased;
            }
        }
    }
}
