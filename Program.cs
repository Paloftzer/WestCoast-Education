using WestCoast_Education.models;

namespace WestCoast_Education;

public class Program
{
    static void Main()
    {
        List<Course> Course =
        [
            new Course { CourseId = "1", Title = "Math", DurationInWeeks = 10, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(70) },
            new Course { CourseId = "2", Title = "Science", DurationInWeeks = 8, StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(56) }

        ];

        FileManager.WriteToFile(Course);
    }
}