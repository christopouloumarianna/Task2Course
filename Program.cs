using System;

namespace task_2_course
{
    class Program
    {
        static void Main(string[] args)
        {
            var math = new Course("M01", "Math 01");
            var physics = new Course("P01", "Physics 01");
            var kostas = new Student();
            kostas.level =(int)levelId.FirstGrade;


            Console.WriteLine("");
        }

    }
    class Course
    {
        private string instructorName;
        private string courseName;
        private string code;

        public string CourseName { get; set; }
        //private readonly string code;
        //private const string code_ = "123";
        public string Code { get; private set; }
        public string InstructorName { get; set; }






        public Course(string name, string code)
        {
            CourseName = name;
            Code = code;

        }
        //public string GetCode()
        //{
        //    return code;
        //}
        public override string ToString()
        {
            return "courseName=" + courseName + "code=" + code + "instructorName=" + instructorName;
        }

    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public levelId Level { get; set; }
        public int level { get; set; }

        private Course enrolledCourse;

        private Course EnrolledCourse { get; set; }
        private string Grade { get; set; }
        private Course course;
        private string studentName;
        private int age;

        public Student()
        {

        }
        public Student(string studentName, int age, int level, Course enrolledCourse)
        {
            this.studentName = studentName;
            this.age = age;
            this.level = level;
            this.enrolledCourse = enrolledCourse;
        }
        public void EnrollToCourse(Course course)
        {
            if (Age >= 18)
            {
                EnrolledCourse = course;
            }
            else
            {
                Console.WriteLine("you cannot enroll to any courses");
            }


        }
        static public string CalculateMark(int mark)
        {
            if (mark > 100 || mark < 0)
            {
                return "wrong mark";
            }
            else if (mark >= 90)
            {
                return "A";
            }
            else if (mark >= 70)
            {
                return "B";
            }
            else if (mark >= 50)
            {
                return "C";
            }
            else
            {
                return "F";
            }


        }
        public void withdrawFromCourse()
        {
            EnrolledCourse = null;
        }

        public override string ToString()
        {
            return "studentName=" + studentName + "age=" + age + "level=" + level + "enrolledCourse=" + enrolledCourse;
        }

    }
}
