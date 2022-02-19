using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Text.RegularExpressions;

namespace WotAPI
{
    public class WotApi
    {
        public string ApplicationID;
        public string Region;

        private HttpClient HttpClient = new HttpClient();

        public WotApi(string ApplicationID, WotApiRegion Region)
        {
            this.ApplicationID = ApplicationID;
            this.Region = Region.ToString().ToLower();
        }

        public T Get<T>(object Search = null, int PageNumber = 1, Dictionary<string, object> Parameters = null)
        {
            foreach(var Type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (typeof(T).IsAssignableFrom(Type))
                {
                    if (Type.GetCustomAttribute<ResponseAttribute>() != null)
                    {
                        var Attribute = Type.GetCustomAttribute<ResponseAttribute>();
                        var URL = Attribute.URLOfRequest;

                        if (URL.EndsWith("/"))
                            URL += $"?application_id={ApplicationID}";
                        else
                            URL += $"&application_id={ApplicationID}";

                        URL += $"&page_no={PageNumber}";

                        if (Parameters != null)
                            foreach (var Parameter in Parameters)
                                URL += $"&{Parameter.Key}={Parameter.Value}";

                        if (Search != null)
                        {
                            URL = URL.Replace("{search}", Search.ToString());
                        }
                        else
                        {
                            var Match1 = new Regex("\\?(.*?)={search}").Match(URL);
                            var Match2 = new Regex("&(.*?)={search}").Match(URL);

                            if (Match1.Success)
                                URL = URL.Replace(Match1.Value, "");
                            if (Match2.Success)
                                URL = URL.Replace(Match2.Value, "");
                        }

                        var Result = HttpClient.GetStringAsync(URL).Result;

                        if (Attribute.ReplaceSearch == true)
                            Result = Result.Replace($"\"{Search}\"", "\"search\"");

                        Console.WriteLine(Result);

                        T Response = JsonConvert.DeserializeObject<T>(Result, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

                        return Response;
                    }
                }
            }
            return default;
        }

        public enum WotApiRegion
        {
            RU,
            EU,
            COM,
            ASIA
        }
    }
}
