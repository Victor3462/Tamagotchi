<<<<<<< HEAD
using System;
using System.Collections.Generic;
=======

>>>>>>> 1469a175bcfeb16c1d3b085874e6edb3f811046b

public class Tamagotchi
{
    public string name;

    private int boredom;
    private int hunger;
    
    private bool isAlive;

<<<<<<< HEAD
    private Random generator;

    private List<string> words = new List<string>() {"Hello!"};
=======
    private random generator;

    private List<string> words = new List<string>() {"Hello!"}
}
>>>>>>> 1469a175bcfeb16c1d3b085874e6edb3f811046b

public Tamagotchi()
{
    isAlive = true;
<<<<<<< HEAD
    generator = new Random();
=======
    generator = new random();
>>>>>>> 1469a175bcfeb16c1d3b085874e6edb3f811046b
}

public void feed()
{
<<<<<<< HEAD
    Console.WriteLine("${name} Tamagotchi just ate!");
=======
    Console.WriteLine("Your Tamagotchi just ate!");

    hunger = hunger + 10;

    if(hunger < 0) {hunger = 0; }
    if(hunger > 100){hunger = 100;}
    
     // jag tycker det är mer logiskt att hunger går ner och inte upp

<<<<<<< HEAD
}
=======
>>>>>>> 1469a175bcfeb16c1d3b085874e6edb3f811046b
}