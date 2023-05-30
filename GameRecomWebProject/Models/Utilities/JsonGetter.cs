using GameRecomWebProject.Models;
using System.Net;

namespace GameRecomWebProject.Controllers.Helpers
{
    public static class JsonGetter
    {
        //Dictionary tipinde filtreleri rawg database'e iletiyoruz, return olarak json formatında string alıyoruz.
        public static string GetJson(string url,Dictionary<string,string>? filters)
        {
            var ApiKey = "c89e2e7c4e54489584f42d66b603ed05";

            using (var wc = new WebClient() )
            {
                //İstek adresi RAWG DB sitesine atıyoruz.
                wc.BaseAddress = StaticVariables.EndPoint;

                if (filters != null)
                {
                    foreach (KeyValuePair<string, string> filter in filters)
                    {
                        wc.QueryString.Add(filter.Key, filter.Value);
                    }
                }
                else
                    wc.QueryString.Add("key", ApiKey);

                var json = wc.DownloadString(url);
                return json;
            }
        }
    }
}
