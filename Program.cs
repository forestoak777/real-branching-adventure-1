

using System;
using Microsoft.VisualBasic;

partial class Program
{
    static void Main()
    {
        // load the bad words before anything else, just in case
        ProfanityFilter.LoadProfanityList();
        Part1();
    }

    public static void Part1()
    {
        // this is the intro - sets the scene and asks for the player's name
        StringTyper.TypeString("Welcome to the eggscape room!");
        StringTyper.TypeString("You awaken in a padded white room.");
        StringTyper.TypeString("The only decoration in the room is a poster of an egg.");
        StringTyper.TypeString();
        StringTyper.TypeString("You try to remember your name...");

        string? fakeName = Console.ReadLine();

        // check if they typed one of the secret names - if so, skip the normal story entirely
        if (fakeName != null)
        {
            string nameCheck = fakeName.ToLower();

            if (nameCheck == "mike mike")
            {
                MikeMikeRoute();
                return;
            }
            else if (nameCheck == "mike f**k")
            {
                MikeFkRoute();
                return;
            }
            else if (nameCheck == "frisk")
            {
                FriskRoute();
                return;
            }
        }
        string playerName = "Diedre Mengedoht";

        StringTyper.TypeString("That's right! Your name is " + playerName + "!");
        StringTyper.TypeString();
        StringTyper.TypeString("Ow, my head. What is this place?");

        string choice1 = "";

        do
        {
            StringTyper.TypeString("What do you do?");
            StringTyper.TypeString("1 -> sit there and think");
            StringTyper.TypeString("2 -> knock on the locked metal door");
            StringTyper.TypeString("3 -> wake up");
            StringTyper.TypeString("Type 1, 2, or 3 below and then press enter:");

            choice1 = Console.ReadLine();
            StringTyper.TypeString();

            if (choice1 == "1")
            {
                StringTyper.TypeString("You sit there, thinking and nothing happens.");
                StringTyper.TypeString("You die of boredom. (Go back in time as punishment)");
                DeathHandler.HandleDeath(() => Part1());
                return;
            }

            if (choice1 == "2")
            {
                StringTyper.TypeString("You knock on the door ahead of you.");
                StringTyper.TypeString("The door flies open. It is thrust open so quickly that it swings in your face.");

                Random rnd = new Random();
                bool survive = rnd.Next(2) == 0; // 50/50 chance the door smacks you in the face

                if (!survive)
                {
                    StringTyper.TypeString("The door hits you square in the face. You die instantly. (Go back in time as punishment)");
                    DeathHandler.HandleDeath(() => Part1());
                    return;
                }
                else
                {
                    StringTyper.TypeString("You dodge the door and rush through into the corridor ahead");
                    StringTyper.TypeString("The corridor stretches ahead, and you can see multiple paths leading deeper into the facility.");
                    FacilityBranch();
                }
            }

        } while (choice1 != "1" && choice1 != "2" && choice1 != "3");

        StringTyper.TypeString();

        string choice2 = "";

        if (choice1 == "3")
        {
            do
            {
                StringTyper.TypeString("You wake up. You're in your cozy bed. You are 15 years old.");
                StringTyper.TypeString("What do you do?");
                StringTyper.TypeString("1 -> use the toilet / loo / pooper");
                StringTyper.TypeString("2 -> wake up mommy and daddy and start crying like a baby because you had a bad dream.");
                StringTyper.TypeString("3 -> wake up");
                StringTyper.TypeString("Type 1, 2, or 3 below and then press enter:");

                choice2 = Console.ReadLine();
                StringTyper.TypeString();

                if (choice2 == "1")
                {
                    StringTyper.TypeString("You thrust yourself out of bed and rush to the toilet to release your intestinal load.");
                    StringTyper.TypeString("You did it! +25xp");
                    StringTyper.TypeString();
                    StringTyper.TypeString("Unfortunately. When you finish using the toilet,");
                    StringTyper.TypeString("you accidentally close the lid on your private parts.");
                    StringTyper.TypeString("This instantly crushes them. You die. (Go back in time as punishment)");
                    DeathHandler.HandleDeath(() => Part1());
                    return;
                }

                if (choice2 == "3")
                {
                    StringTyper.TypeString("You can't wake up if you're already awake! stupid! You die. (Go back in time as punishment)");
                    DeathHandler.HandleDeath(() => Part1());
                    return;
                }

            } while (choice2 != "1" && choice2 != "2" && choice2 != "3");
        }

        if (choice2 == "2")
        {
            StringTyper.TypeString("MOMMY!! DADDY!! You scream, running from your room with snot coming out of your mouth.");
            StringTyper.TypeString("MUH MUH MIH MUH MOMMY I HAD A BAD DREAM.");
            StringTyper.TypeString("\"I wish I never had a son\" says your Dad.");
            StringTyper.TypeString("\"My poor babyy1!\" says your Mom.");
            StringTyper.TypeString("She gives you a kiss on the cheek and a lollipop.");
            StringTyper.TypeString("YUMMY! +25 xp");

            PauseForUserInput();
            Part2Handler.Part2();
        }
    }

    static void PauseForUserInput()
    {
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static void TheEnd()
    {
        StringTyper.TypeString();
        StringTyper.TypeString("***************");
        StringTyper.TypeString("   THE END   ");
        StringTyper.TypeString("***************");
        StringTyper.TypeString("Thanks for playing!");
        StringTyper.TypeString("Press Enter to play again...");
        Console.ReadLine();
        Part1(); // restart from the beginning instead of closing
    }

    // the facility is a series of branching rooms, each one leading to the next
    // only one correct path through each room, everything else kills you
    static void FacilityBranch()
    {
        StringTyper.TypeString("You see three doors ahead: One door has a skull and crossbones, one door has letters on it saying 'DEATH INSIDE' and the third door has no markings on it");
        StringTyper.TypeString("Which door do you choose?");
        StringTyper.TypeString("1) Skull");
        StringTyper.TypeString("2) DEATH INSIDE");
        StringTyper.TypeString("3) No markings");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                StringTyper.TypeString("Door one opens to a trap room. Spikes shoot out from the walls. You die instantly except for the 10 minutes you spent in excrutiating pain.");
                DeathHandler.HandleDeath(() => FacilityBranch());
                return;
                break;

            case "2":
                StringTyper.TypeString("Door two leads to a security room, Classic misdirection. You advance deeper into the facility!");
                FacilityBranch2();
                break;

            case "3":
                StringTyper.TypeString("Door three triggers a laser trap. You are cut to pieces to be packaged in lunchables. You die!");
                DeathHandler.HandleDeath(() => FacilityBranch());
                return;
                break;
        }
    }

    static void FacilityBranch2()
    {
        StringTyper.TypeString("You enter a dim corridor and find a fork in the path: left, straight, or right.");
        StringTyper.TypeString("Which way do you go?");
        StringTyper.TypeString("1) Left");
        StringTyper.TypeString("2) Straight");
        StringTyper.TypeString("3) Right");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                StringTyper.TypeString("The left path collapses under your weight. You fall into a pit of spikes. You die!");
                DeathHandler.HandleDeath(() => FacilityBranch());
                return;

            case "2":
                StringTyper.TypeString("The straight path is clear. You walk safely deeper into the facility.");
                FacilityBranch3();
                break;

            case "3":
                StringTyper.TypeString("Right path triggers an electric trap. You are electrocuted. You die!");
                DeathHandler.HandleDeath(() => FacilityBranch());
                return;

            default:
                StringTyper.TypeString("You stand still too long. Security drones find you and eliminate you. You die!");
                DeathHandler.HandleDeath(() => FacilityBranch());
                return;
        }
    }

    static void FacilityBranch3()
    {
        StringTyper.TypeString("You reach a room filled with barrels. One barrel is leaking a green liquid.");
        StringTyper.TypeString("What do you do?");
        StringTyper.TypeString("1) Inspect the green barrel");
        StringTyper.TypeString("2) Jump over the barrels to the other side");
        StringTyper.TypeString("3) Go back the way you came");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                StringTyper.TypeString("The barrel explodes in your face. You die!");
                DeathHandler.HandleDeath(() => FacilityBranch());
                return;

            case "2":
                StringTyper.TypeString("You successfully jump over the barrels and reach a ladder leading up.");
                FacilityBranch4();
                break;

            case "3":
                StringTyper.TypeString("Going back triggers a trap in the corridor. You are crushed. You die!");
                DeathHandler.HandleDeath(() => FacilityBranch());
                return;
        }
    }

    static void FacilityBranch4()
    {
        StringTyper.TypeString("You climb the ladder and enter a room with two doors: one marked with a skull, one plain metal.");
        StringTyper.TypeString("Which door do you choose?");
        StringTyper.TypeString("1) Skull door");
        StringTyper.TypeString("2) Plain metal door");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                StringTyper.TypeString("You have been misdirected by midirection, the room explodes. You die.");
                DeathHandler.HandleDeath(() => FacilityBranch());
                return;

            case "2":
                StringTyper.TypeString("You enter safely. You have reached the outside world.");
                StringTyper.TypeString("Congratulations! You did it... good job... go home.");
                TheEnd();
                break;
        }
    }

    // secret ending if you typed "mike mike" as your name at the start
    static void MikeMikeRoute()
    {
        StringTyper.TypeString("You remember your name...");
        StringTyper.TypeString("MIKE MIKE.");
        StringTyper.TypeString("Your memories suddenly return.");
        StringTyper.TypeString("You are actually a secret agent.");
        StringTyper.TypeString("Your mission was to hunt down Mr. Sheit.");
        StringTyper.TypeString("You check the files.");
        StringTyper.TypeString("Mr. Sheit died forty years ago.");
        StringTyper.TypeString("MISSION COMPLETE.");
        StringTyper.TypeString("SECRET AGENT ENDING!");
        TheEnd();
    }

    // secret ending if you typed "mike f**k" as your name
    static void MikeFkRoute()
    {
        StringTyper.TypeString("You remember your name...");
        StringTyper.TypeString("MIKE F**K.");
        StringTyper.TypeString("Suddenly, a gang of gooners appears behind you.");
        StringTyper.TypeString("\"Hey Mike F**k!\" they shout.");
        StringTyper.TypeString("\"Who are we giving wedgies to today?\"");
        StringTyper.TypeString("You look down at your hands.");
        StringTyper.TypeString("You am become bully, destroyer of nerds.");
        StringTyper.TypeString("BULLY ENDING!");
        TheEnd();
    }

    // frisk always dies no matter what, and loops forever until they give up or restart
    static void FriskRoute()
    {
        Random rnd = new Random();
        int outcome = rnd.Next(2);

        if (outcome == 0)
        {
            StringTyper.TypeString("You remember your name...");
            StringTyper.TypeString("Frisk.");
            StringTyper.TypeString("Your life will be a living hell.");
            StringTyper.TypeString("You wake up in the eggscape room.");
            StringTyper.TypeString("The air is too thick and you suffocate.");
        }
        else
        {
            StringTyper.TypeString("You remember your name...");
            StringTyper.TypeString("Frisk.");
            StringTyper.TypeString("Your life will be a living hell.");
            StringTyper.TypeString("You wake up in the eggscape room.");
            StringTyper.TypeString("A monster attacks!");
            StringTyper.TypeString("You instantly die.");
        }

        StringTyper.TypeString();
        StringTyper.TypeString("Do you want to restart or exit the game?");
        StringTyper.TypeString("1) Restart");
        StringTyper.TypeString("2) Exit");

        string? choice = Console.ReadLine();

        if (choice == "1")
        {
            FriskRoute();
        }
        else
        {
            StringTyper.TypeString("Ok. Restarting the game. Thanks for playing!");
            Part1(); // restart instead of closing
        }
    }

    static class Part2Handler
    {
        public static void Part2()
        {
            // the school hallway scene - mike gives you a wedgie
            StringTyper.TypeString();
            StringTyper.TypeString("5 years later. You are now in high school (you were held back a lot)");
            StringTyper.TypeString("Mike F**k walks over to you.");
            StringTyper.TypeString("\"M-m-m-m-m-m-m-m-m-m-m-Mike!\" you stammer.");
            StringTyper.TypeString("Do you w-w-w-w-w-w-w-w-w-w-want my l-l-l-l-l-l-lunch money?");
            StringTyper.TypeString("\"SHUT UP!\" says Mike, who grabs the back of your underpants and pulls them so high that it reaches over your head.");
            StringTyper.TypeString("(-5 xp)");
            StringTyper.TypeString();

            StringTyper.TypeString("What do you scream in your agony?:");
            string yell = Console.ReadLine();
            StringTyper.TypeString();

            // if they swore while screaming the principal drills them. seems fair
            if (ProfanityFilter.ContainsProfanity(yell))
            {
                StringTyper.TypeString("The principal, who so happened to be fixing a locker in that hallway with a handheld drill,");
                StringTyper.TypeString("runs over to you and drills a hole through your skull in his fury. You die.");
                DeathHandler.HandleDeath(() => Part2Handler.Part2());
                return;
            }

            // 50/50 chance to be sucked into Underpants Dimension
            // this is a whole sub-story, so it restarts Part2 when it's done
            Random rnd = new Random();
            bool suckedIntoUnderpants = rnd.Next(100) < 35; // 35% chance

            if (suckedIntoUnderpants)
            {
                // Underpants Dimension path
                StringTyper.TypeString("As Mike f**k pulls your underpants over your head");
                StringTyper.TypeString("You are sucked into the Underpants Dimension!");
                StringTyper.TypeString("You find yourself in a strange land made entirely of underpants. The sky is socks, the trees are boxers, and the rivers are elastic waistbands.");
                StringTyper.TypeString("What do you do?:");
                StringTyper.TypeString("1) Explore the underpants forest");
                StringTyper.TypeString("2) Sit down and cry because you're a scared little baby");

                string choice1 = Console.ReadLine();
                if (choice1 == "1")
                {
                    StringTyper.TypeString("You wander through the forest and a giant sentient thong appears!");
                    StringTyper.TypeString("It asks, '*#$^*@#$*(^&%^@#%^&*$^%@&^?' You do not understand Underpantsian");
                    StringTyper.TypeString("1) Scream and punch it");
                    StringTyper.TypeString("2) Scream and run");

                    string choice2 = Console.ReadLine();
                    if (choice2 == "1")
                    {
                        StringTyper.TypeString("The thong immediately crumples, turning into a pile of immobile fabric.");
                        StringTyper.TypeString("You venture deeper into the underpants realm not knowing what may await you.");
                        StringTyper.TypeString("TO BE CONTINUED");
                    }
                    else if (choice2 == "2")
                    {
                        StringTyper.TypeString("You attempt to run, but the thong pulls the fabric under your feet, sliding you closer to it.");
                        StringTyper.TypeString("The Thong wraps itself completely around you before devouring you alive.");
                        DeathHandler.HandleDeath(() => Part2Handler.Part2());
                        return;
                    }
                }
                else if (choice1 == "2")
                {
                    StringTyper.TypeString("You cry like a wee little baby, bawling your eyes out.");
                    StringTyper.TypeString("Do you:");
                    StringTyper.TypeString("1) Run around with tears in your eyes");
                    StringTyper.TypeString("2) Sit and keep crying");

                    string choice3 = Console.ReadLine();
                    if (choice3 == "1")
                    {
                        StringTyper.TypeString("You run around until you fall into the waistband river.");
                        StringTyper.TypeString("You think you've drowned when you realize that you're safe back home.");
                        StringTyper.TypeString("Boring ending");
                    }
                    else if (choice3 == "2")
                    {
                        StringTyper.TypeString("You cry and cry and cry until you die of crying.");
                        StringTyper.TypeString("Cry ending");
                        DeathHandler.HandleDeath(() => Part2Handler.Part2());
                        return;
                    }
                }

                StringTyper.TypeString("Press Enter to continue...");
                Console.ReadLine();
                Part2Handler.Part2(); // restart Part2
                return;
            }
            else
            {
                // Normal story path
                StringTyper.TypeString("Mike drops you to the ground and kicks you in the stomach.");
                StringTyper.TypeString("Then he and his gooners walk away.");
                StringTyper.PoopDelay();
                StringTyper.TypeString("The principal closes the shutters from behind the window he was watching from.");
                StringTyper.TypeString();
                StringTyper.TypeString("You go about your day in embarrassment. Your underpants have been stretched so much by the wedgie,");
                StringTyper.TypeString("That they hang out of the back of your pants for the rest of the day.");
                StringTyper.TypeString("Kids left and right make fun of both your over-stretched tightie-whities, and the brown stains all over them.");
                StringTyper.TypeString("Please press enter to continue.");
                Console.ReadLine();
                Console.ReadLine();
                StringTyper.TypeString("...", 100);
                // your house is on fire and a firetruck is about to hit you - pick your dodge
                StringTyper.TypeString("You go home. You find that it is ablaze.");
                StringTyper.TypeString("A firetruck swerves around the corner. It is driving at 60mph towards you!");
                StringTyper.TypeString("Choose a self-defense option to avoid dying:");
                StringTyper.PoopString("1 - jump out of the way", 50);
                StringTyper.PoopString("2 - stop the firetruck with your bare hands", 50);
                StringTyper.PoopString("3 - stop, drop, and roll under the firetruck", 50);
                Console.WriteLine();
                StringTyper.PoopString("Put your response here: ");
                string dodge_choice = Console.ReadLine();

                bool issekaied = rnd.Next(100) < 35; // 35% chance of getting truck-kun'd into another world

                if (dodge_choice == "1")
                {
                    if (issekaied)
                    {
                        StringTyper.TypeString("As you jump, the firetruck hits you... and instead of dying, you feel yourself being pulled through a glowing portal!");
                        StringTyper.TypeString("You are transported to another dimension!");
                        StringTyper.TypeString("What will you do?");
                        StringTyper.TypeString("1) Look around the strange land");
                        StringTyper.TypeString("2) Try to run from the portal");

                        string issekai_choice1 = Console.ReadLine();
                        StringTyper.TypeString("You wake up and see yourself surrounded by a harem of big chested anime girls");
                        StringTyper.TypeString("You die");
                        DeathHandler.HandleDeath(() => Part2Handler.Part2());
                        return;
                    }
                    else
                    {
                        DeathHandler.HandleDeath(() => Part2Handler.Part2());
                        return;
                    }
                }
                else if (dodge_choice == "2")
                {
                    StringTyper.TypeString("Okie doke. You put your hands forward and plant your heel firmly behind you. You've conjured up the most stable stance that you ever have, or ever will stand in. The truck runs you over and you die.");
                    StringTyper.PoopDelay();
                    StringTyper.TypeString("Going back in time...");
                    StringTyper.PoopDelay();
                    DeathHandler.HandleDeath(() => Part2Handler.Part2());
                    return;
                }
                else if (dodge_choice == "3")
                {
                    StringTyper.TypeString("All rye ...");
                    StringTyper.PoopDelay(300);
                    StringTyper.TypeString("All rye keep your pants on...");
                    StringTyper.PoopDelay(300);
                    StringTyper.TypeString("All rye keep your pants on...");
                    StringTyper.PoopDelay(300);
                    StringTyper.TypeString("All rye keep your pants on...");
                    StringTyper.PoopDelay(300);
                    StringTyper.TypeString("All rye keep your pants on...");
                    StringTyper.PoopDelay(300);
                    StringTyper.TypeString("You roll under the firetruck in between its tires. It drives over you and crashes into your house. You survived!");
                    Part3();
                }
                else
                {
                    StringTyper.TypeString("Oh my gooooood dude what the fuck is wrong with you? You can only choose options 1, 2, or 3. Ok? Now go back in time as a penalty.");
                    DeathHandler.HandleDeath(() => Part2Handler.Part2());
                    return;
                }

                return;
            }
        }

        static string weapon_choice = "";

        // dream sequence where you pick a weapon - the choice carries into Part5 with the bear
        static void Part3()
        {
            Program.PauseForUserInput();

            StringTyper.PoopDelay(500);
            StringTyper.TypeString("You are dreaming once again. In your dream, you get to choose a weapon.");
            StringTyper.TypeString("This weapon is like super important for the future");
            StringTyper.TypeString("It will incrase your attank powder. So chose wiesely.");

            StringTyper.TypeString("\nGuh okie. dokie. So your options are: ");
            StringTyper.TypeString("1) Hammer ");
            StringTyper.TypeString("2) Slammer");
            StringTyper.TypeString("3) Blammer");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                StringTyper.TypeString("Yeah I guess that's a reasonable choice.");
            }
            else if (choice == "2")
            {
                StringTyper.TypeString("wtf is a slammer?");
            }
            else if (choice == "3")
            {
                StringTyper.TypeString("wtf is a blammer?");
            }
            else
            {
                StringTyper.TypeString("what that means?");
            }

            weapon_choice = choice;

            StringTyper.TypeString("Alright that choice was super duper very very importante. Comprende?");
            StringTyper.TypeString("All rye.");

            Part4();
        }
        // waking up outside after the house fire - your parents are mad and you have to apologize
        static void Part4()
        {
            Program.PauseForUserInput();

            StringTyper.TypeString("You wake up on damp grass. You are freezing cold, and it's still dark out. Your family has had to sleep in the woods because your house burned down and was crashed into by a firetruck.");
            StringTyper.PoopDelay();
            StringTyper.TypeString("It turns out that the fire was all your fault. You left your fifteen lit candles on your bed.");
            StringTyper.TypeString("The cat jumped on the bed and caught fire because of the candles.");
            StringTyper.TypeString("After running around the house in panic, the cat ended up setting every piece of furniture on fire.");
            StringTyper.TypeString("Amazingly, the cat survived, but your dog died.");

            Program.PauseForUserInput();

            StringTyper.TypeString("Your Dad hates you because all of his silver and gold were destroyed in the fire.");
            StringTyper.TypeString("Your Mom hates you because all of her silver and gold were destroyed in the fire.");
            StringTyper.TypeString("As for your punishment, you are forced to sleep outside of the tent on the cold ground instead of in the warm, heated tent");

            StringTyper.PoopDelay(1000);
            StringTyper.TypeString("What do you say to try in an attempt to repair your relationship?");

            StringTyper.PoopString("1) Sorry", 100);
            StringTyper.PoopString("2) Sowee", 100);
            StringTyper.PoopString("3) Dada I sowee. O_0. Pwease dont make me sweep outswide the twent.", 100);

            StringTyper.PoopDelay(1000);

            var relationship_repair_choice = Console.ReadLine();

            if (relationship_repair_choice == "1")
            {
                StringTyper.TypeString("You enter their tent in an attempt to apologize to your parents. Unfortunately, they are in the midst of making love.");
                StringTyper.TypeString("Immediately, your Dad pulls a pistol out from under their bedsheets and shoots you square in the forehead.");
                StringTyper.TypeString("You Died! Go back in time as punishment...");
                DeathHandler.HandleDeath(() => Part4());
                return;
            }
            else if (relationship_repair_choice == "2")
            {
                StringTyper.TypeString("You enter their tent in an attempt to apologize to your parents. You say \"Sowee\" to your Dad, who has woken up and is staring at you as if you were one of his sleep paralysis demons.");
                StringTyper.TypeString("\"What the hell even is that?\" he says, looking at you.");
                StringTyper.TypeString("You consider this apology a success.");
                Part5();
            }
            else if (relationship_repair_choice == "3")
            {
                StringTyper.TypeString("You enter their tent in an attempt to apologize to your parents.");
                StringTyper.TypeString("As you perform shy finger twiddling, you say to your Dad, \"Dada I sowee. O_0. Pwease dont make me sweep outswide the twent.\"");
                StringTyper.TypeString("He looks angry and disappointed at you. But then, he breaks down into tears.");
                StringTyper.TypeString("He says, \"Son, I'm so sorry for being so cruel to you. I promise that things will be different from now on.\"");
                StringTyper.TypeString("You hear a strange rumbling noise.");
                StringTyper.TypeString("You and your parents leave the tent, and see that your house has been completely rebuilt!");
                StringTyper.TypeString("Howdy, neighbor! Says all of your neighbors in unison.");
                StringTyper.TypeString("We decided to rebuild your house for you! They say.");
                StringTyper.TypeString("Then they like fade into dust like in Avengers Infinity War");
                StringTyper.TypeString("Well, says your Dad, looks like it's a happily ever after!");

                Program.TheEnd();
            }
            else
            {
                StringTyper.TypeString("You enter their tent in an attempt to apologize to your parents. They are in the midst of making love.");
                StringTyper.TypeString("As soon as he sees you, your Dad pulls a pistol out from under their bedsheets and shoots you square in the forehead.");
                StringTyper.TypeString("You Died! Go back in time as punishment...");
                DeathHandler.HandleDeath(() => Part4());
                return;
            }
        }

        // a bear shows up. your weapon choice from the dream finally matters here
        static void Part5()
        {
            Program.PauseForUserInput();
            StringTyper.PoopDelay(1000);
            StringTyper.PoopString("Alls of the sudden...");
            StringTyper.PoopDelay(1000);
            StringTyper.PoopString("A bear comes out of the woods and is about to maul your family!");
            Console.WriteLine();

            StringTyper.PoopDelay(500);
            StringTyper.PoopString("What do you do?");
            StringTyper.PoopString("1) Just sit there and watch the bear kill your parents", 100);
            StringTyper.PoopString("2) Fight the bear with the weapon from your dream", 1000);
            StringTyper.TypeString("All rye, choose now: ");

            var bear_choice = Console.ReadLine();

            if (bear_choice == "1")
            {
                Random rnd = new Random();
                bool raisedByBear = rnd.Next(100) < 25; // 25% chance the bear adopts you instead of eating you

                if (raisedByBear)
                {
                    StringTyper.PoopDelay(500);
                    StringTyper.TypeString("You watch as the bear mauls your parents...");
                    StringTyper.TypeString("Suddenly, it notices you sitting there.");
                    StringTyper.TypeString("Instead of eating you face, the bear scoops you up in its furry bear arms.");
                    StringTyper.TypeString("You feel more love in 10 seconds from this bear than your parents have ever shown you");
                    StringTyper.TypeString("The bear teaches you to fish, climb tree, hibernate, Maul hikers.");
                    StringTyper.TypeString("You and the bear live hapipy ever after");
                    Program.TheEnd();
                }
                else
                {
                    StringTyper.PoopDelay(500);
                    StringTyper.TypeString("You watch as the bear eats your parents.");
                    StringTyper.TypeString("Then the bear turns and eats you.");
                    StringTyper.TypeString("I guess your actions have consequences, hrmmmm?");
                    DeathHandler.HandleDeath(() => Part5());
                    return;
                }
            }
            else if (bear_choice == "2")
            {
                if (weapon_choice == "1")
                {
                    StringTyper.TypeString("You throw your HAMMER at the bear's head and it misses.");
                    StringTyper.TypeString("However, it hits the nutsack and kills the bear.");
                    StringTyper.TypeString("Everyone in the town suddenly appears around you and praises you as a hero!");
                    StringTyper.TypeString("\"I'm sorry for giving you a wedgie.\" says Mike F**k. \"I promise I'll make it up to you!\"");
                    StringTyper.TypeString("\"I couldn't be prouder of you, son\" says your Dad");
                    StringTyper.TypeString("GOOD ENDING!");
                    StringTyper.TypeString("(By the way, your Dad is a secret agent named Mike Mike. The man he was searching for, Mr. Sheit, died forty years ago. So that's why your Dad was mean to you.)");
                    StringTyper.TypeString("LORE INCORPORATED!", 50);
                    Program.TheEnd();
                }
                else if (weapon_choice == "2" || weapon_choice == "3")
                {
                    StringTyper.TypeString("You throw your " + (weapon_choice == "2" ? "SLAMMER" : "BLAMMER") + " at the bear and nothing happens because it isn't a real thing.");
                    StringTyper.TypeString("But the bear is confused by your weirdness and its brain explodes.");
                    StringTyper.TypeString("So you get a GOOD ENDING... I guess?");
                    Program.TheEnd();
                }
                else
                {
                    StringTyper.TypeString("The bear kills you because you didn't choose a weapon properly.");
                    StringTyper.TypeString("BAD ENDING!");
                    DeathHandler.HandleDeath(() => Part5());
                    return;
                }
            }
            else
            {
                StringTyper.TypeString("You hesitated too long. The bear mauls everyone, including you.");
                StringTyper.TypeString("BAD ENDING!");
                DeathHandler.HandleDeath(() => Part5());
                return;
            }
        }
    }
}