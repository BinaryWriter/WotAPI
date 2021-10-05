using Newtonsoft.Json;
using System.Collections.Generic;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Accounts
{
    public class PlayerAchievements : IResponse<PlayerAchievements.PlayerAchievementsData>
    {
        public partial class PlayerAchievementsData
        {
            [JsonProperty("search")]
            public AchievementsDictionaries Achievements { get; set; }
        }
        public partial class AchievementsDictionaries
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
