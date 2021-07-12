using System;

/* AKINOLA TITILAYO DEBORAH
EES/18/19/0121
300*/

namespace Layo
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Are you a full-time or part-time student?");
            string student  = Convert.ToString(Console.ReadLine());
            if (student == "full-time")
            {
                System.Console.WriteLine("What is your course of study?");
                string course = Convert.ToString(Console.ReadLine());
                System.Console.WriteLine(course + " is a good course");
            }
            else if  (student == "part-time")
            {
                System.Console.WriteLine("How many credits are you taking?");
                int credit = Convert.ToInt32(Console.ReadLine());

                if (credit > 6)
                {
                    System.Console.WriteLine("Too much units for a student");
                }
                else if (credit <= 6)
                { 
                    System.Console.WriteLine("Proceed to screen");
                }
                
                

            }
        }
    }
}
