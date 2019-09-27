namespace FizzBuzzKata
{
    public class DivisorAndWord
    {
        public int Divisor { get; }
        public string Word { get; }

        public DivisorAndWord(int divisor, string word)
        {
            Divisor = divisor;
            Word = word;
        }

        public string EvaluateAndGetWordOrEmpty(int num)
        {
            if (IsDivisible(num, Divisor))
                return Word;
            else
                return "";
        }

        static bool IsDivisible(int num, int divisor)
        {
            return num % divisor == 0;
        }
    }
}