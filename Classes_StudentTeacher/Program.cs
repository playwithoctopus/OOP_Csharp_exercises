using System;

namespace Classes_StudentTeacher
{
    internal class StudentAndTeacherTest
    {
        static void Main()
        {
            Person person = new Person();
            Student student = new Student();
            Teacher teacher = new Teacher();

            Console.WriteLine("Person says hello:");
            person.Greet();
            Console.WriteLine();
            Console.WriteLine("Student is greeting:");
            student.SetAge(21);
            student.Greet();
            student.ShowAge();
            Console.WriteLine();
            Console.WriteLine("Teacher says hello:");
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();
        }
    }
}
