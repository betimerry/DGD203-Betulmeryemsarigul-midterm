using System;

class Zombie
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hey man, this must be the end of the world, the zombie plague is everywhere. First of all, can I get your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Really cool name! Let's try to escape to the shelter now, " + name);

        int score = 0;

        // Soru 1
        Console.WriteLine("You are at home and you learned the location of the shelter from the radio. You hear zombies outside your house. What do you do?");
        Console.WriteLine(" A) Look for a weapon in the house\n B) Sneak out through the back door");
        char answer1 = GetValidAnswer();

        if (answer1 == 'A')
        {
            Console.WriteLine("You find a butcher knife. This is really good.");
            score += 7;
        }
        else if (answer1 == 'B')
        {
            Console.WriteLine("You sneak out, avoiding the zombies, but you're exposed outside.");
            score += 3;
        }

        //  Soru 2
        char answer2 = ' ';
        if (answer1 == 'A')
        {
            Console.WriteLine("You're facing a zombie with a butcher knife, " + name + ".");
            Console.WriteLine("A) Attack it head-on\nB) Distract it and run");
            answer2 = GetValidAnswer();

            if (answer2 == 'A')
            {
                Console.WriteLine("You fight the zombie and win. But during the fight your hand gets stuck under the cupboard that falls on you.");
                score += 2;
            }
            else if (answer2 == 'B')
            {
                Console.WriteLine("You successfully distract the zombie and escape.");
                score += 7;
            }
        }
        else if (answer1 == 'B')
        {
            Console.WriteLine("You have come to a crossroads, " + name + ".");
            Console.WriteLine("A) Dangerous but take the shortcut\nB) Take the long and safe route");
            char answer3 = GetValidAnswer();

            if (answer3 == 'A')
            {
                Console.WriteLine("You took serious damage and took cover near the shelter.");
                score += 1;
            }
            else if (answer3 == 'B')
            {
                Console.WriteLine("Your body was exhausted, but you took a break near the shelter.");
                score += 7;
            }
        }

        // Soru 3
        if (answer2 == 'A')
        {
            Console.WriteLine("To escape, you should cut your hand, " + name + ".");
            Console.WriteLine("A) Cut your hand\nB) Don't cut your hand, shout for help.");
            char answer4 = GetValidAnswer();

            if (answer4 == 'A')
            {
                Console.WriteLine("You cut your hand and escaped, taking refuge near the shelter.");
                score += 7;
            }
            else if (answer4 == 'B')
            {
                Console.WriteLine("You were injured by zombies, but luckily a helpful person saved you and took you in his car.");
                score += 2;
            }
        }
        else if (answer2 == 'B')
        {
            Console.WriteLine("You have come to a crossroads, " + name + ".");
            Console.WriteLine("A) Dangerous but take the shortcut\nB) Take the long and safe route");
            char answer3 = GetValidAnswer();

            if (answer3 == 'A')
            {
                Console.WriteLine("Thanks to your knife, you got to a place near the shelter without getting hurt.");
                score += 6;
            }
            else if (answer3 == 'B')
            {
                Console.WriteLine("Your body was exhausted, but you took a break near the shelter.");
                score += 3;
            }
        }

        // Soru 4 - Final
        Console.WriteLine("The shelter is finally in sight, " + name + ". Before you can enter, there's a final decision to make.");
        Console.WriteLine("A) Rush into the shelter quickly\nB) Wait cautiously, checking for any zombies lurking nearby");
        char finalAnswer = GetValidAnswer();

        if (finalAnswer == 'A')
        {
            Console.WriteLine("You rush into the shelter, but there are zombies inside! You barely make it out.");
            score -= 2;
        }
        else if (finalAnswer == 'B')
        {
            Console.WriteLine("You wait cautiously, spotting a few zombies trying to sneak up on you. You manage to avoid them and safely enter the shelter.");
            score += 5;
        }


        Console.WriteLine("You've reached the shelter, " + name + ".");
        Console.WriteLine("Let's see how well you've done...");

        if (score >= 25)
        {
            Console.WriteLine("You're a true survivor! You've made all the right choices and have survived the zombie apocalypse!");
        }
        else if (score >= 15)
        {
            Console.WriteLine("You made it, but it wasn't easy. You survived, but you could have done better.");
        }
        else
        {
            Console.WriteLine("You didn't make it. The zombies got you... Better luck next time.");
        }
    }


    static char GetValidAnswer()
    {
        while (true)
        {
            char answer = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (answer == 'A' || answer == 'a' || answer == 'B' || answer == 'b')
            {
                return char.ToUpper(answer);
            }
            Console.WriteLine("You must choose a valid option (A or B). Try again:");
        }
    }
}
