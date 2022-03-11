using System;
using System.Collections.Generic;
using System.Collections;
using P129Indexer.Lists;

namespace P129Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 5, 7 };

            //int a = arr[0];
            //arr[0] = 15;

            List<string> strList = new List<string>();
            foreach (var item in strList)
            {

            }

            //string b = strList[0];
            //strList[0] = "";

            //Queue q = new Queue();
            //q[0] = "";
            //Console.WriteLine(q[0]);

            MyList<string> myList = new MyList<string>();
            string a = myList[0];
            myList[500] = "Test";
            //myList[1500] = "Test";

            foreach (var item in myList)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                }
            }

            //myList.Add("Test");
            Console.WriteLine(myList[500]);
        }
    }
}
