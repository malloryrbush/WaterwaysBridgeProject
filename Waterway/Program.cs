using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterway
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string userStatusCheck = ("");
            River mississippi = new River("Mississippi", 20, 15);
            Console.WriteLine("Current depth of the " + (mississippi.Name) + " river is: " + (mississippi.Depth));
            Console.WriteLine("Current pollution level of the " + (mississippi.Name) + " river is: " + (mississippi.Pollution));
            Console.WriteLine("Would you like to check the updated status of the river? YES/NO");
            userStatusCheck = Console.ReadLine().ToLower();

    while (userStatusCheck.Equals("yes"))
        {
            if (userStatusCheck == "yes")
            {
                mississippi.GetStatus();

            }
     
            else if (userStatusCheck == "no")
            {
                Console.WriteLine("bye");
            }
                Console.WriteLine("Would you like to check the updated status of the river? YES/NO");
                userStatusCheck = Console.ReadLine().ToLower();

            }
     }
        
       
    }
}
