using FizzBuzz2;

namespace FizzBuzzTests
{
    public class Tests
    {
        [Test]
        public void WhenPassedThreeReturnsFizz()
        {
            Assert.That(FizzBuzzer.Convert(3), Is.EqualTo("Fizz"));
        }


        [Test]
        public void WhenPassedFiveReturnsBuzz() 
        {
            Assert.That(FizzBuzzer.Convert(5), Is.EqualTo("Buzz"));
        }

        [Test]
        public void WhenPassedSixReturnsFizz()
        {
            Assert.That(FizzBuzzer.Convert(6), Is.EqualTo("Fizz"));
        }

        [Test]
        public void WhenPassedNinetyNineReturnsFizz()
        {
            Assert.That(FizzBuzzer.Convert(99), Is.EqualTo("Fizz"));
        }

        [Test]
        public void WhenPassedTenReturnsBuzz()
        {
            Assert.That(FizzBuzzer.Convert(10), Is.EqualTo("Buzz"));
        }
    }
}