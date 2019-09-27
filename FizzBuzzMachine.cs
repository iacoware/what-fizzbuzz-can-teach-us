namespace FizzBuzzKata
{
    public class FizzBuzzMachine
    {
        public string Say(int num)
        {
            var result = "";
            var divisorAndWord = (Divisor: 3, Word: "Fizz");
            if (IsDivisible(num, divisorAndWord.Divisor))
            {
                result += divisorAndWord.Word;
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