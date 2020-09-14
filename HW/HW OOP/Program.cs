using System;

namespace HW_OOP
{   
    class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }
    class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {this.age} years old");
        }
    }
    class Teacher : Person
    {
        private String subject = "";
        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }
    }
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person test:");
            Person testPerson = new Person();
            testPerson.Greet();
            Console.WriteLine("\n");

            Console.WriteLine("Student test:");
            Student testStudent = new Student();
            testStudent.SetAge(21);
            testStudent.Greet();
            testStudent.ShowAge();
            Console.WriteLine("\n");

            Console.WriteLine("Teacher test:");
            Teacher testTeacher = new Teacher();
            testTeacher.SetAge(30);
            testTeacher.Greet();
            testTeacher.Explain();
        }
    }
}
