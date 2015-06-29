using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class ThrowAwayGradebook : Gradebook
    {
        public ThrowAwayGradebook(string name)
            :base(name)
        {
            Console.WriteLine("Throwaway ctor");
        }

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("ThrowAway Comput");
            float lowest = float.MaxValue;
            foreach (float grade in _grades)
            {
                lowest = Math.Min(lowest, grade);
            }
            _grades.Remove(lowest);
            return base.ComputeStatistics();
        }
    }
}
