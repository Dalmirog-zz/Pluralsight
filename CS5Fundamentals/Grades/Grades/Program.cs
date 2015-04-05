using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void GiveBookAName(ref Gradebook book)
        {
            book.Name = "The Gradebook";
        }

        static void IncrementNumber(ref int number)
        {
            number += 1;
        }

        static void Main(string[] args)
        {
            Immutable();

            //PassByValueAndRef();

            //Gradebook book = new Gradebook();
            //book.AddGrade(91f);
            //book.AddGrade(89.1f);
            //book.AddGrade(75f);

            //GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.LowestGrade);
            //Console.WriteLine(stats.HighestGrade);
         }

        private static void Immutable()
        {
            string name = " Scott ";
            name = name.Trim();

            DateTime date = new DateTime(2014, 1, 1);
            date = date.AddHours(25);

            Console.WriteLine(date);
            Console.WriteLine(name);
        }

        private static void PassByValueAndRef()
        {
            Gradebook g1 = new Gradebook();
            Gradebook g2 = g1;

            GiveBookAName(ref g2);
            Console.WriteLine(g2.Name);

            int x1 = 10;
            IncrementNumber(ref x1);

            Console.WriteLine(x1);
        }
    }
}
