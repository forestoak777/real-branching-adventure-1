static class DeathHandler
{
    private static int deathCount = 0;
    private static readonly (string, string)[] deathMessages =
    {
        ("You died.", "you'll get em next time champ."),
        ("You died again.", "Don't worry buddy, happens to the best of us"),
        ("Wow.", "You might wanna try something else."),
        ("Another death.", "Is there any way i can help?."),
        ("Five deaths.", "You look like you could really use some help."),
        ("Six deaths.", "that one was obvious"),
        ("Seven deaths.", "Are you dying on purpose?"),
        ("Eight deaths.", "You feel a sense of judgement weighing on you."),
        ("Nine deaths.", "Hey, this is taking a while, can you maybe stop dying so much?"),
        ("Ten deaths.", "Double digits already."),
        ("Eleven deaths.", "This is becoming a pattern."),
        ("Twelve deaths.", "I'm starting to wish you didn't play this game"),
        ("Thirteen deaths.", "Unlucky number."),
        ("Fourteen deaths.", "Even the traps are getting bored."),
        ("Fifteen deaths.", "Can you please just exit out next time?"),
        ("Sixteen deaths.", "I can't take much more"),
        ("Seventeen deaths.", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"),
        ("Eighteen deaths.", "I'm ok..."),
        ("Nineteen deaths.", "I just feel sorry for you."),
        ("Twenty deaths.", "You're ******* pathetic.")
    };

    // restartChapter is the function to call if the player chooses to keep playing
    public static void HandleDeath(Action restartChapter)
    {
        deathCount++;

        if (deathCount == 21)
        {
            PityEnding();
            return;
        }

        if (deathCount <= deathMessages.Length)
        {
            var msg = deathMessages[deathCount - 1];
            StringTyper.TypeString(msg.Item1);
            StringTyper.TypeString(msg.Item2);
        }
        else
        {
            StringTyper.TypeString("You died again.");
        }

        PauseForUserInput();

        // ask the player if they want to restart the current chapter or quit
        StringTyper.TypeString("1) Restart this chapter");
        StringTyper.TypeString("2) Quit");
        string? choice = Console.ReadLine();

        if (choice == "2")
        {
            Environment.Exit(0);
        }
        else
        {
            restartChapter();
        }
    }

    private static void PityEnding()
    {
        StringTyper.TypeString("You died.");
        StringTyper.TypeString("Again.");
        StringTyper.TypeString();
        StringTyper.TypeString("The world shifts around you");
        StringTyper.TypeString("\"Alright.\" a voice says.");
        StringTyper.TypeString("\"Clearly you're not winning the normal way.\"");
        StringTyper.TypeString();
        StringTyper.TypeString("You get dropped through a trap door in the ground.");
        StringTyper.TypeString("You find yourself in a white void, devoid of any death.");
        StringTyper.TypeString();
        StringTyper.TypeString("PITY ENDING ACHIEVED.");
        TheEnd();
    }

    private static void PauseForUserInput()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
        Console.WriteLine();
    }

    private static void TheEnd()
    {
        Console.WriteLine("\n=== THE END ===");
        Environment.Exit(0);
    }
}