namespace WestCoast_Education.models;

public class Course
{
    public string CourseId { get; set; } = "";
    public string Title { get; set; } = "";
    public int DurationInWeeks { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public List<Course> Courses { get; set; } = [];

    /* public void AddCourse(string courseId, string title, int durationInWeeks, DateTime startDate, DateTime endDate)
    {
        Course newCourse = new()
        {
            CourseId = courseId,
            Title = title,
            DurationInWeeks = durationInWeeks,
            StartDate = startDate,
            EndDate = endDate,
        };

        Courses.Add(newCourse);
    } */

    // Will be unnecessary when I've finished implementing reading and writing from and to files
    /* public void ListCourses()
    {
        Console.WriteLine("List of available Courses:");

        foreach (var course in Courses)
        {
            Console.WriteLine(course.ToString());
        }
    }

    public override string ToString()
    {
        return $"CourseID: {CourseId} - Title: {Title} - Duration: {DurationInWeeks} weeks - Start Date: {StartDate.ToShortDateString()} - End Date: {EndDate.ToShortDateString()}";
    } */
}