using WestCoast_Education.models;

namespace WestCoast_Education;

public class Program
{
    static void Main()
    {
        Course Course = new();
        Student Student = new();

        // Yes, I know that the named arguments are unnecessary, but I like doing them because then I don't have to pay as much attention to the order I write them in
        Course.AddCourse(courseId:"1", title:"Math", durationInWeeks:10, startDate:DateTime.Now, endDate:DateTime.Now.AddDays(70));
        Course.AddCourse(courseId:"2", title:"Science", durationInWeeks:8, startDate:DateTime.Now, endDate:DateTime.Now.AddDays(56));

        Course.ListCourses();

        Student.AddStudent(firstName:"John", lastName:"Doe", phoneNumber:"0705555555", personalIdentityNumber:"12341122-1234", address:"Seventeenth Street", postalCode:"555 55", city:"Eighty-third City");

        Student.ListStudents();
    }
}