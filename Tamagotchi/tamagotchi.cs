

public class Tamagotchi
{
    public string name;

    private int boredom;
    private int hunger;
    
    private bool isAlive;

    private random generator;

    private List<string> words = new List<string>() {"Hello!"}
}

public Tamagotchi()
{
    isAlive = true;
    generator = new random();
}

public void feed()
{
    Console.WriteLine("Your Tamagotchi just ate!");

    hunger = hunger + 10;

    if(hunger < 0) {hunger = 0; }
    if(hunger > 100){hunger = 100;}
    
     // jag tycker det är mer logiskt att hunger går ner och inte upp

}