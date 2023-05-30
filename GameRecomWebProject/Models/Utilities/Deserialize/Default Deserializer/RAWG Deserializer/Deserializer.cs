using GameRecomWebProject.Controllers.Helpers;
using GameRecomWebProject.Models.Entities.Concrete;
using GameRecomWebProject.Models.Utilities.Deserialize;
using System.Text.Json;

namespace GameRecomWebProject.Controllers.Helpers.Deserialize.Default_Deserializer.RAWG_Deserializer
{
    public class Deserializer:IDeserializer
    {
        public AppList Deserialize(string mainQuery = "games", Dictionary<string, string> filters = null)
        {
            var json = JsonGetter.GetJson(mainQuery, filters);

            var apps = JsonSerializer.Deserialize<AppList>(json);


            //game detail by slug API'sinden descriptionu deserialize eder
            for (int i = 0; i < apps.results.Count; i++)
            {
                var targetApp = apps.results[i];
                mainQuery = "games/" + targetApp.slug;
                json = JsonGetter.GetJson(mainQuery, filters);
                targetApp = JsonSerializer.Deserialize<App>(json);
                apps.results[i].description_raw = targetApp.description_raw;
            }

            return apps;
        }
    }
}


