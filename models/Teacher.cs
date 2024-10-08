namespace WestCoast_Education.models;

public class Teacher : Person
{
    public string SubjectName { get; set; } = "";
    public List<Course> Courses { get; set; } = [];

    public void AddTeacher(string placeholder)
    {

    }
}