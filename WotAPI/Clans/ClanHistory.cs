using Newtonsoft.Json;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Clans
{
    public class ClanHistory : IResponse<ClanHistory.ClanHistoryData>
    {
        public partial class ClanHistoryData
        {
            [JsonProperty("search")]
            public History[] History;
        }
        public partial class History
        {
            /// <summary> RU: Последняя должность в клане <para> EN: Last position in clan </para> </summary>
            [JsonProperty("role")]
            public string Role;
            /// <summary> RU: Дата выхода из клана <para> EN: Date when player left clan </para> </summary>
            [JsonProperty("left_at")]
            public long LeftAt;
            /// <summary> RU: Идентификатор клана <para> EN: Clan ID </para> </summary>
            [JsonProperty("clan_id")]
            public long ClanID;
            /// <summary> RU: Дата вступления в клан <para> EN: Date when player joined clan </para> </summary>
            [JsonProperty("joined_at")]
            public long JoinedAt;
            /// <summary> RU: Идентификатор аккаунта игрока <para> EN: Player account ID </para> </summary>
            [JsonProperty("account_id")]
            public long AccountID;
        }
    }
}
