namespace WestCoast_Education.models;

public class Course : IEntityManager<Course>
{
    public string CourseId { get; set; } = "";
    public string Title { get; set; } = "";
    public int DurationInWeeks { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public void AddEntity(Course course)
    {
        // Reads existing courses from json file so that old information doesn't get overwritten
        List<Course> courses = FileManager.ReadFromFile<Course>();
        courses.Add(course);

        // Writes the old information as well as the new information back into the file
        FileManager.WriteToFile(courses);
    }

    // Method to get all courses from the json file and return them as a list additionally needed for assigning courses to teachers
    public List<Course> ListEntities()
    {
        return FileManager.ReadFromFile<Course>();
    }

    // Basic ToString override to display information nicely
    public override string ToString()
    {
        return $"CourseId: {CourseId} - Title: {Title} - Duration {DurationInWeeks} weeks - Start Date: {StartDate.ToShortDateString()} - End Date: {EndDate.ToShortDateString()}";
    }
}