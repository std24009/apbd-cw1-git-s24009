namespace LAB01;

public class NumberGuesser
{
    public NumberGuesser()
    {
        number = rnd.Next(1, 51);
    }
    private Random rnd = new Random();
    private int number;

    void TryToGuess()
    {
        
    }
}