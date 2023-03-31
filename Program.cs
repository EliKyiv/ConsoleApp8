// See https://aka.ms/new-console-template for more information
using MyProgram;
using System.Transactions;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Student student1 = new Student();
            student1.Name = "Porky";
            student1.Lastname = "Pig";
            student1.Age = 1;
            student1.City = "San Diego";
            student1.Year = "Freshman";

            student1.CourseList.Add("C#");
            student1.CourseList.Add("PE");
            student1.CourseList.Add("Etiquette");

            student1.DescribeYourself();

            Student student2 = new Student();
            student2.Name = "Bugs";
            student2.Lastname = "Bunny";
            student2.Age = 1;
            student2.City = "Tijuana";
            student2.Year = "Sophomore";

            student2.CourseList.Add("C#");
            student2.CourseList.Add("PE");
            student2.CourseList.Add("Javascript");

            student2.DescribeYourself();

            Teacher teacher1 = new Teacher();
            teacher1.Name = "John";
            teacher1.Lastname = "Wick";
            teacher1.Age = 40;
            teacher1.City = "San Diego";
            teacher1.Position = "Tenured";

            teacher1.StudentList.Add("Porky Pig");
            teacher1.StudentList.Add("Bugs Bunny");
            teacher1.StudentList.Add("Daffy Duck");

            teacher1.CourseList.Add("C#");
            teacher1.CourseList.Add("Javascript");

            teacher1.DescribeYourself();

            Teacher teacher2 = new Teacher();
            teacher2.Name = "Samus";
            teacher2.Lastname = "Aran";
            teacher2.Age = 19;
            teacher2.City = "Los Angeles";
            teacher2.Position = "Visiting";

            teacher2.StudentList.Add("Elmer Fudd");
            teacher2.StudentList.Add("Road Runner");
            teacher2.StudentList.Add("Yosemite Sam");

            teacher2.CourseList.Add("PE");
            teacher2.CourseList.Add("Etiquette");

            teacher2.DescribeYourself();

            Course course1 = new Course();
            course1.Name = "C#";
            course1.Teacher = "John Wick";
            course1.Duration = 18;
            course1.StudentsQty = 3;

            course1.StudentList.Add("Porky Pig");
            course1.StudentList.Add("Bugs Bunny");
            course1.StudentList.Add("Daffy Duck");

            course1.Print();

            Course course2 = new Course();
            course2.Name = "PE";
            course2.Teacher = "Samus Aran";
            course2.Duration = 24;
            course2.StudentsQty = 3;

            course2.StudentList.Add("Elmer Fudd");
            course2.StudentList.Add("Road Runner");
            course2.StudentList.Add("Yosemite Sam");

            course2.Print();

            //List<string> teachers = new List<string>();
            //teachers.Add(teacher1.Name);
            //teachers.Add(teacher2.Name);

            //Console.WriteLine("Enter teacher's name:");
            //var sname = Console.ReadLine();
            //string[] arr = teachers.ToArray();
            //var list1 = from p in arr
            //            select p;
            //foreach (var item in list1)
            //    Console.WriteLine(item);
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        finally
        {
            Console.WriteLine("\nThe 'try catch' is finished.");
        }
    }
}

namespace MyProgram
{

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }

        public virtual void DescribeYourself()
        {
            Console.WriteLine("\n====================");
            System.Console.WriteLine($"Age = {Age}");
            System.Console.WriteLine($"Name = {Name}");
            System.Console.WriteLine($"Lastname = {Lastname}");
            System.Console.WriteLine($"City = {City}");
        }
    }

    public class Student : Person
    {
        public string Year { get; set; }
        public List<string> CourseList = new List<string>();
        public override void DescribeYourself()
        {
            base.DescribeYourself();
            System.Console.WriteLine($"Year = {Year}");
            Console.WriteLine("Courses:");
            this.CourseList.ForEach(Console.WriteLine);
        }
    }

    public class Teacher : Person
    {
        public string Position { get; set; }
        public List<string> StudentList = new List<string>();
        public List<string> CourseList = new List<string>();
        public override void DescribeYourself()
        {
            base.DescribeYourself();
            System.Console.WriteLine($"Position = {Position}");
            Console.WriteLine("Students:");
            this.StudentList.ForEach(Console.WriteLine);
            Console.WriteLine("Courses:");
            this.CourseList.ForEach(Console.WriteLine);
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public int Duration { get; set; }
        public int StudentsQty { get; set; }
        public List<string> StudentList = new List<string>();
        public void Print()
        {
            Console.WriteLine("\n====================");
            Console.WriteLine(Name);
            Console.WriteLine(Teacher);
            Console.WriteLine(Duration);
            Console.WriteLine(StudentsQty);
            StudentList.ForEach(Console.WriteLine);
        }

        public Course()
        {
            Name = string.Empty;
            Teacher = string.Empty;
            Duration = 0;
            StudentsQty = 0;
        }

        public Course(string name, string teacher, int duration, int studentsQty)
        {
            Name = name;
            Teacher = teacher;
            Duration = duration;
            StudentsQty = studentsQty;
        }

    }
}

