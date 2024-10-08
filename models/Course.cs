﻿namespace WestCoast_Education.models;

public class Course
{
    public string CourseId { get; set; } = "";
    public string Title { get; set; } = "";
    public int DurationInWeeks { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public List<Course> Courses { get; set; } = [];

    public void AddCourse(string courseId, string title, int durationInWeeks, DateTime startDate, DateTime endDate)
    {
        Course newCourse = new()
        {
            CourseId = courseId,
            Title = title,
            DurationInWeeks = durationInWeeks,
            StartDate = startDate,
            EndDate = endDate,
        };

        Courses.Add(newCourse);

        // Append the new course to a json file
    }

    public void ListCourses(int courseId)
    {
        Console.WriteLine("List of available Courses:");

        foreach (var c in Courses)
        {
            Console.WriteLine(ToString());
        }
    }

    public override string ToString()
    {
        return $"CourseID: {CourseId} - Title: {Title} - Duration: {DurationInWeeks} weeks - Start Date: {StartDate.ToShortDateString()} - End Date: {EndDate.ToShortDateString()}";
    }
}