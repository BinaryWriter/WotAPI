using Newtonsoft.Json;
using System.Collections.Generic;

namespace WotAPI.Api.Tankopedia.Crew
{
    [Response("https://api.worldoftanks.ru/wot/encyclopedia/crewroles/")]
    public class Roles : ResponseClass<Dictionary<string, Roles.CrewMember>>
    {
        public class CrewMember
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
