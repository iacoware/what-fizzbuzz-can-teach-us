namespace FizzBuzzKata
{
    public class FizzBuzzMachine
    {
        public string Say(int num)
        {
            var result = "";
            var divisorAndWord = (Divisor: 3, Word: "Fizz");
            var divisorAndWord2 = (Divisor: 5, Word: "Buzz");
            
            if (IsDivisible(num, divisorAndWord.Divisor))
            {
                result += divisorAndWord.Word;
            }

            if (IsDivisible(num, divisorAndWord2.Divisor))
            {
                result += divisorAndWord2.Word;
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