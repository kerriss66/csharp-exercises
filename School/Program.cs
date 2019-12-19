using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        public class Student
        {
            public const double CREDITS_PER_YEAR = 24.0;
            public string Name { get; set; }
            public int StudentId { get; protected set; }
            public int NumberOfCredits { get; set; }
            public double Gpa { get; set; }

            public Student(string name, int studentId,
                    int numberOfCredits, double gpa)
            {
                this.Name = name;
                this.StudentId = studentId;
                this.NumberOfCredits = numberOfCredits;
                this.Gpa = gpa;
            }

            public Student(string name, int studentId) : this(name, studentId, 0, 0) { }
            
            public void AddGrade(int courseCredits, double grade)
            {
                double newTotalGrade = Gpa * NumberOfCredits + grade * courseCredits;

                NumberOfCredits += courseCredits;
                Gpa = newTotalGrade / NumberOfCredits;
            }
            
            public string GetGradeLevel()
            {
                if (NumberOfCredits > CREDITS_PER_YEAR * 3)
                {
                    return "Senior";
                }
                else if (NumberOfCredits > CREDITS_PER_YEAR * 2)
                {
                    return "Junior";
                }
                else if (NumberOfCredits > CREDITS_PER_YEAR)
                {
                    return "Sophomore";
                }
                else
                {
                    return "Freshman";
                }

        }

            public override string ToString()
            {
                return Name +" (Credits: " + NumberOfCredits + ", GPA: " + Gpa
                    + ")";
            }

            public override bool Equals(object obj) 
            {
                bool compare = false;
                Student studentobj = obj as Student;

                if (this.StudentId == studentobj.StudentId &&
                    this.Name == studentobj.Name)
                {
                    compare = true;
                }
                
                return compare;
            }

            public static double GetCreditsPerYear()
                {
                    return CREDITS_PER_YEAR;
                }

        public class Course
        {
            public int CourseId { get; protected set; }
            public string Name { get; set; }
            public bool RequiresPrereq { get; set; }
            public decimal NumCredits { get; protected set; }
            public string Instructor { get; set; }
            public List<Student> ClassRoster { get; set; }

            public Course(int courseId, string name, bool requiresPrereq,
                decimal numCredits, string instructor)
            {
                this.CourseId = courseId;
                this.Name = name;
                this.RequiresPrereq = requiresPrereq;
                this.NumCredits = numCredits;
                this.Instructor = instructor;
                this.ClassRoster = null;
            }
            public Course(int courseId, string name) : this(courseId, name, false, 0, " ") { }
        }

            class MainClass
            {
                public static void Main(string[] args)
                {
                    Student st = new Student("Ben", 0);
                    Student st2 = new Student("Audrey", 1);
                    Student st3 = new Student("Wade", 3);
                    
                    Student st4 = st;

                    st.Gpa = 2.0;
                    st3.NumberOfCredits = 18;
                    Console.WriteLine(st.Name + " " + st.StudentId);

                    Course c1;
                    Course c2;

                    c1 = new Course(10, "CodeCamp ", false, 14, "Ben");
                    c2 = new Course(101, "LC101");

                    Console.WriteLine("Name: " + c1.Name + "Credits: " + c1.NumCredits);

                    //st.studentId = "55";

                    Console.WriteLine(st.Name + " " + st.StudentId);

                    List<Student> roster = new List<Student>() { st2, st3 };
                    c1.ClassRoster = roster;

                    st.AddGrade(10, 3.0);
                    st.AddGrade(8, 4.0);
                    st.AddGrade(6, 3.0);

                    Console.WriteLine("Student: " + st.Name + " GPA: " + st.Gpa);
                    Console.WriteLine("Student Level: " + st.GetGradeLevel());
                    Console.WriteLine("Student ToString: " + st.ToString());
                    Console.WriteLine("Student ToString: " + st);
                    
                    Console.WriteLine("1 " + st.Equals(st2));
                    Console.WriteLine("2 " + st.Equals(st4));
                    Console.WriteLine("3 " + st.Equals(new Student("Ben", 0)));
                }

            }
        }
    }
}