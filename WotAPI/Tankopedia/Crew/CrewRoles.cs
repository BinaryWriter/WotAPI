using Newtonsoft.Json;
using System.Collections.Generic;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Tankopedia.Crew
{
    public class CrewRoles : IResponse<Dictionary<string, CrewRoles.CrewMember>>
    {
        public partial class CrewMember
        {
            /// <summary> RU: Список специальностей членов экипажа <para> EN: List of crew member qualifications </para></summary>
            [JsonProperty("skills")]
            public string[] Skills;
            /// <summary> RU: Идентификатор специальности экипажа <para> EN: Сrew qualification ID </para></summary>
            [JsonProperty("role")]
            public string Role;
            /// <summary> RU: Название специальности экипажа <para> EN: Сrew qualification name </para></summary>
            [JsonProperty("name")]
            public string Name;
        }
    }
}
