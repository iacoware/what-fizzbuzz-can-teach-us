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
                result += EvaluateAndGetWordOrEmpty(num, divisorAndWord);
            }

            if (result != "")
                return result;

            return num.ToString();
        }

        string EvaluateAndGetWordOrEmpty(int num, DivisorAndWord divisorAndWord)
        {
            string word;
            if (DivisorAndWord.IsDivisible(num, divisorAndWord.Divisor))
            {
                word = divisorAndWord.Word;
            }
            else
            {
                word = "";
            }

            return word;
        }
    }
}