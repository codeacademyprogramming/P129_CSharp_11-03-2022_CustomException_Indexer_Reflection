using System;
using System.Collections.Generic;
using System.Text;

namespace P129DemoLibrary
{
    class Student
    {
        private static int count;
        public string Name { get; set; }
        private string SurName;
        protected int Age;

        //public Student(string name)
        //{
        //    Name = name;
        //}

        private void Write(string str)
        {
            Console.WriteLine(str+" Hello P129");
        }
    }
}
