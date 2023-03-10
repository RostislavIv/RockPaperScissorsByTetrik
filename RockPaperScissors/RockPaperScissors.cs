using System.Drawing;

const string rock = "Rock";
const string paper = "Paper";
const string scissors = "Scissors";
int compPoints = 0;
int playerPoints = 0;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Blue;
Console.Clear();
while (true)
{
    Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors, [e]xit");
    string playerChoose = Console.ReadLine();
    if (playerChoose.ToLower() == "r" || playerChoose == "rock")
        playerChoose = rock;
    else if (playerChoose.ToLower() == "p" || playerChoose == "paper")
        playerChoose = paper;
    else if (playerChoose.ToLower() == "s" || playerChoose == "scissors")
        playerChoose = scissors;
    else if (playerChoose.ToLower() == "e" || playerChoose == "exit")
        break;
    else
        Console.WriteLine("Invalid Input. Try Again...");

    if (playerChoose == rock || playerChoose == paper || playerChoose == scissors)
    {
        string compChoose = "";
        Random rnd = new Random();
        switch (rnd.Next(1, 4))
        {
            case 1: compChoose = rock; break;
            case 2: compChoose = paper; break;
            case 3: compChoose = scissors; break;
        }
        Console.WriteLine($"you chose         : {playerChoose}");
        Console.WriteLine($"the computer chose: {compChoose}");
        if (playerChoose == compChoose)
        {
            Console.WriteLine("Drow");
        }
        else if
            ((playerChoose == rock && compChoose == scissors) ||
            (playerChoose == paper && compChoose == rock) ||
            (playerChoose == scissors && compChoose == paper))
        {
            Console.WriteLine("You win");
            playerPoints++;
        }
        else
        {
            Console.WriteLine("You lose");
            compPoints++;
        }
        Console.WriteLine("Curent result:");
        Console.WriteLine($"You:      {playerPoints} points");
        Console.WriteLine($"Computer: {compPoints} points");
    }
    Console.WriteLine();
}
Console.WriteLine("Finale result:");
Console.WriteLine($"You:      {playerPoints} points");
Console.WriteLine($"Computer: {compPoints} points");
