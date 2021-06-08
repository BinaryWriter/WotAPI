using Newtonsoft.Json;
using System.Collections.Generic;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Tankopedia.Crew
{
    public class CrewSkills : IResponse<Dictionary<string, CrewSkills.CrewSkill>>
    {
        public partial class CrewSkill
        {
            /// <summary> RU: Название умения <para> EN: Skill name </para></summary>
            [JsonProperty("name")]
            public string Name;
            /// <summary> RU: Описание умения <para> EN: Skill description </para></summary>
            [JsonProperty("description")]
            public string Description;
            /// <summary> RU: Идентификатор умения <para> EN: Skill ID </para></summary>
            [JsonProperty("skill")]
            public string Skill;
            /// <summary> RU: Показывает, является ли навыком <para> EN: Indicates if it is a perk </para></summary>
            [JsonProperty("is_perk")]
            public bool IsPerk;
            /// <summary> RU: URL к значку умения <para> EN: URL to skill icon </para></summary>
            [JsonProperty("image_url")]
            public CrewSkillImages Images;

            public partial class CrewSkillImages
            {
                /// <summary> RU: URL к большому изображению <para> EN: URL to large image </para></summary>
                [JsonProperty("big_icon")]
                public string BigIcon;
                /// <summary> RU: URL к малому изображению <para> EN: URL to small image </para></summary>
                [JsonProperty("small_icon")]
                public string SmallIcon;
            }
        }
    }
}
