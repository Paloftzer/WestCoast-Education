namespace WestCoast_Education.models;

public class Course
{
    public string CourseId { get; set; } = "";
    public string Title { get; set; } = "";
    public int DurationInWeeks { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public void AddCourse(string courseId, string title, int durationInWeeks, DateTime startDate, DateTime endDate)
    {
        // Reads existing courses from json file so that old information doesn't get overwritten
        List<Course> Course = FileManager.ReadFromFile<Course>();
        Course.Add(new Course { CourseId = courseId, Title = title, DurationInWeeks = durationInWeeks, StartDate = startDate, EndDate = endDate });

        // Writes the old information as well as the new information back into the file
        FileManager.WriteToFile(Course);
    }
}