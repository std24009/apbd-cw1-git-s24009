
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

        void CalculateAverage(int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            
            Console.WriteLine(sum / values.Length);
        }
        
        void CalculateMax(int[] values)
        {
            Console.WriteLine("Najwieksza wartosc: " + values.Max());
        }
    }
}
