using GameRecomWebProject.Models.Entities.Abstract;

namespace GameRecomWebProject.Models.Entities.Concrete
{
    public class App:IApp
    {
        public string name { get; set; }

        //can be used as id
        public string slug { get; set; }

        public List<Tag> tags { get; set; }

        public List<Genre> genres { get; set; }

        public List<StoreList> stores { get; set; }

        public List<PlatformList> platforms { get; set; }

        public string description_raw { get; set; }

        public string released { get; set; }

        //url to screenshots
        public List<Screenshots> short_screenshots { get; set; }

    }
}
