using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_StudentTeacher
{
    internal class Person
    {
        int age;

        protected void SetAge(int n)
        {
            age = n;
        }
        protected int GetAge()
        {
            return age;
        }
        public void Greet()
        {
            Console.WriteLine("Hello everyone!");
        }
    }
}
