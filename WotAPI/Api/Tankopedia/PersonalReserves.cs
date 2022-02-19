using Newtonsoft.Json;
using System.Collections.Generic;

namespace WotAPI.Api.Tankopedia
{
    [Response("https://api.worldoftanks.ru/wot/encyclopedia/boosters/")]
    public class PersonalReserves : ResponseClass<Dictionary<string, PersonalReserves.Reserve>>
    {
        public partial class Reserve
        {
            /// <summary> RU: Ресурс, на который влияет личный резерв. Допустимые значения: credits, experience, crew_experience, free_experience <para> EN: Resource affected by Personal Reserve. Valid values: credits, experience, crew_experience, free_experience </para></summary>
            [JsonProperty("resource")]
            public string Resource;
            /// <summary> RU: Название личного резерва <para> EN: Personal Reserve name </para></summary>
            [JsonProperty("name")]
            public string Name;
            /// <summary> RU: Стоимость в золоте <para> EN: Price in gold </para></summary>
            [JsonProperty("price_gold")]
            public int PriceGold;
            /// <summary> RU: Время окончания действия личного резерва в формате UTC <para> EN: Personal Reserve expiration time in UTC </para></summary>
            [JsonProperty("expires_at")]
            public long ExpiresAt;
            /// <summary> RU: Флаг автоматической активации личного резерва <para> EN: Personal Reserve auto activation flag </para></summary>
            [JsonProperty("is_auto")]
            public bool IsAuto;
            /// <summary> RU: Время действия личного резерва <para> EN: Personal Reserve duration in seconds </para></summary>
            [JsonProperty("lifetime")]
            public int Lifetime;
            /// <summary> RU: Стоимость в кредитах <para> EN: Cost in credits </para></summary>
            [JsonProperty("price_credit")]
            public int PriceCredit;
            /// <summary> RU: Изображения личного резерва <para> EN: Personal Reserve image </para></summary>
            [JsonProperty("images")]
            public ReserveImages Images;
            /// <summary> RU: Идентификатор личного резерва <para> EN: Personal Reserve ID </para></summary>
            [JsonProperty("booster_id")]
            public int BoosterID;
            /// <summary> RU: Описание личного резерва <para> EN: Personal Reserve description </para></summary>
            [JsonProperty("description")]
            public string Description;
        }

        public partial class ReserveImages
        {
            /// <summary> RU: URL к большому изображению <para> EN: URL to large image </para></summary>
            [JsonProperty("large")]
            public string Large;
            /// <summary> RU: URL к малому изображению <para> EN: URL to small image </para></summary>
            [JsonProperty("small")]
            public string Small;
        }
    }
}
