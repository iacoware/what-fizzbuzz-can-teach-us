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
                result += divisorAndWord.EvaluateAndGetWordOrEmpty(num);
            }

            if (result != "")
                return result;

            return num.ToString();
        }
    }
}