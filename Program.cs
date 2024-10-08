using WestCoast_Education.models;

namespace WestCoast_Education;

public class Program
{
    static void Main()
    {
        Course Course = new();
        Student Student = new();
        Teacher Teacher = new();

        // Yes, I know that the named arguments are unnecessary, but I like doing them because then I don't have to pay as much attention to the order I write them in
        Course.AddCourse(courseId:"1", title:"Math", durationInWeeks:10, startDate:DateTime.Now, endDate:DateTime.Now.AddDays(70));
        Course.AddCourse(courseId:"2", title:"Science", durationInWeeks:8, startDate:DateTime.Now, endDate:DateTime.Now.AddDays(56));
        Course.AddCourse(courseId: "3", title: "History", durationInWeeks: 6, startDate: DateTime.Now, endDate: DateTime.Now.AddDays(42));

        Course.ListCourses();

        Student.AddStudent(firstName:"John", lastName:"Doe", phoneNumber:"0705555555", personalIdentityNumber:"12341122-1234", address:"Seventeenth Street", postalCode:"555 55", city:"Eighty-third City");

        Student.ListStudents();

        // Retrieves a list of all courses
        List<Course> allCourses = Course.GetAllCourses();
        // Select specific courses based on their CourseId so that I can assign them to teachers without having to assign EVERY course, in this case specifically the courses with CourseId 1 and 2 I.e Math and Science
        List<Course> specificCourses = allCourses.Where(c => c.CourseId == "1" || c.CourseId == "2").ToList();

        Teacher.AddTeacher(firstName:"Jane", lastName:"Doe", phoneNumber:"0707777777", personalIdentityNumber:"43212211-4321", address:"Eighty-third Street", postalCode:"777 77", city:"Seventeenth City", areaOfKnowledge:"Math", assignedCourses:specificCourses);

        Teacher.ListTeachers();

        specificCourses = allCourses.Where(c => c.CourseId == "3").ToList();

        EducationManager.AddEducationManager(firstName:"Jane", lastName:"Doe", phoneNumber:"0707777777", personalIdentityNumber:"43212211-4321", address:"Eighty-third Street", postalCode:"777 77", city:"Seventeenth City", areaOfKnowledge:"Math", assignedCourses:specificCourses, dateOfEmployment:DateTime.Now);

        EducationManager.ListEducationManagers();
    }
}