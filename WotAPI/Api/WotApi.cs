using Newtonsoft.Json;
using System.Net;
using System.Text;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Api
{
    public class WotApi
    {
        public string app_ID;
        public string region;

        public WotApi(string app_ID, WotApiRegion region)
        {
            this.app_ID = app_ID;
            if (region == WotApiRegion.RU)
            {
                this.region = "ru";
            }
            else if (region == WotApiRegion.EU)
            {
                this.region = "eu";
            }
            else if (region == WotApiRegion.NA)
            {
                this.region = "com";
            }
            else if (region == WotApiRegion.ASIA)
            {
                this.region = "asia";
            }
        }
        public T SendRequest<T>(RequestParameters p)
        {
            WebClient client = new WebClient() { Encoding = Encoding.UTF8 };

            string text = client.DownloadString(p.url).Replace($"\"{p.search}\":", "\"search\":");
            T json = JsonConvert.DeserializeObject<T>(text, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            return json;
        }
    }
}
