namespace FizzBuzzKata
{
    public class FizzBuzzMachine
    {
        public string Say(int num)
        {
            var result = "";
            if (IsDivisible(num, 3))
            {
                result += "Fizz";
            }

            if (IsDivisible(num, 5))
            {
                result += "Buzz";
            }

            if (result != "")
                return result;

            return num.ToString();
        }

        static bool IsDivisible(int num, int divisor)
        {
            return num % divisor == 0;
        }
    }
}