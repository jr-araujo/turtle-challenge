namespace TurtleChallenge.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TurtleChallenge.Core.Domain;

    internal class Panel
    {
        private Cell[,] _cells;
        public Size Size { get; }

        private Panel(int panelHeight, int panelWidth)
        {
            _cells = new Cell[panelWidth, panelHeight];

            for (int x = 0; x < panelWidth; x++)
            {
                for (int y = 0; y < panelHeight; y++)
                {
                    _cells[x, y] = new Cell();
                }
            }

            Size = new Size(panelWidth, panelHeight);
        }

        public static Panel NewEmptyPanel(int panelHeight, int panelWidth)  
        {
            return new Panel(panelHeight, panelWidth);
        }

        public Character this[Position position]
        {
            get { return _cells[position.X, position.Y].Character; }
            set { _cells[position.X, position.Y].Character = value; }
        }
    }
}