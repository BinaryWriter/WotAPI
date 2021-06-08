using Newtonsoft.Json;
using System.Collections.Generic;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Clans
{
    public class ClanGlossary : IResponse<ClanGlossary.ClanGlossaryData>
    {
        public partial class ClanGlossaryData
        {
            /// <summary> RU: Возможные должности игроков в клане <para> EN: Available clan positions </para> </summary>
            [JsonProperty("clans_roles")]
            public Dictionary<string, string> Roles = new Dictionary<string, string>();
        }
    }
}
