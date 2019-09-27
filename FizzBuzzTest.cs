using Xunit;

namespace FizzBuzzKata
{
    public class FizzBuzzTest
    {
        [Fact]
        public void SimpleNumber()
        {
            var fizzBuzz = new FizzBuzzMachine(new[]
            {
                new DivisorAndWord(3, "Fizz"),
                new DivisorAndWord(5, "Buzz")
            });
            Assert.Equal("1", fizzBuzz.Say(1));
            Assert.Equal("2", fizzBuzz.Say(2));
        }

        [Fact]
        public void Fizz()
        {
            var fizzBuzz = new FizzBuzzMachine(new[]
            {
                new DivisorAndWord(3, "Fizz"),
                new DivisorAndWord(5, "Buzz")
            });
            Assert.Equal("Fizz", fizzBuzz.Say(3));
            Assert.Equal("Fizz", fizzBuzz.Say(3*2));
        }

        [Fact]
        public void Buzz()
        {
            var fizzBuzz = new FizzBuzzMachine(new[]
            {
                new DivisorAndWord(3, "Fizz"),
                new DivisorAndWord(5, "Buzz")
            });
            Assert.Equal("Buzz", fizzBuzz.Say(5));
            Assert.Equal("Buzz", fizzBuzz.Say(5*2));
        }

        [Fact]
        public void FizzBuzz()
        {
            var fizzBuzz = new FizzBuzzMachine(new[]
            {
                new DivisorAndWord(3, "Fizz"),
                new DivisorAndWord(5, "Buzz")
            });

            Assert.Equal("FizzBuzz", fizzBuzz.Say(3 * 5));
            Assert.Equal("FizzBuzz", fizzBuzz.Say(3 * 5 * 2));
        }
    }
}