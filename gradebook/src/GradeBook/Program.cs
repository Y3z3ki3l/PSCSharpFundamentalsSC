using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {               
            var book = new Book("Franz' Grade Book");
            // book.AddGrade(89.1);
            // book.AddGrade(91.0);
            // book.AddGrade(90.0);
            
            // if((pressedKey.Modifiers & ConsoleModifiers.Control) != 0)
            // {
            //     Console.Write("CTL+\n");
            // }

            Console.WriteLine($"Please enter all grades that want be added to your grade book...");

            var grade = 0.0;
            var userInput = "";
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                userInput = Console.ReadLine();
                grade = double.Parse(userInput);
                book.AddGrade(grade);
            }

            var stats = book.GetStatistics();         
            
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The average grade letter is: {stats.Letter}");       
        }        
    }
}
