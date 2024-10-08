namespace WestCoast_Education.models;

public class Student : Person, IEntityManager<Student>
{
    // for comments see Course.cs it is the original file and most of the other files will be nearly identical
    public void AddEntity(Student student)
    {
        List<Student> students = FileManager.ReadFromFile<Student>();
        students.Add(student);
        FileManager.WriteToFile(students);
    }

    public List<Student> ListEntities()
    {
        return FileManager.ReadFromFile<Student>();
    }

    public override string ToString()
    {
        return $"Student Name: {FirstName} {LastName}, Address: {Address}, {PostalCode}, {City}, Contact Information: {PhoneNumber}";
    }
}