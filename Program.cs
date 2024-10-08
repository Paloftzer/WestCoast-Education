using WestCoast_Education.models;

namespace WestCoast_Education;

public class Program
{
    static void Main()
    {
        Course Course = new();

        Course.AddCourse("1", "Math", 4, new DateTime(2022, 9, 1), new DateTime(2022, 12, 31));
        Course.AddCourse("2", "Science", 6, new DateTime(2022, 9, 1), new DateTime(2022, 12, 31));

        Course.ListCourses();
    }
}