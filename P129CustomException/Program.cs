using P129CustomException.Models;
using System;

namespace P129CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            group.FindStu("Test");

            Console.WriteLine(group.FindStu("Test").Name);
        }
    }
}
