using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        Part1();
    }

    static void Part1()
    {
        
        // Welcome message
        StringTyper.TypeString("Welcome to the eggscape room!");
        StringTyper.TypeString("You awaken in a padded white room.");
        StringTyper.TypeString("The only decoration in the room is a poster of an egg.");

        StringTyper.TypeString();

        StringTyper.TypeString("You try to remember your name...");

        string? fakeName = Console.ReadLine();


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

        if(choice1 == "1")
        {
            StringTyper.TypeString("You sit there, thinking and nothing happens.");
            StringTyper.TypeString("You die of boredom. (Go back in time as punishment)");
            Part1();
        }

        if(choice1 == "2")
        {
            StringTyper.TypeString("You knock on the door ahead of you.");
            StringTyper.TypeString("The door flies open. It is thrust open so quickly that it swings in your face.");
            StringTyper.TypeString("Your neck snaps and you die instantly. (Go back in time as punishment)");
            Part1();
        }

        } while (choice1 != "1" && choice1 != "2" && choice1 != "3");

        StringTyper.TypeString();

        string choice2 = "";

        if(choice1 == "3")
        {

            do{
            StringTyper.TypeString("You wake up. You're in your cozy bed. You are 15 years old.");
            StringTyper.TypeString("What do you do?");
            StringTyper.TypeString("1 -> use the toilet / loo / pooper");
            StringTyper.TypeString("2 -> wake up mommy and daddy and start crying like a baby because you had a bad dream.");
            StringTyper.TypeString("3 -> wake up");
            StringTyper.TypeString("Type 1, 2, or 3 below and then press enter:");
            choice2 = Console.ReadLine();

            StringTyper.TypeString();

            if(choice2 == "1")
            {
                StringTyper.TypeString("You thrust yourself out of bed and rush to the toilet to release your intestinal load.");
                StringTyper.TypeString("You did it! +25xp");
                StringTyper.TypeString();
                StringTyper.TypeString("Unfortunately. When you finish using the toilet,");
                StringTyper.TypeString("you accidentally close the lid on your private parts.");
                StringTyper.TypeString("This instantly crushes them. You die. (Go back in time as punishment)");
                Part1();
            }

            if(choice2 == "3")
            {
                StringTyper.TypeString("You can't wake up if you're already awake! stupid! You die. (Go back in time as punishment)");
                Part1();
            }

            

            } while (choice2 != "1" && choice2 != "2" && choice2 != "3");
        }

        if(choice2 == "2")
        {
            StringTyper.TypeString("MOMMY!! DADDY!! You scream, running from your room with snot coming out of your mouth.");
            StringTyper.TypeString("MUH MUH MIH MUH MOMMY I HAD A BAD DREAM.");
            StringTyper.TypeString("\"I wish I never had a son\" says your Dad.");
            StringTyper.TypeString("\"My poor babyy1!\" says your Mom.");
            
            StringTyper.TypeString("She gives you a kiss on the cheek and a lollipop.");
            StringTyper.TypeString("YUMMY! +25 xp");

            PauseForUserInput();

            Part2();
        }

    }

    static void Part2()
    {
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

        if(yell.Contains("Fuck", StringComparison.OrdinalIgnoreCase) || yell.Contains("Shit", StringComparison.OrdinalIgnoreCase) || yell.Contains("Bitch", StringComparison.OrdinalIgnoreCase) || yell.Contains("crap", StringComparison.OrdinalIgnoreCase) || yell.Contains("Poop", StringComparison.OrdinalIgnoreCase) || yell.Contains("God Dammit", StringComparison.OrdinalIgnoreCase) || yell.Contains("God Damn It", StringComparison.OrdinalIgnoreCase))
        {
            StringTyper.TypeString("The principal, who so happened to be fixing a locker in that hallway with a handheld drill,");
            StringTyper.TypeString("runs over to you and drills a hole through your skull in his fury. You die.");
            StringTyper.PoopDelay(500);
            Console.WriteLine();
            StringTyper.TypeString("Plase press enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Part2();
        } else
        {
            StringTyper.TypeString("Mike drops you to the ground and kicks you in the stomach.");
            StringTyper.TypeString("Then he and his gooners walk away.");

            StringTyper.PoopDelay();

            StringTyper.TypeString("The principal closes the shutters from behind the window he was watching from.");

            StringTyper.TypeString();

            StringTyper.TypeString("You go about your day in embarrasment. Your underpants have been stretched so much by the wedgie,");
            StringTyper.TypeString("That they hang out of the back of your pants for the rest of the day.");
            StringTyper.TypeString("Kids left and right make fun of both your over-stretched tightie-whities, and the brown stains all over them.");
            
            StringTyper.TypeString("Plase press enter to continue.");
            Console.ReadLine();

            StringTyper.TypeString("...", 100);

            StringTyper.TypeString("You go home. You find that it is ablaze.");
            StringTyper.TypeString("A firetruck swerves around the corner. It is driving at 60mph towards you!");

            StringTyper.TypeString("Choose a self-defense option to avoid dying:");
            StringTyper.PoopString("1 - jump out of the way", 50);
            StringTyper.PoopString("2 - stop the firetruck with your bare hands", 50);
            StringTyper.PoopString("3 - stop, drop, and roll under the firetruck", 50);
            Console.WriteLine();
            StringTyper.PoopString("Put your response here: ");

            string dodge_choice = Console.ReadLine();
            if(dodge_choice == "1")
            {
                StringTyper.TypeString("Okie doke. You jump out of the way but the firetruck swerves at the last second and hits you. You die. Go back in time...");
                Part2();
            } else if(dodge_choice == "2")
            {
                StringTyper.TypeString("Okie doke. You put your hands forward and plant your heel firmly behind you. You've conjured up the most stable stance that you ever have, or ever will stand in. The truck runs you over and you die.");
                StringTyper.PoopDelay();
                StringTyper.TypeString("Going back in time...");
                StringTyper.PoopDelay();
                
                Part2();
            } else if (dodge_choice == "3")
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
                
            } else
            {
                StringTyper.TypeString("Oh my gooooood dude what the fuck is wrong with you? You can only choose options 1, 2, or 3. Ok? Now go back in time as a penalty.");
                Part2();
            }

            return;

        }
    }

    static string weapon_choice = "";
    
    static void Part3()
    {
        PauseForUserInput();

        StringTyper.PoopDelay(500);
        StringTyper.TypeString("You are dreaming once again. In your dream, you get to choose a weapon.");
        StringTyper.TypeString("This weapon is like super important for the future");
        StringTyper.TypeString("It will incrase your attank powder. So chose wiesely.");

        StringTyper.TypeString("\nGuh okie. dokie. So your options are: ");
        StringTyper.TypeString("1) Hammer ");
        StringTyper.TypeString("2) Slammer");
        StringTyper.TypeString("3) Blammer");

        string choice = "";
        choice = Console.ReadLine();
        if(choice == "1")
        {
            StringTyper.TypeString("Yeah I guess that's a reasonable choice.");
        } else if (choice == "2")
        {
            StringTyper.TypeString("wtf is a slammer?");
        } else if (choice == "3")
        {
            StringTyper.TypeString("wtf is a blammer?");
        } else
        {
            StringTyper.TypeString("what that means?");
        }

        weapon_choice = choice;
        
        StringTyper.TypeString("Alright that choice was super duper very very importante. Comprende?");
        StringTyper.TypeString("All rye.");

        Part4();
    }

    static void Part4()
    {
        PauseForUserInput();

        StringTyper.TypeString("You wake up on damp grass. You are freezing cold, and it's still dark out. Your family has had to sleep in the woods because your house burned down and was crashed into by a firetruck.");
        StringTyper.PoopDelay();
        StringTyper.TypeString("It turns out that the fire was all your fault. You left your fifteen lit candles on your bed.");
        StringTyper.TypeString("The cat jumped on the bed and caught fire because of the candles.");
        StringTyper.TypeString("After running around the house in panic, the cat ended up setting every piece of furniture on fire.");
        StringTyper.TypeString("Amazingly, the cat survived, but your dog died.");

        PauseForUserInput();
        
        StringTyper.TypeString("Your Dad hates you because all of his silver and gold were destroyed in the fire.");
        StringTyper.TypeString("Your Mom hates you because all of his silver and gold were destroyed in the fire.");
        StringTyper.TypeString("As for your punishment, you are forced to sleep outside of the tent on the cold ground instead of in the warm, heated tent");
        
        StringTyper.PoopDelay(1000);
        StringTyper.TypeString("What do you say to try in an attempt to repair your relationship?");
        
        StringTyper.PoopString("1) Sorry", 100);
        StringTyper.PoopString("2) Sowee", 100);
        StringTyper.PoopString("3) Dada I sowee. O_0. Pwease dont make me sweep outswide the twent.", 100);
        
        StringTyper.PoopDelay(1000);

        var relationship_repair_choice = Console.ReadLine();

        if(relationship_repair_choice == "1")
        {
            StringTyper.TypeString("You enter their tent in an attempt to apologize to your parents. Unfortunately, they are in the midst of making love.");
            StringTyper.TypeString("Immediately, your Dad pulls a pistol out from under their bedsheets and shoots you square in the forehead.");
            StringTyper.TypeString("You Died! Go back in time as punishment...");
            Part4();
        }
        else if (relationship_repair_choice == "2")
        {
            StringTyper.TypeString("You enter their tent in an attempt to apologize to your parents. You say \"Sowee\" to your Dad, who has woken up and is staring at you as if you were one of his sleep paralysis demons.");
            StringTyper.TypeString("\"What the hell even is that?\" he says, looking at you.");
            StringTyper.TypeString("You consider this apology a success.");
            Part5();
        } else if (relationship_repair_choice == "3")
        {
            StringTyper.TypeString("You enter their tent in an attempt to apologize to your parents.");
            StringTyper.TypeString("As your perform shy finger twiddling, you say to your Dad, \"Dada I sowee. O_0. Pwease dont make me sweep outswide the twent.\"");
            StringTyper.TypeString("He looks angry and disappointed at you. But then, he breaks down into tears.");
            StringTyper.TypeString("He says, \"Son, I'm so sorry for being so cruel to you. I promise that things will be different from now on.\"");
            StringTyper.TypeString("You hear a strange rumbling noise.");
            StringTyper.TypeString("You and your parents leave the tent, and see that your house has been completely rebuilt!");
            StringTyper.TypeString("Howdy, neighbor! Says all of your neighbors in unison.");
            StringTyper.TypeString("We decided to rebuild your house for you! They say.");
            StringTyper.TypeString("Then they like fade into dust like in Avengers Infinity War");
            StringTyper.TypeString("Well, says your Dad, looks like it's a happily ever after!");
            
            TheEnd();
        } else
        {
            StringTyper.TypeString("You enter their tent in an attempt to apologize to your parents. They are in the midst of making love.");
            StringTyper.TypeString("As soon as he sees you, your Dad pulls a pistol out from under their bedsheets and shoots you square in the forehead.");
            StringTyper.TypeString("You Died! Go back in time as punishment...");
            Part4();
        }

        static void Part5()
        {
            PauseForUserInput();
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

            if(bear_choice == "1")
            {
                StringTyper.PoopDelay(500);
                StringTyper.TypeString("You watch as the bear eats your parents.");
                StringTyper.TypeString("Then the bear turns and eats you.");
                StringTyper.TypeString("I guess your actions have consequences, hrmmmm?");
                Part5();
                
            } else if(bear_choice == "2")
            {
                if(weapon_choice == "1")
                {
                    StringTyper.TypeString("You throw your HAMMER at the bear's head and it misses.");
                    StringTyper.TypeString("However, it hits he nutsack and kills the bear.");
                    StringTyper.TypeString("Everyone in the town suddenly appears around you and praises you as a hero!");
                    StringTyper.TypeString("\"I'm sorry for giving you a wedgie.\" says Mike F**k. \"I promise I'll make it up to you!\"");
                    StringTyper.TypeString("\"I couldn't be prouder of you, son\" says your Dad");
                    StringTyper.TypeString("GOOD ENDING!");
                    StringTyper.TypeString("(By the way, your Dad is a secret agent named Mike Mike. The man he was searching for, Mr. Sheit, died forty years ago. So that's why your Dad was mean to you.)");
                    StringTyper.TypeString("LORE INCORPORATED!", 50);
                    TheEnd();

                } else if (weapon_choice == "2")
                {
                    StringTyper.TypeString("You throw your SLAMMER at the bear and nothing happens because a SLAMMER isn't a real thing.");
                    StringTyper.TypeString("But the bear is confused by your weirdness and its brain explodes.");
                    StringTyper.TypeString("So you get a GOOD ENDING... I guess?");
                    TheEnd();
                    
                    
                } else if (weapon_choice == "3")
                {
                    StringTyper.TypeString("You throw your BLAMMER at the bear and nothing happens because a BLAMMER isn't a real thing.");
                    StringTyper.TypeString("But the bear is confused by your weirdness and its brain explodes.");
                    StringTyper.TypeString("So you get a GOOD ENDING... I guess?");
                    TheEnd();
                } else
                {
                    StringTyper.TypeString("The bear kills you because you didn't choose a weapon properly.");
                    StringTyper.TypeString("BAD ENDING!");
                    TheEnd();
                }
            }
            
            

            
            

        }


    }

    static void PauseForUserInput()
    {
        StringTyper.PoopDelay();
        Console.WriteLine();
        StringTyper.TypeString("Press Enter to Continue...");
        Console.ReadLine();
        Console.WriteLine();
    }

    static void TheEnd()
    {
        StringTyper.TypeString("The End!");
    }
}