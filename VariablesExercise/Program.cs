namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string myName = "Tom";
            int myAge = 54;
            char myGroup = 'B';
            bool isAlive = true;
            double interestRate = 5.6375;
            decimal rentalRate = 47.5m;

            Console.WriteLine($"My name is {myName}, and my age is {myAge} years old.");
            Console.WriteLine($"I am in Group {myGroup}.");
            if ( isAlive ) 
                {
                Console.WriteLine("I am, in fact, alive.");
                }
            else 
                {
                Console.WriteLine("I regret to say that I am no longer alive.");
                }
            Console.WriteLine($"An interest rate might be stored as a Double, such as {interestRate}. Whereas an hourly rental rate could be a Decimal, such as {rentalRate}.");
        }
    }
}
