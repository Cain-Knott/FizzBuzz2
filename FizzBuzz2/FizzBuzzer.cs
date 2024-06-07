namespace FizzBuzz2
{
    public class FizzBuzzer
    {
        public static string ConvertFizzBuzz(string input)
        {
            if (!int.TryParse(input, out int number))
            {
                return "Input should be a number!";
            }

            if (number < 1 || number > 1000)
            {
                return "Invalid number: Should be 1-1000.";
            }

            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }

            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}
