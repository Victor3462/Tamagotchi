using System;
using System.Collections.Generic;
using Raylib_cs;

Console.WriteLine("Welcome your Tamagotchi is waiting for you!");
Console.WriteLine("");
Console.WriteLine("PRESS ENTER TO START");
Console.ReadLine();

Tamagotchi newTG = new Tamagotchi();
Console.Clear();
Console.WriteLine("What is your Tamagotchi's name going to be?");
newTG.name = Console.ReadLine();


while (newTG.GetAlive() == true)
{
    newTG.choice();

    string userChoice = Console.ReadLine();
    if (userChoice.ToLower() == "f")
    {
        newTG.feed();
    }
    if (userChoice.ToLower() == "h")
    {
        newTG.Hi();
    }
    if (userChoice.ToLower() == "t")
    {
        newTG.teach();
    }

}

Console.Clear();
Console.WriteLine($"{newTG.name} just died");
Console.WriteLine($"How are you so careless!");
Console.WriteLine($"");
Console.WriteLine($"Press ENTER to QUIT");
Console.ReadLine();



