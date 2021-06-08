using Newtonsoft.Json;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Clans.General
{
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
