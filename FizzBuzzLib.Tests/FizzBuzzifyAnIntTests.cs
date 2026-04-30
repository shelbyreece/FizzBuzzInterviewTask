namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using Xunit;

    public class FizzBuzzifyAnIntTests
    {
        [Fact]
        public void FizzBuzzifyAnInt_DefaultRange1To10()
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.FizzBuzzValuesForRange(1, 10);
            output.Should().Be(new[] {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"});
        }

        [Fact]
        public void FizzBuzzifyAnInt_2EvenResults()
        {
            var fizzBuzz = new FizzBuzz();
            fizzBuzz.ReplacementPairs.Clear();
            fizzBuzz.ReplacementPairs.Add(2, "Even");
            var output = fizzBuzz.FizzBuzzValuesForRange(1, 10);
            output.Should().Be(new[] {"1", "Even", "3", "Even", "5", "Even", "7", "Even", "9", "Even"});     
        }

        [Fact]
        public void FizzBuzzifyAnInt_2Quack5HonkResults()
        {
            var fizzBuzz = new FizzBuzz();
            fizzBuzz.ReplacementPairs.Clear();
            fizzBuzz.ReplacementPairs.Add(2, "Quack");
            fizzBuzz.ReplacementPairs.Add(5, "Honk");
            var output = fizzBuzz.FizzBuzzValuesForRange(1, 10);
            output.Should().Be(new[] {"1", "Quack", "3", "Quack", "Honk", "Quack", "7", "Quack", "9", "QuackHonk"});
        }
    }
}
