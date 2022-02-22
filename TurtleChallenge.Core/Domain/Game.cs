namespace TurtleChallenge.Core
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TurtleChallenge.Core.Domain;

    public class Game
    {
        private Turtle _turtle;
        private Panel _panel;
        private Zookeeper _zookeeper;

        private string _actionsSettingsFilePath = "";

        private Game(string gameSettingsFilePath, string actionsSettingsFilePath)
        {
            
            _actionsSettingsFilePath = actionsSettingsFilePath;

            var settings = PanelSettingsParser.GetSettings(gameSettingsFilePath);

            _panel = Panel.NewEmptyPanel(settings.PanelSize.Height, settings.PanelSize.Width);

            ConfigureTurtle(settings.Turtle.Position);
            ConfigureExitDoor(settings.ExitDoor);
            ConfigureMines(settings.Mines);

            _turtle = settings.Turtle;
            _zookeeper = new Zookeeper(_panel);
        }

        public static Game New(string gameSettingsFilePath, string actionsSettingsFilePath)
        {
            return new Game(gameSettingsFilePath, actionsSettingsFilePath);
        }

        public void Start()
        {
            var movesSequencesSettings = ActionsSequencesSettingsParser.GetMovesSettings(_actionsSettingsFilePath);
            var actionsSequences = movesSequencesSettings.ActionsSequences;

            foreach (var action in actionsSequences)
            {
                if (action == Domain.Enums.Action.Move)
                {
                    _turtle.Move();
                }
                else if (action == Domain.Enums.Action.Rotate)
                {
                    _turtle.Rotate();
                }

                // Simulate pausing to think a little bit in the game
                Thread.Sleep(500);

                var situation = _zookeeper.Monitore(_turtle.Position);

                if (situation == Domain.Enums.Situation.OutOfThePanel)
                {
                    ConsoleEx.PrintOutOfThePanel();
                }
                else if (situation == Domain.Enums.Situation.CloseToTheMine)
                {
                    ConsoleEx.PrintTooCloseToAMine();
                }
                else if (situation == Domain.Enums.Situation.Dead)
                {
                    ConsoleEx.PrintDead();

                    return;
                }
                else if (situation == Domain.Enums.Situation.GotExit)
                {
                    ConsoleEx.PrintGotExit();

                    return;
                }
                else if (situation == Domain.Enums.Situation.Alright)
                {
                    ConsoleEx.PrintAllGood();
                }
            }
        }

        internal void ConfigureTurtle(Position startPosition)
        {
            _panel[startPosition] = new Turtle(startPosition);
        }

        internal void ConfigureMines(List<Position> mines)
        {
            for (int i = 0; i <= mines.Count()-1; i++)
            {
                _panel[mines[i]] = new Mine(mines[i]);
            }
        }

        internal void ConfigureExitDoor(Position exitDoor)
        {
            _panel[exitDoor] = new ExitDoor(exitDoor);
        }

        internal void SetConsoleTextColor(ConsoleColor color)
        {
            Console.ResetColor();
            Console.ForegroundColor = color;
        }

    }
}
