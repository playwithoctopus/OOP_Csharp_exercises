﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_StudentTeacher
{
    internal class Teacher : Person
    {
        string subject;

        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
}