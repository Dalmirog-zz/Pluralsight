using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void GiveBookAName(Gradebook book)
        {
            book.Name = "The Gradebook";
        }

        static void IncrementNumber(int number)
        {
            number += 1;
        }

        static void Main(string[] args)
        {
            Gradebook g1 = new Gradebook() ;
            Gradebook g2 = g1;

            GiveBookAName(g1);

            Console.WriteLine(g2.Name);

            int x1 = 4;
            IncrementNumber(x1);

            Console.WriteLine(x1);

            //Gradebook book = new Gradebook();
            //book.AddGrade(91f);
            //book.AddGrade(89.1f);
            //book.AddGrade(75f);

            //GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.LowestGrade);
            //Console.WriteLine(stats.HighestGrade);
         }
    }
}
