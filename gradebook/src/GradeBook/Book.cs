using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        public string Name;
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);   
            }
            else
            {
                // Console.WriteLine($"{grade} is a Invalid value\nWill be erased...");
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
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
                    continue;
                }

                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
                
            }

            result.Average /= grades.Count;

            switch (result.Average)
            {
                case var d when d > 90:
                    result.Letter = 'A';
                    break;
                case var d when d > 80:
                    result.Letter = 'B';
                    break;
                case var d when d > 70:
                    result.Letter = 'C';
                    break;
                case var d when d > 60:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }
    }
}


