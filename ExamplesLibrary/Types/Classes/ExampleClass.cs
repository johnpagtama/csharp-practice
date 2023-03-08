using System;

namespace ExamplesLibrary.Types.Classes
{
    public class ExampleClass
    {
        private int CourseId { get; set; }
        private string CourseName { get; set; }
        private string Instructor { get; set; }
        private int Unit { get; set; }

        public ExampleClass()
        {
            CourseId = 0000;
            CourseName = "N/A";
            Instructor = "N/A";
            Unit = 0;
        }

        public ExampleClass(int courseId, string courseName, string instructor, int unit)
        {
            CourseId = courseId;
            CourseName = courseName;
            Instructor = instructor;
            Unit = unit;
        }

        public void DisplayCourseInfo()
        {
            Console.WriteLine($"Course ID: {CourseId}\nCourse Name: {CourseName}\nInstructor: {Instructor}\nUnits: {Unit}\n");
        }
    }
}
