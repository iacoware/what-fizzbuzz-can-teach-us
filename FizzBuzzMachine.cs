namespace FizzBuzzKata
{
    public class FizzBuzzMachine
    {
        public string Say(int num)
        {
            var divisorAndWords = new[]
            {
                (Divisor: 3, Word: "Fizz"), 
                (Divisor: 5, Word: "Buzz")
            };
            
            var result = "";
            foreach (var divisorAndWordItem in divisorAndWords)
            {
                if (IsDivisible(num, divisorAndWordItem.Divisor))
                {
                    result += divisorAndWordItem.Word;
                }
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