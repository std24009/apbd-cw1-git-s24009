
namespace LAB01
{
    class Program
    {
        static void Main(string[] args)
        {
            StatisticsHelper helper = new StatisticsHelper(10);
            
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Username is: " + username);
            
            NumberGuesser numberGuesser = new NumberGuesser();
            numberGuesser.TryToGuess();
        }
    }
}
