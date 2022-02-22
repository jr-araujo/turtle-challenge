// See https://aka.ms/new-console-template for more information
using TurtleChallenge.Core;

if ((args.Length < 2) || (args.Length > 2))
{
    throw new ArgumentException("You can only pass 2 files as parameters");
}

if (string.IsNullOrWhiteSpace(args[0]) || string.IsNullOrWhiteSpace(args[1]))
{
    throw new ArgumentException("You MUST pass 2 files as parameters");
}

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("------------------------- Welcome to the GREAT Challenge -------------------------");
Console.WriteLine(Figgle.FiggleFonts.Doom.Render("Turtle Challenge"));
Console.WriteLine(new string('-', 75));
Console.ResetColor();
Console.WriteLine();

Game.New(args[0], args[1]).Start();

Console.ResetColor();