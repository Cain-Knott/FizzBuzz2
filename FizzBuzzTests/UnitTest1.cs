using FizzBuzz2;

namespace FizzBuzzTests
{
    public class Tests
    {
        [TestCase("3")]
        [TestCase("6")]
        [TestCase("999")]
        public void WhenPassedMultipleOThreeReturnsFizz(string number)
        {
            Assert.That(FizzBuzzer.ConvertFizzBuzz(number), Is.EqualTo("Fizz"));
        }


        [TestCase("5")]
        [TestCase("10")]
        [TestCase("1000")]
        public void WhenPassedMultipleOFiveReturnsBuzz(string number) 
        {
            Assert.That(FizzBuzzer.ConvertFizzBuzz(number), Is.EqualTo("Buzz"));
        }

        [TestCase("2")]
        [TestCase("236")]
        [TestCase("1")]
        public void WhenPassedNonMatchingReturnsNonMatching(string number)
        {
            Assert.That(FizzBuzzer.ConvertFizzBuzz(number), Is.EqualTo(number));
        }

        [TestCase("Bad")]
        [TestCase("ReallyBad")]
        [TestCase("ReallyReallyBad")]
        public void WhenPassedBadReturnsNotNumber(string word)
        {
            Assert.That(FizzBuzzer.ConvertFizzBuzz(word), Is.EqualTo("Input should be a number!"));
        }

        [TestCase("15")]
        [TestCase("450")]
        [TestCase("615")]
        public void WhenPassedMultipleOf15ReturnsFizzBuzz(string number)
        {
            Assert.That(FizzBuzzer.ConvertFizzBuzz(number), Is.EqualTo("FizzBuzz"));
        }

        [TestCase("1.0")]
        [TestCase("3.3")]
        [TestCase("13.13")]
        public void WhenPassedDecimalReturnsDecimal(string decimalnumber)
        {
            Assert.That(FizzBuzzer.ConvertFizzBuzz(decimalnumber), Is.EqualTo("Input should be a number!"));
        }

    }
}