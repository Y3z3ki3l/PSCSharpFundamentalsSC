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
            
            while (true)
            {
                Console.WriteLine($"Enter a grade or press 'q' to quit");
                var userInput = Console.ReadLine();
                
                if (userInput == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(userInput);
                    book.AddGrade(grade);   
                }
                catch (ArgumentException ex)
                {
                    
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }

            var stats = book.GetStatistics();         
            
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The average grade letter is: {stats.Letter}");       
        }        
    }
}
