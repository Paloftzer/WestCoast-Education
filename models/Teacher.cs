namespace WestCoast_Education.models;

public class Teacher : Person
{
    // For (most) comments see Course.cs
    public string AreaOfKnowledge { get; set; } = "";
    public List<Course> AssignedCourses { get; set; } = [];

    public void AddTeacher(string firstName, string lastName, string phoneNumber, string personalIdentityNumber, string address, string postalCode, string city, string areaOfKnowledge, List<Course> assignedCourses)
    {
        List<Teacher> Teacher = FileManager.ReadFromFile<Teacher>();
        Teacher.Add(new Teacher { FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber, PersonalIdentityNumber = personalIdentityNumber, Address = address, PostalCode = postalCode, City = city, AreaOfKnowledge = areaOfKnowledge, AssignedCourses = assignedCourses });

        FileManager.WriteToFile(Teacher);
    }

    /* public void AssignCourse(Course course)
    {
        AssignedCourses.Add(course);
    } */

    public static void ListTeachers()
    {
        List<Teacher> Teachers = FileManager.ReadFromFile<Teacher>();
        Console.WriteLine("List of Teachers:");

        foreach (var teacher in Teachers)
        {
            Console.WriteLine(teacher.ToString());
        }
    }

    public override string ToString()
    {
        var courseTitles = string.Join(", ", AssignedCourses.Select(c => c.Title));
        return $"Name: {FirstName} {LastName}, Address: {Address}, {PostalCode}, {City}, Contact Information: {PhoneNumber} - Area of Knowledge: {AreaOfKnowledge}, Assigned Courses: {courseTitles}";
    }
}