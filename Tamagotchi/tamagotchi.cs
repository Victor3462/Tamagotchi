using System;
using System.Collections.Generic;

public class Tamagotchi
{
    public string name;

    private int boredom;
    private int hunger;
    
    private bool isAlive;


    private Random generator;

    private List<string> words = new List<string>() {"Hello!"};

public Tamagotchi()
{
    isAlive = true;
    generator = new Random();
}

public void feed()
{
    Console.WriteLine($"{name} Tamagotchi just ate!");


    hunger = hunger + 10;

    if(hunger < 0) {hunger = 0; }
    if(hunger > 100){hunger = 100;}
    
     // jag tycker det är mer logiskt att hunger går ner och inte upp

}

public void printStats()
{
    Console.WriteLine($"Name: {name}, Hunger: {hunger}/100, Boredom: {boredom}");

}

private void reduceBoredom()
{
    Console.WriteLine($"{name} is having fun and is now less bored!");
    boredom = boredom + 10;
    if(boredom > 0){boredom = 0;}
    if(boredom < 100){boredom = 100;}
}

public void Hi() 
{
    Console.WriteLine($"Hello, {words}!");
    reduceBoredom();
}

public void tick()
{
    boredom = boredom - 5;
    hunger = hunger - 5;

    if(hunger < 10 || boredom < 10)
    {
        isAlive = false;
    }
}

public void teach(string word)
{
    Console.WriteLine($"What word would you like to teach {name}?");
    word = Console.ReadLine();
    words.Add(word);
    reduceBoredom();
    Console.WriteLine($"{name} just learnt the word: {word}!");
}
}
