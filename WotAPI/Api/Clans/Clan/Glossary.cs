using Newtonsoft.Json;
using System.Collections.Generic;

namespace WotAPI.Api.Clans.Clan
{
    [Response("https://api.worldoftanks.ru/wot/clans/glossary/")]
    public class Glossary : ResponseClass<Glossary.Data>
    {
        public partial class Data
        {
            /// <summary> RU: Возможные должности игроков в клане <para> EN: Available clan positions </para> </summary>
            [JsonProperty("clans_roles")]
            public Dictionary<string, string> Roles = new Dictionary<string, string>();
        }
    }
}
