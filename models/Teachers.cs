namespace WestCoast_Education.models;

public class Teachers : Students
{
    public string SubjectName { get; set; } = "";
    public string OwnedCourses { get; set; } = ""; // Potentially change this name aswell since it also sounds stupid
}
