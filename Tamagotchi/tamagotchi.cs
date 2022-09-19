using System;
using System.Collections.Generic;

public class Tamagotchi
{
    public string name;
    public string word;
    private int boredom;
    private int hunger;
    private bool isAlive;
    private Random generator = new Random();
    private List<string> words = new List<string>();

    public Tamagotchi()
    {
        isAlive = true;
        hunger = 50;
        boredom = 50;
        // BASE STATS   

    }

    public void feed()
    {
        int rndFeed = generator.Next(5, 20);

        Console.WriteLine($"{name} Tamagotchi just ate! +{rndFeed} hunger!");



        hunger = hunger + rndFeed;

        if (hunger < 0) { hunger = 0; }
        if (hunger > 100) { hunger = 100; }

        Console.ReadLine();

        // jag tycker det är mer logiskt att hunger går ner och inte upp

    }

    public void printStats()
    {
        Console.WriteLine($"Name: {name} Hunger: {hunger}/100 Boredom: {boredom}");
        Console.ReadLine();

        // printar tmcghis stats 

    }

    private void reduceBoredom()
    {

        int rndFun = generator.Next(5, 20);
        Console.WriteLine($"{name} is having fun and is now less bored! +{rndFun} boredom!");


        boredom = boredom + rndFun;

        if (boredom < 0) { boredom = 0; }
        if (boredom > 100) { boredom = 100; }
        Console.ReadLine();

        // När denna körs så har tmchi roligare och boredom staten blir + 10-20
    }

    public void Hi()
    {
        int rndWord = generator.Next(words.Count);

        if (words.Count > 0)
        {
            Console.WriteLine($"{name} says {words[rndWord]}!");
            reduceBoredom();
        }
        else if (words.Count == 0)
        {
            Console.WriteLine($"Teach {name} a word first!");
            Console.ReadLine();
        }

        // Tar en slumpmässig int från totalen av ord i words
        // om det finns ord där så säger tmchi ordet annars måste man lära den ett ord först
    }

    public void tick()
    {
        boredom = boredom - 5;
        hunger = hunger - 5;

        if (hunger < 0 || boredom < 0)
        {
            isAlive = false;
        }
        // Varje gång den körs blir b och h - 5 av sin value
        //varje gång denna körs så kollaren den om isAlive ska vara true eller false bereonde på tchi stats
    }

    public void teach()
    {
        Console.WriteLine($"What word would you like to teach {name}?");
        word = Console.ReadLine();
        words.Add(word);
        Console.WriteLine($"{name} just learnt the word: {word}!");
        reduceBoredom();

        // Lär Tamagotchin ord genom att fråga om orden sen spara den i word stringen som i sin tur,
        // blir en del av words listen. 

    }

    public bool GetAlive()
    {
        return isAlive;
    }

    public void nothing()
    {
        Console.WriteLine("You're boring! Choose something next time!");

        Console.ReadLine();

        // Använde aldrig pga helt onödigt
    }

    public void choice()
    {
        Console.Clear();
        Console.WriteLine($"Choose one option:");
        Console.WriteLine($"F: Dinner Time for {name}");
        Console.WriteLine($"T: Teach {name} a word");
        Console.WriteLine($"H: Say Hi to {name}");
        Console.WriteLine($"P: See {name}'s Stats");
        Console.WriteLine(" ");
        Console.WriteLine($"Name: {name} Hunger: {hunger}/100 Boredom: {boredom}/100");
        Console.WriteLine(" ");


        tick();

        // säger sig självt vad som händer här
    }

}
