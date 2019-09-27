namespace FizzBuzzKata
{
    public class FizzBuzzMachine
    {
        readonly DivisorAndWord[] divisorAndWords;

        public FizzBuzzMachine(DivisorAndWord[] divisorAndWords)
        {
            this.divisorAndWords = divisorAndWords;
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