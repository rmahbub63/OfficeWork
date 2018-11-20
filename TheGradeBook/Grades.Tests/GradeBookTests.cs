﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGradeBook;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(29);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(90, result.HighestGrade);
        }
        
    }
}
