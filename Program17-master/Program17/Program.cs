using System;

namespace Program17
{
    public class Person
    {
        public int age;
        public Person()
        {
            SayHi();
        }
        public int SetAge(int n)
        {
            age = n;
            return n;
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is: " + age + " years old");
        }
        public void SayHi()
        {
            Console.WriteLine("Hello everybody!");
        }
    }
    public class Student : Person
    {
        public Student(int i)
        {
            SetAge(i);
            ShowAge();
        }
        
        public void GoToClasses()
        {
            Console.WriteLine("I’m going to class");
        }
    }
    public class Teacher : Person
    {
        private string subject;
        public Teacher(int n)
        {
            SetAge(n);
            ShowAge();
            Explain();
        }
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person Robert = new Person();
            Person Den = new Student(21);
            Person Teacher = new Teacher(30);
        }
    }
}
