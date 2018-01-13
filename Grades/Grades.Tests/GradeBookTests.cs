using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grades.Tests
{

    [TestClass]
    public class GradeBookTests
    {

        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(20);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(20, result.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(20);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }


        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(1);
            book.AddGrade(0);
            book.AddGrade(0);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(0.33, result.AverageGrade, 0.1);
        }



    }
}
