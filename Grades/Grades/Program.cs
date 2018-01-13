using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;


namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
       
            
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Average", (int)stats.AverageGrade);
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            // formatting string
            Console.WriteLine("{0}: {1}, {2}: {3}", "Average", stats.AverageGrade, "Max", stats.HighestGrade);
            // string interpolation
//            Console.WriteLine("Average: {stats.AverageGrade}, Max: {stats.HighestGrade}",stats.AverageGrade,stats.HighestGrade);

          

        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }
        static void WriteResult(string description, double result)
        {
            Console.WriteLine(description + ": " + result);
        }

    }
}
