using WestCoast_Education.models;

namespace WestCoast_Education;

public class Program
{
    static void Main()
    {
        Course Course = new();

        Course.AddCourse(courseId:"1", title:"Math", durationInWeeks:10, startDate:DateTime.Now, endDate:DateTime.Now.AddDays(70));
        Course.AddCourse(courseId:"2", title:"Science", durationInWeeks:8, startDate:DateTime.Now, endDate:DateTime.Now.AddDays(56));

        Course.ListCourses();
    }
}