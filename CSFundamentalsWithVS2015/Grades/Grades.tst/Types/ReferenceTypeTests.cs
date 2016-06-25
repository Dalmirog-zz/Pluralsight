using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.tst.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void AddDaystoDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "scott";
            name = name.ToUpper();

            Assert.AreEqual("SCOTT", name);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);
            Assert.AreEqual(46, x);
        }
        private void IncrementNumber(int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            Gradebook book1 = new Gradebook();
            Gradebook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A Gradebook", book1.Name);
        }

        private void GiveBookAName(Gradebook book)
        {
            book.Name = "A Gradebook";
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;

            Assert.AreNotEqual(x1, x2);
        }
        [TestMethod]
        public void GradebookVariablesHoldAReference()
        {
            Gradebook g1 = new Gradebook();
            Gradebook g2 = g1;

            g1.Name = "Scott's gradebook";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
