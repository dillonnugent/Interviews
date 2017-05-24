using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Interviews.Tests
{
    [TestClass()]
    public class StringManipulationTests
    {
        [TestMethod()]
        public void WordCountTest()
        {
            Dictionary<String, int> tests = new Dictionary<String, int>();
            tests.Add("This is a standard sentence, the word count is expected to be thirteen.", 13);
            tests.Add(" This sentence has leading and trailing whitespace. ", 7);
            tests.Add("OneBigWordInThisTest",1);
            tests.Add("!@#$ should puncuation be counted as words !@#$", 8);
            tests.Add("", 0);

            foreach(var test in tests)
            {
                Assert.AreEqual(StringManipulation.WordCount(test.Key), test.Value);
            }
        }
    }
}