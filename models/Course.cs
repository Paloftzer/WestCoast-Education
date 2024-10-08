namespace WestCoast_Education.models;

public class Course
{
    public string CourseId { get; set; } = "";
    public string Title { get; set; } = "";
    public int LengthInWeeks { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public List<Course> Courses { get; set; } = [];

    public void AddCourse(string courseId, string title, int lengthInWeeks, DateTime startDate, DateTime endDate)
    {
        Course newCourse = new()
        {
            CourseId = courseId,
            Title = title,
            LengthInWeeks = lengthInWeeks,
            StartDate = startDate,
            EndDate = endDate,
        };

        Courses.Add(newCourse);

        // Append the new course to a json file
    }

    public void ListCourses(int courseId)
    {
        Console.WriteLine("List of available Courses:");

        foreach (var c in Courses)
        {
            Console.WriteLine(ToString());
        }
    }

    public override string ToString()
    {
        return $"CourseID: {CourseId} - Title: {Title} - Length: {LengthInWeeks} weeks - Start Date: {StartDate.ToShortDateString()} - End Date: {EndDate.ToShortDateString()}";
    }
}