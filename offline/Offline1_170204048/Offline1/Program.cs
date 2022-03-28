using System;
using System.Collections.Generic;
using System.Linq;

namespace Offline1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Trace      2.Palindrome       3.List");
            int choice = Convert.ToInt32(Console.ReadLine());
            
                if (choice == 1)
                {
                    var matrix = new MatrixOperations();
                    matrix.trace();
                }
                else if(choice == 2)
                {
                    var palindrome = new PalindromeChecker();
                    palindrome.check();
                }
                else if(choice == 3)
                {
                    var list = new List();
                    list.listFunctions();
                }
                
            
        }
    }
}
