namespace FizzBuzzKata
{
    public class FizzBuzzMachine
    {
        readonly DivisorAndWord[] divisorAndWords;

        public FizzBuzzMachine()
        {
            divisorAndWords = new[]
            {
                new DivisorAndWord(3, "Fizz"),
                new DivisorAndWord(5, "Buzz")
            };
        }

        public string Say(int num)
        {
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