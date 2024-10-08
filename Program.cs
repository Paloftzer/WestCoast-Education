using WestCoast_Education.models;

namespace WestCoast_Education;

public class Program
{
    static void Main()
    {
        IEntityManager<Course> courseManager = new Course();
        // IEntityManager<Student> studentManager = new Student();
        IEntityManager<Teacher> teacherManager = new Teacher();
        // IEntityManager<EducationManager> educationManager = new EducationManager();
        // IEntityManager<Administrator> administratorManager = new Administrator();

        Course newCourse = new Course
        {
            CourseId = "1",
            Title = "Math",
            DurationInWeeks = 10,
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(70)
        };

        courseManager.AddEntity(newCourse);

        newCourse = new Course
        {
            CourseId = "2",
            Title = "Science",
            DurationInWeeks = 8,
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(56)
        };

        courseManager.AddEntity(newCourse);

        newCourse = new Course
        {
            CourseId = "3",
            Title = "History",
            DurationInWeeks = 6,
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(42)
        };

        courseManager.AddEntity(newCourse);

        List<Course> allCourses = courseManager.ListEntities();
        foreach (var course in allCourses)
        {
            Console.WriteLine(course);
        }

        List<Course> specificCourses = allCourses.Where(c => c.CourseId == "1" || c.CourseId == "2").ToList();

        Teacher newTeacher = new()
        {
            FirstName = "John",
            LastName = "Doe",
            PhoneNumber = "0705555555",
            PersonalIdentityNumber = "12341122-1234",
            Address = "Seventeenth Street",
            PostalCode = "555 55",
            City = "Eighty-third City",
            AreaOfKnowledge = "Math & Science",
            AssignedCourses = specificCourses
        };

        teacherManager.AddEntity(newTeacher);

        List<Teacher> allTeachers = teacherManager.ListEntities();
        foreach (var teacher in allTeachers)
        {
            Console.WriteLine(teacher);
        }

        /*
        Student.AddStudent(firstName:"John", lastName:"Doe", phoneNumber:"0705555555", personalIdentityNumber:"12341122-1234", address:"Seventeenth Street", postalCode:"555 55", city:"Eighty-third City");

        Student.ListStudents();

        // Retrieves a list of all courses
        List<Course> allCourses = Course.GetAllCourses();
        // Select specific courses based on their CourseId so that I can assign them to teachers without having to assign EVERY course, in this case specifically the courses with CourseId 1 and 2 I.e Math and Science
        List<Course> specificCourses = allCourses.Where(c => c.CourseId == "1" || c.CourseId == "2").ToList();

        Teacher.AddTeacher(firstName:"Jane", lastName:"Doe", phoneNumber:"0707777777", personalIdentityNumber:"43212211-4321", address:"Eighty-third Street", postalCode:"777 77", city:"Seventeenth City", areaOfKnowledge:"Math & Science", assignedCourses:specificCourses);

        Teacher.ListTeachers();

        specificCourses = allCourses.Where(c => c.CourseId == "3").ToList();

        EducationManager.AddEducationManager(firstName:"Hjon", lastName:"Doe", phoneNumber:"0703333333", personalIdentityNumber:"11221234-1234", address:"Fifty-second Street", postalCode:"333 33", city:"Forty-first City", areaOfKnowledge:"History", assignedCourses:specificCourses, dateOfEmployment:DateTime.Now);

        EducationManager.ListEducationManagers();

        specificCourses = allCourses.Where(c => c.CourseId == "2" || c.CourseId == "3").ToList();

        Administrator.AddAdministrator(firstName:"Jan", lastName:"Doe", phoneNumber:"0709999999", personalIdentityNumber:"22114321-4321", address:"Forty-first Street", postalCode:"999 99", city:"Fifty-second City", areaOfKnowledge:"Science & History", assignedCourses:specificCourses, dateOfEmployment:DateTime.Now);

        Administrator.ListAdministrators(); */
    }
}