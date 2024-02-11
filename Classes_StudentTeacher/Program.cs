using System;

namespace Classes_StudentTeacher
{
    internal class StudentAndTeacherTest
    {
        static void Main()
        {
            Person person = new(); //= new Person();
            Student student = new(21);
            Teacher teacher = new(30, "Math");

            Console.WriteLine("Person says hello:");
            person.Greet();
            Console.WriteLine();
            Console.WriteLine("Student is greeting:");
            student.Greet();
            student.ShowAge();
            Console.WriteLine();
            Console.WriteLine("Teacher says hello:");
            teacher.Greet();
            teacher.Explain();
        }
    }
}
