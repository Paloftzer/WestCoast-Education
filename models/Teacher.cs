namespace WestCoast_Education.models;

public class Teacher : Person, IEntityManager<Teacher>
{
    // For (most) comments see Course.cs
    public string AreaOfKnowledge { get; set; } = "";
    public List<Course> AssignedCourses { get; set; } = [];

    public void AddEntity(Teacher teacher)
    {
        List<Teacher> teachers = FileManager.ReadFromFile<Teacher>();
        teachers.Add(teacher);
        FileManager.WriteToFile(teachers);
    }

    public List<Teacher> ListEntities()
    {
        return FileManager.ReadFromFile<Teacher>();
    }

    public override string ToString()
    {
        // Creates a variable to hold the joined string of courses that have been assigned to the teacher
        var courseTitles = string.Join(", ", AssignedCourses.Select(c => c.Title));
        return $"Teacher Name: {FirstName} {LastName}, Address: {Address}, {PostalCode}, {City}, Contact Information: {PhoneNumber} - Area of Knowledge: {AreaOfKnowledge}, Assigned Courses: {courseTitles}";
    }
}