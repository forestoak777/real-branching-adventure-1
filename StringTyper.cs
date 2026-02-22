using System.Threading;

public static class StringTyper
{

    //This function types a string progressively.
    //Params
        // str - the string to type
        // milisecondsToSleep - how long to sleep the program after each character is typed
    public static void TypeString(string str = "", int milisecondsToSleep = 10)
    {
        foreach (char c in str)
        {
            Console.Write(c);
            Thread.Sleep(milisecondsToSleep);
        }
        Console.WriteLine();
    }

    //This function "poops" a whole string out at once, after a delay
    //Params
        //str - the string to poop out
        //milisecondsDelay - how long to sleep the program before pooping out a string
    public static void PoopString(string str = "", int milisecondsDelay = 100)
    {

        Thread.Sleep(milisecondsDelay);
        Console.WriteLine(str);
    }

    //This function simply creates a delay.
    //The purpose of this function is to create timing effects between text being typed.
    //Params
        //milisecondsDelay - how long to sleep the program for
    public static void PoopDelay(int milisecondsDelay = 100)
    {
        Thread.Sleep(milisecondsDelay);
    }



}