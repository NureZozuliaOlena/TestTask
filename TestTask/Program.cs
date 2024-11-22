using System.Text;

namespace TestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subjects = Subject.Fill();
            var students = Student.Fill();

            foreach (var student in students)
            {
                student.SetSubjects(subjects);
                student.CalculateAverageGrade();
                student.SetGrant();
            }

            foreach (var student in students)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Student: {student.FirstName} {student.SecondName}");
                sb.AppendLine($"Age: {student.Age}");
                sb.AppendLine($"Average Grade: {student.AverageGrade:f2}");
                sb.AppendLine($"Grant: {student.Grant}");
                sb.AppendLine("Subjects:");

                foreach (var subject in student.Subjects)
                {
                    sb.AppendLine($" - {subject.Name}: {subject.Grade} ({subject.Date.ToShortDateString()})");
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}
