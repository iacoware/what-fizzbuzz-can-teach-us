namespace FizzBuzzKata
{
    public class FizzBuzzMachine
    {
        public string Say(int num)
        {
            if (num % 3 == 0 && num % 5 == 0) 
                return "Fizz" + "Buzz";

            var result = "";
            if (num % 3 == 0)
            {
                result += "Fizz";
                return "Fizz";
            }

            if (num % 5 == 0)
            {
                result += "Buzz";
                return "Buzz";
            }

            if (result != "")
                return result;

            return num.ToString();
        }
    }
}