using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            /* if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);   
            }
            else
            {
                Console.WriteLine($"{grade} is a Invalid value\nWill be erased...");
            } */
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;            
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            // foreach(var grade in grades)
            // {
            //     result.Low = Math.Min(grade, result.Low);
            //     result.High = Math.Max(grade, result.High);
            //     result.Average += grade;
            // }

            // var index = 0;
            // do
            // {

            //     result.Low = Math.Min(grades[index], result.Low);
            //     result.High = Math.Max(grades[index], result.High);
            //     result.Average += grades[index];

            //     index++;

            // } while (index < grades.Count);

            // var index = 0;
            // while (index < grades.Count)
            // {

            //     result.Low = Math.Min(grades[index], result.Low);
            //     result.High = Math.Max(grades[index], result.High);
            //     result.Average += grades[index];

            //     index++;
            // }

            for (int index = 0; index < grades.Count; index++)
            {
                if (grades[index] <= 0)
                {
                    break;
                }

                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
                
            }

            result.Average /= grades.Count;

            return result;
        }

        private List<double> grades;
        public string Name;
    }
}


