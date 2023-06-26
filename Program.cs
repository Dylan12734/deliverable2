using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("welcome" + name + ". Do you want to do the COIN FLIP CHALLENGE?");
string answer = Console.ReadLine();
if (answer == "yes");
{
    Random rand1 = new Random();
    int randNum1 = rand1.Next();
    int score = 0;

    Console.WriteLine("Choose Heads or Tails");
    String guess1 = Console.ReadLine();
    if (randNum1 == 1 && guess1 == "Heads")
    {
        Console.WriteLine("Correct");
        score++;
    }
    if (randNum1 == 1 && guess1 == "Tails")
    {
        Console.WriteLine("incorrect");
    }
    if (randNum1 == 2 && guess1 == "Tails")
    {
        Console.WriteLine("correct");
        score++;
    }
    if (randNum1 == 2 && guess1 == "Heads")
    {
        Console.WriteLine("incorrect");
    }
    Random rand2 = new Random();
    int randNum2 = rand2.Next();

    Console.WriteLine("Choose Heads or Tails");
    string guess2 = Console.ReadLine();
    if (randNum2 == 1 && guess2 == "Heads")
    {
        Console.WriteLine("correct");
        score++;
    }
    if (randNum2 == 1 && guess2 == "Tails")
    {
        Console.WriteLine("incorrect");
    }
    if (randNum2 == 2 && guess2 == "Tails")
    {
        Console.WriteLine("correct");
        score++;
    }
    if (randNum2 == 2 && guess2 == "Heads")
    {
        Console.WriteLine("incorrect");
    }
    Random rand3 = new Random();
    int randNum3 = rand3.Next();

    Console.WriteLine("Choose Heads or Tails");
    string guess3 = Console.ReadLine();
    if (randNum3 == 1 && guess3 == "Heads")
    {
        Console.WriteLine("correct");
        score++;
    }
    if (randNum3 == 1 && guess3 == "Tails")
    {
        Console.WriteLine("incorrect");
    }
    if (randNum3 == 2 && guess3 == "Tails")
    {
        Console.WriteLine("correct");
        score++;
    }
    if (randNum3 == 2 && guess3 == "Heads")
    {
        Console.WriteLine("incorrect");
    }
    Random rand4 = new Random();
    int randNum4 = rand4.Next();

    Console.WriteLine("Choose Heads or Tails");
    string guess4 = Console.ReadLine();
    if (randNum4 == 1 && guess4 == "Heads")
    {
        Console.WriteLine("correct");
        score++;
    }
    if (randNum4 == 1 && guess4 == "Tails")
    {
        Console.WriteLine("incorrect");
    }
    if (randNum4 == 2 && guess4 == "Tails")
    {
        Console.WriteLine("correct");
        score++;
    }
    if (randNum4 == 2 && guess4 == "Heads")
    {
        Console.WriteLine("incorrect");
    }
    Random rand5 = new Random();
    int randNum5 = rand5.Next();

    Console.WriteLine("choose Heads or Tails");
    string guess5 = Console.ReadLine();
    if (randNum5 == 1 && guess5 == "Heads")
    {
        Console.WriteLine("correct");
        score++;
    }
    if (randNum5 == 1 && guess5 == "Tails")
    {
        Console.WriteLine("incorrect");
    }
    if (randNum5 == 2 && guess5 == "Tails")
    {
        Console.WriteLine("correct");
        score++;
    }
    if (randNum5 == 2 && guess5 == "Heads")
    {
        Console.WriteLine("incorrect");
    }
    Console.WriteLine("Your final score is"+ score );
}
if (answer == "no");
{
    Console.WriteLine("You are a coward" + name);
}
