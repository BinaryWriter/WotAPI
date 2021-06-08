using System.Collections.Generic;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Api
{
    public class RequestParameters
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
        /// <param name="type"></param>
        /// <param name="api"></param>
        /// <param name="search"></param>
        /// <param name="page"></param>
        public RequestParameters(WotApiMethods type, WotApi api, string search = "", int page = 1, Dictionary<string, string> parameters = null)
        {
            WotApiURL = "https://api.worldoftanks." + api.region + "/wot";
            this.search = search;
            if (type == WotApiMethods.AccountsList)
            {
                url = WotApiURL + "/account/list/?application_id=" + api.app_ID + "&search=" + search;
            }
            else if (type == WotApiMethods.AccountTanks)
            {
                url = WotApiURL + "/account/tanks/?application_id=" + api.app_ID + "&account_id=" + search + "&page_no=" + page;
            }
            else if (type == WotApiMethods.AccountAchievements)
            {
                url = WotApiURL + "/account/achievements/?application_id=" + api.app_ID + "&account_id=" + search + "&page_no=" + page;
            }
            else if (type == WotApiMethods.AccountDetails)
            {
                url = WotApiURL + "/account/info/?application_id=" + api.app_ID + "&account_id=" + search;
            }
            else if (type == WotApiMethods.ClansList)
            {
                url = WotApiURL + "/clans/list/?application_id=" + api.app_ID;
                if (search != "")
                {
                    url += "&search=" + search;
                }
            }
            else if (type == WotApiMethods.ClanDetails)
            {
                url = WotApiURL + "/clans/info/?application_id=" + api.app_ID + "&clan_id=" + search;
            }
            else if (type == WotApiMethods.ClanGlossary)
            {
                url = WotApiURL + "/clans/glossary/?application_id=" + api.app_ID;
            }
            else if (type == WotApiMethods.ClanHistory)
            {
                url = WotApiURL + "/clans/memberhistory/?application_id=" + api.app_ID + "&account_id" + search;
            }
            else if (type == WotApiMethods.TankopediaTankInfo)
            {
                url = WotApiURL + "/encyclopedia/vehicles/?application_id=" + api.app_ID + "&tank_id=" + search; ;
            }
            else if (type == WotApiMethods.TankopediaAchievements)
            {
                url = WotApiURL + "/encyclopedia/achievements/?application_id=" + api.app_ID;
            }
            else if (type == WotApiMethods.TankopediaInfo)
            {
                url = WotApiURL + "/encyclopedia/info/?application_id=" + api.app_ID;
            }
            else if (type == WotApiMethods.TankopediaArenas)
            {
                url = WotApiURL + "/encyclopedia/arenas/?application_id=" + api.app_ID;
            }
            else if (type == WotApiMethods.TankopediaProvision)
            {
                url = WotApiURL + "/provisions/?application_id=" + api.app_ID;
                if (search != "")
                {
                    url += "&provision_id=" + search;
                }
            }
            else if (type == WotApiMethods.TankopediaTankCharacteristic)
            {
                url = WotApiURL + "/encyclopedia/vehicleprofile/?application_id=" + api.app_ID + "&tank_id=" + search;
            }
            else if (type == WotApiMethods.TankopediaMissions)
            {
                url = WotApiURL + "/encyclopedia/personalmissions/?application_id=" + api.app_ID;
            }
            else if (type == WotApiMethods.TankopediaBoosters)
            {
                url = WotApiURL + "/encyclopedia/boosters/?application_id=" + api.app_ID;
            }
            else if (type == WotApiMethods.TankopediaBadges)
            {
                url = WotApiURL + "/encyclopedia/badges/?application_id=" + api.app_ID;
            }
            else if (type == WotApiMethods.TankopediaTankProfiles)
            {
                url = WotApiURL + "/encyclopedia/vehicleprofiles/?application_id=" + api.app_ID;
            }
            else if (type == WotApiMethods.StrongholdsClanInfo)
            {
                url = WotApiURL + "/stronghold/claninfo/?application_id=" + api.app_ID + "&clan_id=" + search;
            }
            if (page != 1)
            {
                url += "&page_no=" + page;
            }

            if (parameters != null)
            {
                foreach (KeyValuePair<string, string> e in parameters)
                {
                    string a = $"&{e.Key}={e.Value}";
                    url += a;
                }
            }
        }
    }
}
