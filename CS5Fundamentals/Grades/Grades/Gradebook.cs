using System;
using System.Collections.Generic;

namespace Grades
{
    class Gradebook
    {
        public Gradebook()
        {
            
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades = new List<float>();
    }
}
