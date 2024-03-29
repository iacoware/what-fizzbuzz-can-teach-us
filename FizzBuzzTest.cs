using Xunit;

namespace FizzBuzzKata
{
    public class FizzBuzzTest
    {
        readonly DivisorAndWord[] divisorAndWords;

        public FizzBuzzTest()
        {
            divisorAndWords = new[]
            {
                new DivisorAndWord(3, "Fizz"),
                new DivisorAndWord(5, "Buzz")
            };
        }

        [Fact]
        public void NoMatch()
        {
            var fizzBuzz = new FizzBuzzMachine(divisorAndWords);
            Assert.Equal("1", fizzBuzz.Say(1));
            Assert.Equal("2", fizzBuzz.Say(2));
        }

        [Fact]
        public void SingleMatch()
        {
            var fizzBuzz = new FizzBuzzMachine(divisorAndWords);
            Assert.Equal("Fizz", fizzBuzz.Say(3));
            Assert.Equal("Fizz", fizzBuzz.Say(3*2));
        }

        [Fact]
        public void MultipleMatch()
        {
            var fizzBuzz = new FizzBuzzMachine(divisorAndWords);

            Assert.Equal("FizzBuzz", fizzBuzz.Say(3 * 5));
            Assert.Equal("FizzBuzz", fizzBuzz.Say(3 * 5 * 2));
        }
    }
}