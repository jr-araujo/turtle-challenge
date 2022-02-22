namespace TurtleChallenge.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TurtleChallenge.Core.Domain.Enums;

    internal class Turtle : Character
    {
        public Direction CurrentDirection { get; private set; }

        public Turtle(Position startPosition)
            : base(startPosition)
        {

        }

        public void Move()
        {
            Position newPosition;

            switch (CurrentDirection)
            {
                case Direction.North:
                    newPosition = new Position { X = Position.X - 1, Y = Position.Y };
                    ConsoleEx.PrintTurtleMovement(Position, newPosition);
                    Position = newPosition;
                    break;
                case Direction.South:
                    newPosition = new Position { X = Position.X + 1, Y = Position.Y };
                    ConsoleEx.PrintTurtleMovement(Position, newPosition);
                    Position = newPosition;
                    break;
                case Direction.East:
                    newPosition = new Position { X = Position.X, Y = Position.Y + 1 };
                    ConsoleEx.PrintTurtleMovement(Position, newPosition);
                    Position = newPosition;
                    break;
                case Direction.West:
                    newPosition = new Position { X = Position.X, Y = Position.Y - 1 };
                    ConsoleEx.PrintTurtleMovement(Position, newPosition);
                    Position = newPosition;
                    break;
            }
        }

        public void Rotate()
        {
            switch (CurrentDirection)
            {
                case Direction.North:
                    CurrentDirection = Direction.East;
                    break;
                case Direction.South:
                    CurrentDirection = Direction.West;
                    break;
                case Direction.West:
                    CurrentDirection = Direction.North;
                    break;
                case Direction.East:
                    CurrentDirection = Direction.South;
                    break;
                default:
                    break;
            }

            ConsoleEx.PrintChangeDirection(CurrentDirection);
        }
    }
}
