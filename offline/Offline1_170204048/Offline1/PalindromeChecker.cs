using System;
using System.Collections.Generic;
using System.Text;

namespace Offline1
{
    class PalindromeChecker
    {
        public void check()
        {
            while (true)
            {
                Console.WriteLine("Enter the string:");
                var s1 = Console.ReadLine();
                var s2 = "";
                int len = s1.Length - 1;

                //In built function
                //var s2 = new string(s1.Reverse().ToArray());

                //Custom made
                while (len >= 0)
                {
                    s2 = s2 + s1[len];
                    len--;
                }

                if (String.Equals(s1, s2))
                {
                    Console.WriteLine("Palindrome!");
                }
                else
                {
                    Console.WriteLine("Not a Palindrome!");
                }
            }

        }
    }
}
