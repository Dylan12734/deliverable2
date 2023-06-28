using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

internal partial class Program 
{
    private static void Main(string[] args)
    {
Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("welcome" + name + ". Do you want to do the COIN FLIP CHALLENGE?");
string answer = Console.ReadLine();
if (answer == "no")
{
    Console.WriteLine("You are a coward " + name); 
}
if (answer == "yes") 
{
    for (int i = 1; i < 5; i++)
    {


        Random rand = new Random();
        int randNum = rand.Next(0, 2);
        int score = 0;

        Console.WriteLine("Choose Heads or Tails");
        String guess1 = Console.ReadLine();
        if (randNum == 0 && guess1 == "Heads")
        {
            Console.WriteLine("Correct");
            score++;
        }
        if (randNum == 0 && guess1 == "Tails")
        {
            Console.WriteLine("incorrect");
        }
        if (randNum == 1 && guess1 == "Tails")
        {
            Console.WriteLine("correct");
            score++;
        }
        if (randNum == 1 && guess1 == "Heads")
        {
            Console.WriteLine("incorrect");
        }
    }
}
}
}