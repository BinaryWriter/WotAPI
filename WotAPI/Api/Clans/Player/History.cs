using Newtonsoft.Json;

namespace WotAPI.Api.Clans.Player
{
    [Response("https://api.worldoftanks.ru/wot/clans/memberhistory/?account_id={search}", true)]
    public class History : ResponseClass<History.Data>
    {
        public partial class Data
        {
            [JsonProperty("search")]
            public MemberHistory[] History;
        }

        public partial class MemberHistory
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
