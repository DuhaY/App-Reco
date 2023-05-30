using GameRecomWebProject.Models.Entities.Concrete;

namespace GameRecomWebProject.Models.Utilities.Deserialize
{
    public interface IDeserializer
    {
        AppList Deserialize(string mainQuery = "games", Dictionary<string,string> filters = null);
    }
}
