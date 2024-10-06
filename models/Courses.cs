namespace WestCoast_Education.models;

public class Courses
{
    public int CourseId { get; set; }
    public string Title { get; set; } = "";
    public int Length { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public void AddCourse(int courseId, string title, int length, DateTime startDate, DateTime endDate)
    {
        CourseId = courseId;
        Title = title;
        Length = length;
        StartDate = startDate;
        EndDate = endDate;
    }
}