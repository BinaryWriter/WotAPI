using Newtonsoft.Json;
using WotAPI.Api.Response;
using WotAPI.Clans.General;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Clans
{
    public class ClanMemberDetails : IResponse<ClanMemberDetails.ClanMemberData>
    {
        public partial class ClanMemberData
        {
            [JsonProperty("search")]
            public ClanMember Member;
        }
        public partial class ClanMember : WotAPI.Clans.General.ClanMember
        {
            /// <summary> RU: Краткая информация о клане <para> EN: Short clan info </para> </summary>
            [JsonProperty("clan")]
            public Clan Clan;
        }
    }
}
