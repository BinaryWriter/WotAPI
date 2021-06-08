using Newtonsoft.Json;
using System.Collections.Generic;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Clans.General
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
        /// <summary> RU: Информация об эмблемах клана в играх и на клановом портале <para> EN: </para> </summary>
        [JsonProperty("emblems")]
        public Dictionary<string, Dictionary<string, string>> Emblems = new Dictionary<string, Dictionary<string, string>>();
        /// <summary> RU: Идентификатор клана <para> EN: Clan ID </para> </summary>
        [JsonProperty("clan_id")]
        public long ClanID;
    }
}
