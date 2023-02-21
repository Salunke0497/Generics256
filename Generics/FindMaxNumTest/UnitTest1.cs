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
        //find maximum number at 1st position
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int answer = genericbaseInt.GenMaximum(5, 6, 7);
            Assert.AreEqual(7, answer);
        }
        
        //for Test case 1.2
        //find maximum number at secound position
        [Test]
        public void GivenMaxSecoundNum_WhenAnalysed_ShouldReturnSecoundMax()
        {
            int answer = genericbaseInt.GenMaximum(5, 9, 7);
            Assert.AreEqual(9, answer);
        }
    }
}

