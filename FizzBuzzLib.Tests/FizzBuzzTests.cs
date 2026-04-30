namespace FizzBuzzLib.Tests
{
    using FluentAssertions;
    using Xunit;

    public class FizzBuzzTests
    {
        [Fact]
        public void FizzBuzzTest_DivisibleBy3And5_ReturnFizzBuzz()
        {
            // arrange
            var fizzBuzz = new FizzBuzz();

            // act
            var output = fizzBuzz.FizzBuzzifyAnInt(15);

            //assert
            output.Should().Be("FizzBuzz");
        }

        [Fact]
        public void FizzBuzzTest_DivisibleBy3_ReturnFizz()
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.FizzBuzzifyAnInt(3);
            output.Should().Be("Fizz");
        }

        [Fact]
        public void FizzBuzzTest_DivisibleBy5_ReturnBuzz()
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.FizzBuzzifyAnInt(5);
            output.Should().Be("Buzz");
        }

        [Fact]
        public void FizzBuzzTest_NotDivisibleby3Or5_ReturnInput()
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.FizzBuzzifyAnInt(7);
            output.Should().Be("7");
        }

        [Fact]
        public void FizzBuzzRangeTest_ReturnsCorrectValuesForRange()
        {
            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.FizzBuzzValuesForRange(1,15);
            output.Should().Be("1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz");
        }
    }
}
