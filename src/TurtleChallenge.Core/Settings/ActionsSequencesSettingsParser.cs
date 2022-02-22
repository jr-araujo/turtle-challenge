namespace TurtleChallenge.Core
{
    using Newtonsoft.Json;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class ActionsSequencesSettingsParser
    {        
        public static ActionsSequencesSettings GetMovesSettings(string actionsSettingsFilePath)
        {
            var fileName = Path.GetFileName(actionsSettingsFilePath);

            if (fileName != "actions-settings.json")
            {
                throw new ArgumentException("The actions settigns file should have actions-settings as a name");
            }

            var actionsJson = File.ReadAllText(actionsSettingsFilePath);
            //var actionsJson = File.ReadAllText("..\\..\\..\\GameSettings\\actions-settings.json");

            return JsonConvert.DeserializeObject<ActionsSequencesSettings>(actionsJson);
        }
    }
}
