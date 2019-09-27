namespace FizzBuzzKata
{
    public class FizzBuzzMachine
    {
        public string Say(int num)
        {
            var divisorAndWords = new[]
            {
                new DivisorAndWord(3, "Fizz"), 
                new DivisorAndWord(5, "Buzz")
            };
            
            var result = "";
            foreach (var divisorAndWord in divisorAndWords)
            {
                if (IsDivisible(num, divisorAndWord.Divisor))
                {
                    result += divisorAndWord.Word;
                }
                else
                {
                    result += "";
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