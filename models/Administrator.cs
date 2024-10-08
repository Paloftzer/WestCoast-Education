namespace WestCoast_Education.models;

public class Administrator : EducationManager
{
    public static void AddAdministrator(string firstName, string lastName, string phoneNumber, string personalIdentityNumber, string address, string postalCode, string city, string areaOfKnowledge, List<Course> assignedCourses, DateTime dateOfEmployment)
    {
        List<Administrator> Administrator = FileManager.ReadFromFile<Administrator>();
        Administrator.Add(new Administrator { FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber, PersonalIdentityNumber = personalIdentityNumber, Address = address, PostalCode = postalCode, City = city, AreaOfKnowledge = areaOfKnowledge, AssignedCourses = assignedCourses, DateOfEmployment = dateOfEmployment });

        FileManager.WriteToFile(Administrator);
    }

    public static void ListAdministrators()
    {
        List<Administrator> Administrators = FileManager.ReadFromFile<Administrator>();
        Console.WriteLine("List of all Administrators:");

        foreach (var administrator in Administrators)
        {
            Console.WriteLine(administrator.ToString());
        }
    }

    public override string ToString()
    {
        var courseTitles = string.Join(", ", AssignedCourses.Select(c => c.Title));
        return $"Name: {FirstName} {LastName}, Address: {Address}, {PostalCode}, {City}, Contact Information: {PhoneNumber} - Area of Knowledge: {AreaOfKnowledge}, Assigned Courses: {courseTitles}, Date of Employment: {DateOfEmployment.ToShortDateString()}";
    }
}