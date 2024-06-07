
namespace FizzBuzz2
{
    public class FizzBuzzer
    {
        public static string Convert(int input)
        {
            if (input % 3 == 0)
            {
                return "Fizz";
            }

            return "Buzz";

        }
    }
}
