namespace LAB01;

public class StatisticsHelper
{
    public StatisticsHelper(int howManyToSay)
    {
        this.howManyToSay = howManyToSay;
        OperatingSystemLesson();
    }
    private int howManyToSay = 0;

    void OperatingSystemLesson()
    {
        for (int i = 0; i < howManyToSay; i++)
        {
            Console.WriteLine("Panie i Panowie");
        }
    }
}