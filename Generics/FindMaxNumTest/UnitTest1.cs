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
        //for Test case 2.3
        //for find maximum float number at 3rd position
        [Test]
        public void GivenMaxThirdNumFloat_WhenAnalysed_ShouldReturnThirdMax()
        {
            float answerFloat = genericbaseFloat.GenMaximum(45.6f, 6.6f, 7.7f);
            Assert.AreEqual(45.6f, answerFloat);
        }
        //for Test case 3.1
        //for find maximum float number at 2nd position
        [Test]
        public void GivenMaxFirstString_WhenAnalysed_ShouldReturnFirstMax()
        {
            string answerString = genericbaseString.GenMaximum("Peach", "Banana", "Apple");
            Assert.AreEqual("Peach", answerString);
        }
        //for Test case 3.2
        //for find maximum string value at 2nd position
        [Test]
        public void GivenMaxSecoundString_WhenAnalysed_ShouldReturnSecoundMax()
        {
            string answerString = genericbaseString.GenMaximum("Banana", "Peach", "Apple");
            Assert.AreEqual("Peach", answerString);
        }
        //for Test case 3.3
        //for find maximum string value at 3rd position
        [Test]
        public void GivenMaxThirdString_WhenAnalysed_ShouldReturnThirdMax()
        {
            string answerString = genericbaseString.GenMaximum("Banana", "Apple", "Peach");
            Assert.AreEqual("Peach", answerString);
        }
    }
}

