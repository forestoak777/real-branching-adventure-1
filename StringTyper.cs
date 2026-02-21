
using System.Threading;

public static class StringTyper
{

    public static void TypeString(string str = "", int milisecondsToSleep = 10)
    {
        foreach (char c in str)
        {
            Console.Write(c);
            Thread.Sleep(milisecondsToSleep);
        }
        Console.WriteLine();
    }

    public static void PoopString(string str = "", int milisecondsDelay = 100)
    {
        
        Thread.Sleep(milisecondsDelay);
        Console.WriteLine(str);
    }

    public static void PoopDelay(int milisecondsDelay = 100)
    {
        Thread.Sleep(milisecondsDelay);
    }
    
    

}