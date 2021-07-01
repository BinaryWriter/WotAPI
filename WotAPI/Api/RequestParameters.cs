using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Text;
using WotAPI.Accounts;
using WotAPI.Clans;
using WotAPI.GlobalMap;
using WotAPI.Strongholds;
using WotAPI.Tankopedia;
using WotAPI.Tankopedia.Tanks;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Api
{
    public class RequestParameters<T>
    {
        public static string WotApiURL;

        public string url;
        public string search;

        /// <summary>
        /// RU: Вы можете не указывать:
        /// <para> - <paramref name="search"/> если ваш метод не производит поиска чего-либо</para>
        /// <para> - <paramref name="page"/> если вам нужна первая страница ответа </para>
        /// <para> - <paramref name="parameters"/> если вам не нужны дополнительные параметры </para>
        /// <para> EN: You don't need to specify: </para>
        /// <para> - <paramref name= "search"/> if your method doesn't search for something </para>
        /// <para> - <paramref name= "page"/> if you need the first page of response </para>
        /// <para> - <paramref name="parameters"/> if you don't need additional parameters </para>
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="api"></param>
        /// <param name="search"></param>
        /// <param name="page"></param>
        public RequestParameters(WotApi api, object search = null, int page = 1, Dictionary<string, object> parameters = null)
        {
            WotApiURL = "https://api.worldoftanks." + api.region + "/wot";
            this.search = search.ToString();

            System.Type type = typeof(T);
            if (type == typeof(PlayersList))
            {
                url = WotApiURL + "/account/list/?application_id=" + api.app_ID + "&search=" + this.search;
            }
            else if (type == typeof(PlayerVehicles))
            {
                url = WotApiURL + "/account/tanks/?application_id=" + api.app_ID + "&account_id=" + this.search + "&page_no=" + page;
            }
            else if (type == typeof(PlayerAchievements))
            {
                url = WotApiURL + "/account/achievements/?application_id=" + api.app_ID + "&account_id=" + this.search + "&page_no=" + page;
            }
            else if (type == typeof(PlayerDetails))
            {
                url = WotApiURL + "/account/info/?application_id=" + api.app_ID + "&account_id=" + this.search + "&extra=statistics.globalmap_absolute%2C+statistics.globalmap_champion%2C+statistics.globalmap_middle%2C+statistics.random";
            }
            else if (type == typeof(ClansList))
            {
                url = WotApiURL + "/clans/list/?application_id=" + api.app_ID;
                if (search != null)
                {
                    url += "&search=" + this.search;
                }
            }
            else if (type == typeof(ClanDetails))
            {
                url = WotApiURL + "/clans/info/?application_id=" + api.app_ID + "&clan_id=" + this.search;
            }
            else if (type == typeof(ClanGlossary))
            {
                url = WotApiURL + "/clans/glossary/?application_id=" + api.app_ID;
            }
            else if (type == typeof(ClanHistory))
            {
                url = WotApiURL + "/clans/memberhistory/?application_id=" + api.app_ID + "&account_id" + this.search;
            }
            else if (type == typeof(TankInfo))
            {
                url = WotApiURL + "/encyclopedia/vehicles/?application_id=" + api.app_ID + "&tank_id=" + this.search; ;
            }
            else if (type == typeof(Achievements))
            {
                url = WotApiURL + "/encyclopedia/achievements/?application_id=" + api.app_ID;
            }
            else if (type == typeof(TankopediaInfo))
            {
                url = WotApiURL + "/encyclopedia/info/?application_id=" + api.app_ID;
            }
            else if (type == typeof(Arenas))
            {
                url = WotApiURL + "/encyclopedia/arenas/?application_id=" + api.app_ID;
            }
            else if (type == typeof(Provision))
            {
                url = WotApiURL + "/provisions/?application_id=" + api.app_ID;
                if (search != null)
                {
                    url += "&provision_id=" + this.search;
                }
            }
            else if (type == typeof(TankCharacteristic))
            {
                url = WotApiURL + "/encyclopedia/vehicleprofile/?application_id=" + api.app_ID + "&tank_id=" + this.search;
            }
            else if (type == typeof(Missions))
            {
                url = WotApiURL + "/encyclopedia/personalmissions/?application_id=" + api.app_ID;
            }
            else if (type == typeof(Boosters))
            {
                url = WotApiURL + "/encyclopedia/boosters/?application_id=" + api.app_ID;
            }
            else if (type == typeof(Badges))
            {
                url = WotApiURL + "/encyclopedia/badges/?application_id=" + api.app_ID;
            }
            else if (type == typeof(TankProfiles))
            {
                url = WotApiURL + "/encyclopedia/vehicleprofiles/?application_id=" + api.app_ID;
            }
            else if (type == typeof(StrongholdsClanInfo))
            {
                url = WotApiURL + "/stronghold/claninfo/?application_id=" + api.app_ID + "&clan_id=" + this.search;
            }
            else if (type == typeof(GlobalMapClanInfo))
            {
                url = WotApiURL + "/globalmap/claninfo/?application_id=" + api.app_ID + "&clan_id=" + this.search;
            }
            else if (type == typeof(GlobalMapInfo))
            {
                url = WotApiURL + "/globalmap/info/?application_id=" + api.app_ID;
            }else if (type == typeof(Fronts))
            {
                url = WotApiURL + "/globalmap/fronts/?application_id=" + api.app_ID;
                if (search != null)
                {
                    url += "&front_id=" + this.search;
                }
            }
            if (page != 1)
            {
                url += "&page_no=" + page;
            }

            if (parameters != null)
            {
                foreach (var pair in parameters)
                {
                    string a = $"&{pair.Key}={pair.Value.ToString()}";
                    url += a;
                }
            }
        }

        public T Send()
        {
            WebClient client = new WebClient() { Encoding = Encoding.UTF8 };

            string text = client.DownloadString(url).Replace($"\"{search}\":", "\"search\":");
            T json = JsonConvert.DeserializeObject<T>(text, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            dynamic jsonDynamic = (dynamic)json;
            if (jsonDynamic.Status == "error")
            {
                string message = $"[Code: {jsonDynamic.Error.Code} Field: {jsonDynamic.Error.Field}] {jsonDynamic.Error.Message}";
                throw new System.Exception(message);
            }
            return json;
        }
    }
}
