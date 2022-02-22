namespace TurtleChallenge.Core
{
    using Newtonsoft.Json;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;

    internal class PanelSettingsParser
    {
        public static PanelSettings GetSettings(string gameSettingsFilePath)
        {
            var fileName = Path.GetFileName(gameSettingsFilePath);

            if (fileName != "game-settings.json")
            {
                throw new ArgumentException("The settigns file should have game-settings as a name");
            }

            var panelSettingsJson = File.ReadAllText(gameSettingsFilePath);
            //var panelSettingsJson = File.ReadAllText("..\\..\\..\\GameSettings\\game-settings.json");

            return JsonConvert.DeserializeObject<PanelSettings>(panelSettingsJson);
        }
    }
}
