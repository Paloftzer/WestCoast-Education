using System.Security.Cryptography.X509Certificates;

namespace WestCoast_Education.models;

public class EducationManager : Teacher
{
    // for comments see Teacher.cs and Course.cs
    public DateTime DateOfEmployment { get; set; }

    public static void AddEducationManager(string firstName, string lastName, string phoneNumber, string personalIdentityNumber, string address, string postalCode, string city, string areaOfKnowledge, List<Course> assignedCourses, DateTime dateOfEmployment)
    {
        List<EducationManager> EducationManager = FileManager.ReadFromFile<EducationManager>();
        EducationManager.Add(new EducationManager { FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber, PersonalIdentityNumber = personalIdentityNumber, Address = address, PostalCode = postalCode, City = city, AreaOfKnowledge = areaOfKnowledge, AssignedCourses = assignedCourses, DateOfEmployment = dateOfEmployment });

        FileManager.WriteToFile(EducationManager);
    }

    public static void ListEducationManagers()
    {
        List<EducationManager> educationManagers = FileManager.ReadFromFile<EducationManager>();
        Console.WriteLine("List of all Education Managers:");

        foreach (var educationManager in educationManagers)
        {
            Console.WriteLine(educationManager.ToString());
        }
    }

    public override string ToString()
    {
        var courseTitles = string.Join(", ", AssignedCourses.Select(c => c.Title));
        return $"Name: {FirstName} {LastName}, Address: {Address}, {PostalCode}, {City}, Contact Information: {PhoneNumber} - Area of Knowledge: {AreaOfKnowledge}, Assigned Courses: {courseTitles}, Date of Employment: {DateOfEmployment.ToShortDateString()}";
    }
}