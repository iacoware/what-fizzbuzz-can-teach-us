namespace FizzBuzzKata
{
    public class FizzBuzzMachine
    {
        public string Say(int num)
        {
            var result = "";
            if (num % 3 == 0)
            {
                result += "Fizz";
            }

            if (num % 5 == 0)
            {
                result += "Buzz";
            }

            if (result != "")
                return result;

            return num.ToString();
        }
    }
}