using System.Security.Cryptography.X509Certificates;

namespace WestCoast_Education.models;

public class EducationManager : Teacher, IEntityManager<EducationManager>
{
    // for comments see Teacher.cs and Course.cs
    public DateTime DateOfEmployment { get; set; }

    public void AddEntity(EducationManager educationManager)
    {
        List<EducationManager> educationManagers = FileManager.ReadFromFile<EducationManager>();
        educationManagers.Add(educationManager);

        FileManager.WriteToFile(educationManagers);
    }

    public new List<EducationManager> ListEntities()
    {
        return FileManager.ReadFromFile<EducationManager>();
    }

    public override string ToString()
    {
        var courseTitles = string.Join(", ", AssignedCourses.Select(c => c.Title));
        return $"Education Manager Name: {FirstName} {LastName}, Address: {Address}, {PostalCode}, {City}, Contact Information: {PhoneNumber} - Area of Knowledge: {AreaOfKnowledge}, Assigned Courses: {courseTitles}, Date of Employment: {DateOfEmployment.ToShortDateString()}";
    }
}