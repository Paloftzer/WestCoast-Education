namespace WestCoast_Education.models;

public class Administrator : EducationManager, IEntityManager<Administrator>
{
    public void AddEntity(Administrator administrator)
    {
        List<Administrator> administrators = FileManager.ReadFromFile<Administrator>();
        administrators.Add(administrator);

        FileManager.WriteToFile(administrators);
    }

    public new List<Administrator> ListEntities()
    {
        return FileManager.ReadFromFile<Administrator>();
    }

    public override string ToString()
    {
        var courseTitles = string.Join(", ", AssignedCourses.Select(c => c.Title));
        return $"Administrator Name: {FirstName} {LastName}, Address: {Address}, {PostalCode}, {City}, Contact Information: {PhoneNumber} - Area of Knowledge: {AreaOfKnowledge}, Assigned Courses: {courseTitles}, Date of Employment: {DateOfEmployment.ToShortDateString()}";
    }
}