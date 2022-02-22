namespace TurtleChallenge.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Character
    {
        public Character(Position position)
        {
            Position = position;
        }

        public Position Position { get; set; }
    }
}
