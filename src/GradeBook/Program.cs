using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Adarsh's GradeBook");
            book.AddGrade(33.1);
            book.AddGrade(90.2);
            book.AddGrade(77.5);
            var stats = book.GetStatistics(); 

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The higest grade is {stats.High}");
            Console.WriteLine($"The Average grade is {stats.Average:N1}");
        }
    }
}
