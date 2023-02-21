using System;
using Generic;

namespace FindMaxNumTest
{
    public class Tests
    {
        GenericBaseMaximum<int> genericbaseInt = new GenericBaseMaximum<int>();
        GenericBaseMaximum<float> genericbaseFloat = new GenericBaseMaximum<float>();
        GenericBaseMaximum<string> genericbaseString = new GenericBaseMaximum<string>();
        [SetUp]
        public void Setup()
        {
        }

        //for Test case 1.1
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int answer = genericbaseInt.GenMaximum(5, 6, 7);
            Assert.AreEqual(7, answer);
        }
    }
}

