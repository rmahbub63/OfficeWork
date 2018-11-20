using System;

namespace TheGradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(90.5f);
            book.AddGrade(78);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Average Grade = " + stats.AverageGrade);
            Console.WriteLine("Highest Grade = " + stats.HighestGrade);
            Console.WriteLine("Lowest Grade = " + stats.LowestGrade);

        }
    }
}
