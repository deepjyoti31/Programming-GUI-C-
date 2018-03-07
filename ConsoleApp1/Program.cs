using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student();
            p.Name = "John";
            p.Surname = "Idiot";
            p.Age = 22;
            // p.DateOfBirth = 31 / 12 / 1995;
            //  p.Gender = Male;
            p.IndexNum = 1234;
            Course.StudentsList1.Add(p);

            Course course = new Course();
            course.Name = "GUI applications";
            course.StudentsList1 = new List<Student>();
        }
    }

    public enum Gender { Male, Female }
    public enum Direction { Right, Left }

    public class Person
    {
        private string name;
        private string surname;
        private int age;
        private DateTime dateOfBirth;
        private Gender gender;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public Gender Gender { get => gender; set => gender = value; }

        public override string ToString()
        {
            return String.Format("{0} {1}, age={2}, gender={3}", Name, Surname, Age, Gender);
        }
    }

    public class Employee : Person
    {
        private string title;
        private string description;

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
    }

    public class Student : Person
    {
        private int indexNum;
        private Direction direction;

        public int IndexNum { get => indexNum; set => indexNum = value; }
        public Direction Direction { get => direction; set => direction = value; }

        public override string ToString()
        {
            return base.ToString() + " index: " + IndexNum;
        }
    }

    public class Course
    {
        private string name;
        private List<Student> StudentsList;
        private Employee employee;


        public string Name { get => name; set => name = value; }
        public List<Student> StudentsList1 { get => StudentsList; set => StudentsList = value; }
        public Employee Employee { get => employee; set => employee = value; }

        public void DisplayStudents()
        {
            foreach(Student s in StudentsList)
            {
                Console.WriteLine(s);
            }
        }

        public override string ToString()
        {
            return name + "  " + Employee;
        }
    }

    public class CourseAssessment
    {
        private Student student;
        private Course course;
        private double assessment;

        public Student Student { get => student; set => student = value; }
        public Course Course { get => course; set => course = value; }
        public double Assessment { get => assessment; set => assessment = value; }
    }

    public class EvaluationSheet
    {
        DateTime deadline;
        List<CourseAssessment> listOfAssessments;

        public DateTime Deadline { get => deadline; set => deadline = value; }
        public List<CourseAssessment> ListOfAssessments { get => listOfAssessments; set => listOfAssessments = value; }
    }

}