using Newtonsoft.Json;
using System.Collections.Generic;

namespace WotAPI.Api.Accounts.Player
{
    [Response("https://api.worldoftanks.ru/wot/account/achievements/?account_id={search}", true)]
    public class Achievements : ResponseClass<Achievements.Data>
    {
        public partial class Data
        {
            [JsonProperty("search")]
            public Dictionaries Achievements { get; set; }
        }

        public partial class Dictionaries
        {
            /// <summary> RU: Заработанные достижения <para> EN: Achievements earned </para> </summary>
            [JsonProperty("achivements")]
            public Dictionary<string, int> Achievements = new Dictionary<string, int>();
            /// <summary> RU: Прогресс достижений <para> EN: Achievement progress </para> </summary>
            [JsonProperty("frags")]
            public Dictionary<string, int> Frags = new Dictionary<string, int>();
            /// <summary> RU: Максимальные значения серийных достижений <para> EN: Maximum values of achievement series </para> </summary>
            [JsonProperty("max_series")]
            public Dictionary<string, int> MaxSeries = new Dictionary<string, int>();
        }
    }
}
