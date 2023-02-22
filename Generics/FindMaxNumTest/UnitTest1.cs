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

        //for Test case 1.3
        //for find maximum number at 3rd position
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int answer = genericbaseInt.GenMaximum(5, 9, 17);
            Assert.AreEqual(17, answer);
        }
        //for Test case 2.1
        //for find maximum float number at 1st position
        [Test]
        public void GivenMaxFloatNum_WhenAnalysed_ShouldReturnFloatMax()
        {
            float answer = genericbaseFloat.GenMaximum(55f, 9f, 17f);
            Assert.AreEqual(55f, answer);
        }
        //for Test case 2.2
        //for find maximum float number at 2nd position
        [Test]
        public void GivenMaxSecoundNumFloat_WhenAnalysed_ShouldReturnSecoundMax()
        {
            float answerFloat = genericbaseFloat.GenMaximum(5.5f, 88.8f, 7.7f);
            Assert.AreEqual(88.8f, answerFloat);
        }
    }
}

