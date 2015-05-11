using System;
using FizzBuzzLibrary;
using NUnit.Framework;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void Count_Shouldbe1_WhenInput1()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Assert.AreEqual("1", fizzbuzz.Count(1));
        }


        [Test]
        public void Count_Shouldbe2_WhenInput2()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Assert.AreEqual("2", fizzbuzz.Count(2));
        }


        [Test]
        public void Count_ShouldbeFizz_WhenInput3()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Assert.AreEqual("Fizz", fizzbuzz.Count(3));
        }

        [Test]
        public void Count_Shouldbe4_WhenInput4()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Assert.AreEqual("4", fizzbuzz.Count(4));
        }

        [Test]
        public void Count_ShouldbeBuzz_WhenInput5()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Assert.AreEqual("Buzz", fizzbuzz.Count(5));
        }

        [Test]
        public void Count_ShouldbeFizz_WhenInput6()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Assert.AreEqual("Fizz", fizzbuzz.Count(6));
        }

        [Test]
        public void Count_ShouldbeFizz_WhenInput9()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Assert.AreEqual("Fizz", fizzbuzz.Count(9));
        }

        [Test]
        public void Count_ShouldbeBuzz_WhenInput10()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Assert.AreEqual("Buzz", fizzbuzz.Count(10));
        }

        [Test]
        public void Count_ShouldbeFizzBuzz_WhenInput15()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Assert.AreEqual("FizzBuzz", fizzbuzz.Count(15));
        }

    }
}
