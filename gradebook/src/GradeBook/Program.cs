using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {               
            var book = new Book("Franz' Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(91.0);
            book.AddGrade(90.0);
            
            // if((pressedKey.Modifiers & ConsoleModifiers.Control) != 0)
            // {
            //     Console.Write("CTL+\n");
            // }

            var grade = 0.0;
            while (pressedKey.Key != ConsoleKey.Escape)
            {
                grade = double.Parse(Console.ReadLine());
            }

            var stats = book.GetStatistics();         
            
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The average grade letter is: {stats.Letter}");       
        }        
    }
}
