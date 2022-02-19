using Newtonsoft.Json;
using System.Collections.Generic;

namespace WotAPI.Api.Clans
{
    [Response("https://api.worldoftanks.ru/wot/clans/list/?search={search}")]
    public class Clans : ResponseClass<Clans.Clan[]>
    {
        public partial class Clan
        {
            /// <summary> RU: Количество игроков клана <para> EN: Number of clan members </para> </summary>
            [JsonProperty("members_count")]
            public int MembersCount;
            /// <summary> RU: Название клана <para> EN: Clan name </para> </summary>
            [JsonProperty("name")]
            public string Name;
            /// <summary> RU: Цвет клана в формате HEX #RRGGBB <para> EN: Clan color in HEX #RRGGBB </para> </summary>
            [JsonProperty("color")]
            public string Color;
            /// <summary> RU: Дата создания клана <para> EN: Clan creation date </para> </summary>
            [JsonProperty("created_at")]
            public long CreatedAt;
            /// <summary> RU: Тег клана <para> EN: Clan tag </para> </summary>
            [JsonProperty("tag")]
            public string Tag;
            /// <summary> RU: Информация об эмблемах клана в играх и на клановом портале <para> EN: Information on clan emblems in games and on clan portal </para> </summary>
            [JsonProperty("emblems")]
            public Dictionary<string, Dictionary<string, string>> Emblems = new Dictionary<string, Dictionary<string, string>>();
            /// <summary> RU: Идентификатор клана <para> EN: Clan ID </para> </summary>
            [JsonProperty("clan_id")]
            public long ClanID;
        }

        public partial class ClanMember
        {
            /// <summary> RU: Техническое название должности <para> EN: Technical position name </para> </summary>
            [JsonProperty("role")]
            public string Role;
            /// <summary> RU: Позиция <para> EN: Position  </para> </summary>
            [JsonProperty("role_i18n")]
            public string RoleI18n;
            /// <summary> RU: Дата вступления в клан <para> EN: Date when player joined clan  </para> </summary>
            [JsonProperty("joined_at")]
            public long JoinedAt;
            /// <summary> RU: Идентификатор аккаунта игрока <para> EN: Player account ID  </para> </summary>
            [JsonProperty("account_id")]
            public long AccountID;
            /// <summary> RU: Имя игрока <para> EN: Player name </para> </summary>
            [JsonProperty("account_name")]
            public string AccountName;
        }
    }
}
