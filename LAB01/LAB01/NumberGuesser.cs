namespace LAB01;

public class NumberGuesser
{
    public NumberGuesser()
    {
        misteryNum = rnd.Next(1, 51);
    }
    private Random rnd = new Random();
    private int misteryNum;

    public void TryToGuess()
    {
        int number = Convert.ToInt32(Console.ReadLine());

        while (number != misteryNum)
        {
            if (number > misteryNum)
                Console.WriteLine("Podana liczba jest za duza\n");
            
            if (number < misteryNum)
                Console.WriteLine("Podana liczba jest za mala\n");

            number = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("Udalo sie!\nOdgadles liczbe\n");
    }
}