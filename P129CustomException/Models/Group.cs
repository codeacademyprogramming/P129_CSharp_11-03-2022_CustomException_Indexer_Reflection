using P129CustomException.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace P129CustomException.Models
{
    class Group
    {
        List<Student> Students;

        public Group()
        {
            Students = new List<Student>();
        }

        public Student FindStu(string name)
        {
            Student stu = Students.Find(s => s.Name == name);

            if (stu == null)
            {
                //NullReferenceException nullReferenceException = new NullReferenceException();
                //throw nullReferenceException;

                throw new StudentNotFoundException("Test", new StudentNotFoundException("Inner Exception P129"));
            }

            return stu;
        }
    }
}
