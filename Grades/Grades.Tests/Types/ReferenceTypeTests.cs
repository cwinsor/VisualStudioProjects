using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void T07_UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);
            Assert.AreEqual(89.1f, grades[1], 0.1);
        }

        private void AddGrades(float[] grades)
        {
                   grades[1] = 89.1f;
                        }

        [TestMethod]
        public void T06_MoreString()
        {
            String s1 = "foo";
            DateTime dt = new DateTime(2002, 12, 1);

            ChangeIt(s1,dt);
            Assert.AreEqual(s1, "foo");
            Assert.AreEqual(1, dt.Day);
        }

        public void ChangeIt(String s, DateTime d)
        {
            s = "bar";
          d = new DateTime(2002, 12, 2);
        }

        [TestMethod]
        public void T05_String() 
        {

    // string is reference to a value
            string s11 = "foo";
            string s12 = s11;
            s11 = "bar";
            Assert.AreNotEqual(s11, s12);
            Assert.AreEqual(s11, "bar");
            Assert.AreEqual(s12, "foo");

            // String is a reference to a value
            String s21 = "foo";
            String s22 = s21;
            s21 = "bar";
            Assert.AreNotEqual(s21, s22);
            Assert.AreEqual(s21, "bar");
            Assert.AreEqual(s22, "foo");

            // String methods do not affect the value - they return a new reference
            String s31 = "foo";
            String s32 = s31.ToUpper();
            Assert.AreEqual(s31, "foo");
            Assert.AreEqual(s32, "FOO");

            // int is a struct
            int i11 = 5;
            int i12 = i11;
            i11 = 6;
            Assert.AreNotEqual(i11, i12);
            Assert.AreEqual(i11, 6);
            Assert.AreEqual(i12, 5);

            // Int32 is a struct
            Int32 i21 = 5;
            Int32 i22 = i21;
            i21 = 6;
            Assert.AreNotEqual(i21, i22);
            Assert.AreEqual(i21, 6);
            Assert.AreEqual(i22, 5);

            // DateTime is 
            DateTime dt1 = new DateTime(2002, 12, 1);
            DateTime dt2 = dt1.AddDays(1);
            Assert.AreEqual(1, dt1.Day);
            Assert.AreEqual(2, dt2.Day);




        }
        [TestMethod]
        public void T05_ChangeString()
        {
            String s = "foo";
            ChangeIt(s);
            Assert.AreEqual("foo", s);
        }

        private void ChangeIt(String s)
        {
            s = "bar";
            s.ToUpper();
        }

        [TestMethod]
        public void T05_ChangeInt()
        {
            int i = 5;
            ChangeIt(i);
            Assert.AreEqual(5,i);
        }

private void ChangeIt(int i)
        {
            i = 6;
        }

        [TestMethod]
        public void T05_ChangeINT()
        {
            GradeBook b = new GradeBook();
            b.Name = "foo";
            ChangeIt(b);
            Assert.AreEqual("bar", b.Name);
        }
        private void ChangeIt(GradeBook b)
        {
            b.Name = "bar";
        }

        [TestMethod]
        public void T04_AddDaysToDateTime()
        {
            DateTime dt = new DateTime(2002, 12, 1);
            dt = dt.AddDays(1);
            Assert.AreEqual(2, dt.Day);
        }




        [TestMethod]
        public void T03_UppercaseAString()
        {
            string s = "chris";
            s.ToUpper();
            Assert.AreEqual("chris", s);
        }


        [TestMethod]
        public void T02_MethodParameterIsReferencePassedByValue()
        {

            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book1);
            Assert.AreEqual("A GradeBook", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A GradeBook";
        }


        [TestMethod]
        public void T01_IntVariablesHoldAValue()
        {
            int x1;
            int x2;

            x1 = 4;
            x2 = x1;
            x2 = 5;

            Assert.AreEqual(4, x1);
            Assert.AreEqual(5, x2);
        }

        [TestMethod]
        public void T00_GradebookVariablesHoldAReference()
        {
            GradeBook g1;
            GradeBook g2;

            g1 = new GradeBook();
            g1.Name = "foo";
            g2 = g1;
            g2.Name = "bar";

            Assert.AreEqual("bar", g1.Name); // got changed
            Assert.AreEqual("bar", g2.Name);

        }
    }
}
