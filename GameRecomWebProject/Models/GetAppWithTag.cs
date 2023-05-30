using GameRecomWebProject.Controllers.Helpers.Deserialize.Default_Deserializer.RAWG_Deserializer;
using GameRecomWebProject.Models.Entities.Concrete;
using static NuGet.Packaging.PackagingConstants;

namespace GameRecomWebProject.Models
{
    public static class GetAppWithTag
    {
        public static AppList GetApp(string filter)
        {
            Deserializer des = new Deserializer();

            var filterDict = new Dictionary<string, string>()
            {
                {"key", "c89e2e7c4e54489584f42d66b603ed05"},
                {"page_size","7" },
                {"page","1" }
            };


            if (filter.Equals("ageRestriction"))
            {
                filterDict.Add("tags", "-nudity,-gore,-mature,-sexual-content,family-friendly");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("medieval"))
            {
                filterDict.Add("tags", "medieval,retro");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("futuristic"))
            {
                filterDict.Add("tags", "futuristic,cyberpunk");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("team"))
            {
                filterDict.Add("tags", "team-based,co-op,cooperative");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("singleplayer"))
            {
                filterDict.Add("tags", "singleplayer");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("relaxing"))
            {
                filterDict.Add("tags", "relaxing");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("rpg"))
            {
                filterDict.Add("tags", "rpg,role-playing,-jrpg");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("competitive"))
            {
                filterDict.Add("tags", "competitive");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("survival"))
            {
                filterDict.Add("tags", "survival");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("management"))
            {
                filterDict.Add("tags", "management");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("music"))
            {
                filterDict.Add("tags", "great-soundtrack,music");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("story"))
            {
                filterDict.Add("tags", "story-rich,choices-matter,story");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("vn"))
            {
                filterDict.Add("tags", "visual-novel");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("horror"))
            {
                filterDict.Add("tags", "horror,survival-horror,dark");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("-horror"))
            {
                filterDict.Add("tags", "-horror");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("difficult"))
            {
                filterDict.Add("tags", "difficult");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("-difficult"))
            {
                filterDict.Add("tags", "-difficult");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("exploration"))
            {
                filterDict.Add("tags", "exploration");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("combat"))
            {
                filterDict.Add("tags", "violent,combat");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("-combat"))
            {
                filterDict.Add("tags", "-violent,-combat");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("space"))
            {
                filterDict.Add("tags", "space");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("short"))
            {
                filterDict.Add("tags", "short,fast-paced");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("mystery"))
            {
                filterDict.Add("tags", "mystery,detective");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("historical"))
            {
                filterDict.Add("tags", "historical");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("colorful"))
            {
                filterDict.Add("tags", "colorful");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("-colorful"))
            {
                filterDict.Add("tags", "-colorful");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("tactical"))
            {
                filterDict.Add("tags", "tactical,rts,turn-based-strategy");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("military"))
            {
                filterDict.Add("tags", "military,war");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("-military"))
            {
                filterDict.Add("tags", "-military");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("building"))
            {
                filterDict.Add("tags", "building");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("magic"))
            {
                filterDict.Add("tags", "magic");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("realistic"))
            {
                filterDict.Add("tags", "realistic");
                return (des.Deserialize(filters: filterDict));
            }
            else if (filter.Equals("driving"))
            {
                filterDict.Add("tags", "driving");
                return (des.Deserialize(filters: filterDict));
            }
            else
                return des.Deserialize();




        }
        

    }
}
