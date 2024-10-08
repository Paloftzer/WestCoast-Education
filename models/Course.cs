namespace WestCoast_Education.models;

public class Course
{
    public string CourseId { get; set; } = "";
    public string Title { get; set; } = "";
    public int DurationInWeeks { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public static void AddCourse(string courseId, string title, int durationInWeeks, DateTime startDate, DateTime endDate)
    {
        // Reads existing courses from json file so that old information doesn't get overwritten
        List<Course> Course = FileManager.ReadFromFile<Course>();
        Course.Add(new Course { CourseId = courseId, Title = title, DurationInWeeks = durationInWeeks, StartDate = startDate, EndDate = endDate });

        // Writes the old information as well as the new information back into the file
        FileManager.WriteToFile(Course);
    }

    // Method to get all courses from the json file and return them as a list specifically needed for assigning courses to teachers
    public static List<Course> GetAllCourses()
    {
        return FileManager.ReadFromFile<Course>();
    }

    public static void ListCourses()
    {
        // Reads existing courses from json file
        List<Course> courses = FileManager.ReadFromFile<Course>();
        Console.WriteLine("List of available Courses:");

        foreach (var course in courses)
        {
            // Writes the course to the console formatted according to the ToString override
            Console.WriteLine(course.ToString());
        }
    }

    // Basic ToString override to display information nicely
    public override string ToString()
    {
        return $"CourseId: {CourseId} - Title: {Title} - Duration {DurationInWeeks} weeks - Start Date: {StartDate.ToShortDateString()} - End Date: {EndDate.ToShortDateString()}";
    }
}