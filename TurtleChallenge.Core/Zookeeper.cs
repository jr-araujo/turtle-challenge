namespace TurtleChallenge.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TurtleChallenge.Core.Domain;
    using TurtleChallenge.Core.Domain.Enums;

    internal class Zookeeper
    {
        public Panel _panel;

        public Zookeeper(Panel panel)
        {
            _panel = panel;
        }

        public Situation Monitore(Position currentPosition)
        {
            if (Exited(currentPosition))
            {
                return Situation.GotExit;
            }
            else if (Exploded(currentPosition))
            {
                return Situation.Dead;
            }
            else if (OutOfThePanel(currentPosition))
            {
                return Situation.OutOfThePanel;
            }
            else if (TooCloseToTheMine(currentPosition))
            {
                return Situation.CloseToTheMine;
            }
            else
                return Situation.Alright;
        }

        public bool TooCloseToTheMine(Position position)
        {
            var adjacentPoints = GetPositionsAround(position);
            return adjacentPoints.Any(x => _panel[position] is Mine);
        }

        private bool Exploded(Position position)
        {
            return _panel[position] is Mine;
        }

        private bool OutOfThePanel(Position position)
        {
            return position.X < 0 || position.X >= _panel.Size.Height || position.Y < 0 || position.Y >= _panel.Size.Width;
        }

        private bool Exited(Position position)
        {
            return _panel[position] is ExitDoor;
        }

        private List<Position> GetPositionsAround(Position position)
        {
            var list = new List<Position>();

            if (position.X - 1 >= 0) list.Add(new Position { X = position.X - 1, Y = position.Y });
            if (position.X - 1 >= 0 && position.Y - 1 >= 0) list.Add(new Position { X = position.X - 1, Y = position.Y - 1 });
            if (position.X - 1 >= 0 && position.Y + 1 < _panel.Size.Width) list.Add(new Position { X = position.X - 1, Y = position.Y + 1 });
            if (position.X + 1 < _panel.Size.Height) list.Add(new Position { X = position.X + 1, Y = position.Y });
            if (position.X + 1 < _panel.Size.Height && position.Y - 1 >= 0) list.Add(new Position { X = position.X + 1, Y = position.Y - 1 });
            if (position.X + 1 < _panel.Size.Height && position.Y + 1 < _panel.Size.Width) list.Add(new Position { X = position.X + 1, Y = position.Y + 1 });
            if (position.Y - 1 >= 0) list.Add(new Position { X = position.X, Y = position.Y - 1 });
            if (position.Y + 1 < _panel.Size.Width) list.Add(new Position { X = position.X, Y = position.Y + 1 });

            return list;
        }
    }
}
