using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public string CountOff(int input)
        {
            if (input % 3 == 0)
            {
                if (input % 5 == 0)
                {
                    return "FizzBuzz";
                }

                return "Fizz";
            }
            else if (input % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return input.ToString();
            }
        }
    }
}
