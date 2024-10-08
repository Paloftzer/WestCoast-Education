namespace WestCoast_Education.models;

public class Student : Person
{
    // for comments see Course.cs it is the original file and most of the other files will be nearly identical
    public static void AddStudent(string firstName, string lastName, string phoneNumber, string personalIdentityNumber, string address, string postalCode, string city)
    {
        List<Student> Student = FileManager.ReadFromFile<Student>();
        Student.Add(new Student { FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber, PersonalIdentityNumber = personalIdentityNumber, Address = address, PostalCode = postalCode, City = city });

        FileManager.WriteToFile(Student);
    }

    public static void ListStudents()
    {
        List<Student> students = FileManager.ReadFromFile<Student>();
        Console.WriteLine("List of all attending Students:");

        foreach (var student in students)
        {
            Console.WriteLine(student.ToString());
        }
    }

    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}, Address: {Address}, {PostalCode}, {City}, Contact Information: {PhoneNumber}";
    }
}