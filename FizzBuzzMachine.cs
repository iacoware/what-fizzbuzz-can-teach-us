namespace FizzBuzzKata
{
    public class FizzBuzzMachine
    {
        public string Say(int num)
        {
            var result = "";
            var divisorAndWord = (Divisor: 3, Word: "Fizz");
            var divisorAndWord2 = (Divisor: 5, Word: "Buzz");
            var divisorAndWords = new[] {divisorAndWord, divisorAndWord2};

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