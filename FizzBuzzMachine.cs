namespace FizzBuzzKata
{
    public class FizzBuzzMachine
    {
        public string Say(int num)
        {
            if (num % 3 == 0 && num % 5 == 0) 
                return "Fizz" + "Buzz";
            
            if (num % 3 == 0) 
                return "Fizz";
            
            if (num % 5 == 0) 
                return "Buzz";

            return num.ToString();
        }
    }
}