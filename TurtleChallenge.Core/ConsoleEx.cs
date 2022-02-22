namespace TurtleChallenge.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TurtleChallenge.Core.Domain;
    using TurtleChallenge.Core.Domain.Enums;

    internal static class ConsoleEx
    {
        public static void PrintDead()
        {
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Poor turtle! It was exploded by a mine. GAME OVER!!!!!");
            Console.WriteLine(new string('-', 50));
        }

        public static void PrintTooCloseToAMine()
        {
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Stop Turtle! Your too close to a mine. Be careful!");
            Console.WriteLine(new string('-', 50));
        }

        public static void PrintGotExit()
        {
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Turtle, you're incredible! You got exit without touch in any of the mines!");
            Console.WriteLine(new string('-', 50));
        }

        public static void PrintOutOfThePanel()
        {
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Hey Dude! You get out from the panel. Jump into the game again!");
            Console.WriteLine(new string('-', 50));            
        }

        public static void PrintTurtleStartPosition(Position startPosition, Direction startDirection)
        {
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Turtel's starting position ({startPosition.X},{startPosition.Y}) | Direction: {startDirection}");
            Console.WriteLine(new string('-', 50));
        }

        public static void PrintTurtleMovement(Position currentPosition, Position newPosition)
        {
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"Turtle has moved its position from ({currentPosition.X}, {currentPosition.Y}) to ({newPosition.X}, {newPosition.Y})");
            Console.WriteLine(new string('-', 50));
        }

        public static void PrintAllGood()
        {
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Turtle all good! Keep going ahead!");
            Console.WriteLine(new string('-', 50));
        }

        public static void PrintChangeDirection(Direction direction)
        {
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Turned direction to {direction}!");
            Console.WriteLine(new string('-', 50));
        }
    }
}