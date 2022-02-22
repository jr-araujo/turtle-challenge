namespace TurtleChallenge.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TurtleChallenge.Core.Domain;

    internal class PanelSettings
    {
        public Size PanelSize { get; set; }
        public Position ExitDoor { get; set; }
        public List<Position> Mines { get; set; }
        public Turtle Turtle { get; set; }
    }
}
