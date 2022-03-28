using System;
using System.Collections.Generic;
using System.Text;

namespace Offline1
{
    class List
    {
        public void listFunctions()
        {
            var theoryCourseList = new List<string>();

            theoryCourseList.Add("DCom");
            theoryCourseList.Add("ISD");
            theoryCourseList.Add("MSD");
            theoryCourseList.Add("OS");
            theoryCourseList.Add("HUM");

            Console.WriteLine("After adding theory courses :");
            foreach (var theoryCourse in theoryCourseList)
            {
                Console.WriteLine(theoryCourse);
            }

            theoryCourseList.Remove("HUM");
            Console.WriteLine("After removing non departmental theory courses :");
            foreach (var theoryCourse in theoryCourseList)
            {
                Console.WriteLine(theoryCourse);
            }

            var sessionalCourseList = new List<string>();

            sessionalCourseList.Add("SD");
            sessionalCourseList.Add("ISD");
            sessionalCourseList.Add("MSD");
            sessionalCourseList.Add("OS");

            Console.WriteLine("After making sessional course list :");
            foreach (var sessionalCourse in sessionalCourseList)
            {
                Console.WriteLine(sessionalCourse);
            }

            theoryCourseList.InsertRange(0, sessionalCourseList);

            Console.WriteLine("After putting sessional course list on top of theory course list:");
            foreach (var theoryCourse in theoryCourseList)
            {
                Console.WriteLine(theoryCourse);
            }

        }
    }
}
