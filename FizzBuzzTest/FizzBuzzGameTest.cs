using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_number_when_give_normal_case()
        {
            // given
            const int input = 1;

            //when
            string output = FizzBuzzGame.CountOff(input);

            //then
            Assert.Equal("1", output);
        }

        [Fact]
        public void Should_return_Fizz_when_give_multipleOf3()
        {
            // given
            FizzBuzzGame game = new FizzBuzzGame();
            const int input = 3;

            //when
            string output = FizzBuzzGame.CountOff(input);

            //then
            Assert.Equal("Fizz", output);
        }

        [Fact]
        public void Should_return_Buzz_when_give_multipleOf5()
        {
            // given
            FizzBuzzGame game = new FizzBuzzGame();
            const int input = 5;

            //when
            string output = FizzBuzzGame.CountOff(input);

            //then
            Assert.Equal("Buzz", output);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_give_multipleOf3And5()
        {
            // given
            FizzBuzzGame game = new FizzBuzzGame();
            const int input = 15;

            //when
            string output = FizzBuzzGame.CountOff(input);

            //then
            Assert.Equal("FizzBuzz", output);
        }
    }
}