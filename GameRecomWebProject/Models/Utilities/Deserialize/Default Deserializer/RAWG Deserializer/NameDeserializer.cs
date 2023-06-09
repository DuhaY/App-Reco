﻿using GameRecomWebProject.Controllers.Helpers;
using GameRecomWebProject.Models.Entities.Concrete;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using GameRecomWebProject.Models.BusinessLogic.Constants;

namespace GameRecomWebProject.Models.Utilities.Deserialize.Default_Deserializer.RAWG_Deserializer
{
    public static class NameDeserializer
    {
        public static List<AppName> DeserializeNameAndSlug(int page=1)
        {
            var NameList = new List<AppName>();

            for (; page < 3; page++)
            {
                var filter = new Dictionary<string, string>()
                {
                    {"key", Config.apiKey },
                    {"page_size","40" },
                    {"page",page.ToString() }
                };

                var json = JsonGetter.GetJson("games", filter);

                var tempList = JsonSerializer.Deserialize<AppNameList>(json);

                foreach (AppName name in tempList.results)
                {
                    NameList.Add(name);
                }

            }

            return NameList;

        }

        public static List<string> GetAllNames()
        {
            var list = new List<string>();

            foreach (AppName app in DeserializeNameAndSlug())
            {
                list.Add(app.name);
            }

            return list;
        }

    }
}
