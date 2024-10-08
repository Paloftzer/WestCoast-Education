using WestCoast_Education.models;

namespace WestCoast_Education;

public class Program
{
    static void Main()
    {
        IEntityManager<Course> courseHandler = new Course();
        IEntityManager<Student> studentHandler = new Student();
        IEntityManager<Teacher> teacherHandler = new Teacher();
        IEntityManager<EducationManager> educationManagerHandler = new EducationManager();
        IEntityManager<Administrator> administratorHandler = new Administrator();

        /* Course Handling */
        Course newCourse = new Course
        {
            CourseId = "1",
            Title = "Math",
            DurationInWeeks = 10,
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(70)
        };

        courseHandler.AddEntity(newCourse);

        newCourse = new Course
        {
            CourseId = "2",
            Title = "Science",
            DurationInWeeks = 8,
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(56)
        };

        courseHandler.AddEntity(newCourse);

        newCourse = new Course
        {
            CourseId = "3",
            Title = "History",
            DurationInWeeks = 6,
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(42)
        };

        courseHandler.AddEntity(newCourse);

        List<Course> allCourses = courseHandler.ListEntities();
        foreach (var course in allCourses)
        {
            Console.WriteLine(course);
        }

        /* Student Handling */
        Student newStudent = new()
        {
            FirstName = "John",
            LastName = "Doe",
            PhoneNumber = "0705555555",
            PersonalIdentityNumber = "12341122-1234",
            Address = "Seventeenth Street",
            PostalCode = "555 55",
            City = "Eighty-third City",
        };

        studentHandler.AddEntity(newStudent);

        List<Student> allStudents = studentHandler.ListEntities();
        foreach (var student in allStudents)
        {
            Console.WriteLine(student);
        }

        /* Teacher Handling */
        List<Course> specificCourses = allCourses.Where(c => c.CourseId == "1" || c.CourseId == "2").ToList();

        Teacher newTeacher = new()
        {
            FirstName = "Jane",
            LastName = "Doe",
            PhoneNumber = "0707777777",
            PersonalIdentityNumber = "43212211-4321",
            Address = "Eighty-third Street",
            PostalCode = "777 77",
            City = "Seventeenth City",
            AreaOfKnowledge = "Math & Science",
            AssignedCourses = specificCourses
        };

        teacherHandler.AddEntity(newTeacher);

        List<Teacher> allTeachers = teacherHandler.ListEntities();
        foreach (var teacher in allTeachers)
        {
            Console.WriteLine(teacher);
        }

        /* EducationManager Handling */
        specificCourses = allCourses.Where(c => c.CourseId == "3").ToList();

        EducationManager newEducationManager = new()
        {
            FirstName = "Hjon", 
            LastName = "Doe", 
            PhoneNumber = "0703333333", 
            PersonalIdentityNumber = "11221234-1234", 
            Address = "Fifty-second Street", 
            PostalCode = "333 33", 
            City = "Forty-first City", 
            AreaOfKnowledge = "History", 
            AssignedCourses = specificCourses, 
            DateOfEmployment = DateTime.Now
        };

        educationManagerHandler.AddEntity(newEducationManager);

        List<EducationManager> allEducationManagers = educationManagerHandler.ListEntities();
        foreach (var educationManager in allEducationManagers)
        {
            Console.WriteLine(educationManager);
        }

        specificCourses = allCourses.Where(c => c.CourseId == "2" || c.CourseId == "3").ToList();

        Administrator newAdministrator = new()
        {
            FirstName = "Jan",
            LastName = "Doe",
            PhoneNumber = "0709999999",
            PersonalIdentityNumber = "22114321-4321",
            Address = "Forty-first Street",
            PostalCode = "999 99",
            City = "Fifty-second City",
            AreaOfKnowledge = "Science & History",
            AssignedCourses = specificCourses,
            DateOfEmployment = DateTime.Now
        };

        administratorHandler.AddEntity(newAdministrator);

        List<Administrator> allAdministrators = administratorHandler.ListEntities();
        foreach (var administrator in allAdministrators)
        {
            Console.WriteLine(administrator);
        }
    }
}