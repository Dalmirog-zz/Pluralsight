using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CalculateHighestGrade()
        {
            Gradebook book = new Gradebook();

            book.AddGrade(90f);
            book.AddGrade(50f);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(90f, stats.HighestGrade);
        }

        [TestMethod]
        public void PassByValue()
        {
            Gradebook book = new Gradebook();

            book.Name = "Not set";
            SetName(book);

            Assert.AreEqual("Name set", book.Name);
        }

        void SetName(Gradebook book)
        {
            book.Name = "Name set";
        }
    
    }
}
