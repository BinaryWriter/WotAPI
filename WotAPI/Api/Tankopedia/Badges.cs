using Newtonsoft.Json;
using System.Collections.Generic;

namespace WotAPI.Api.Tankopedia
{
    [Response("https://api.worldoftanks.ru/wot/encyclopedia/badges/")]
    public class Badges : ResponseClass<Dictionary<string, Badges.Badge>>
    {
        public partial class Badge
        {
            /// <summary> RU: Название нашивки <para> EN: Badge name </para></summary>
            [JsonProperty("name")]
            public string Name;
            /// <summary> RU: Описание нашивки <para> EN: Badge description </para></summary>
            [JsonProperty("description")]
            public string Description;
            /// <summary> RU: Идентификатор нашивки <para> EN: Badge ID </para></summary>
            [JsonProperty("badge_id")]
            public int BadgeID;
            /// <summary> RU: Ссылки на изображения <para> EN: Image links </para></summary>
            [JsonProperty("images")]
            public BadgeImages Images;
        }

        public partial class BadgeImages
        {
            /// <summary> RU: URL изображения нашивки размером 80x80 px <para> EN: URL to 80x80 px badge image </para></summary>
            [JsonProperty("big_icon")]
            public string BigIcon;
            /// <summary> RU: URL изображения нашивки размером 48x48 px <para> EN: URL to 48x48 px badge image </para></summary>
            [JsonProperty("medium_icon")]
            public string MediumIcon;
            /// <summary> RU: URL изображения нашивки размером 24x24 px <para> EN: URL to 24x24 px badge image </para></summary>
            [JsonProperty("small_icon")]
            public string SmallIcon;
        }
    }
}
