using System;
namespace Arrays
{

    class ArraysOfString
    {

        // Main Method 
        public static void Main()
        {

            // declares a 1D Array of string. 
            string[] weekDays;

            // allocating memory for days. 
            weekDays = new string[] {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};

            // Displaying Elements of array 
            foreach (string day in weekDays)
                Console.WriteLine(day + " ");
         }
     }
}
