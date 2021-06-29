using Newtonsoft.Json;
using System.Collections.Generic;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Tankopedia
{
    public class Provision : IResponse<Dictionary<string, Provision.ProvisionData>>
    {
        public partial class ProvisionData
        {
            /// <summary> RU: Название снаряжения или оборудования <para> EN: Consumables or equipment name </para></summary>
            [JsonProperty("name")]
            public string Name;
            /// <summary> RU: Стоимость в золоте <para> EN: Cost in gold </para></summary>
            [JsonProperty("price_gold")]
            public int PriceGold;
            /// <summary> RU: Ссылка на изображение <para> EN: Image link </para></summary>
            [JsonProperty("image")]
            public string Image;
            /// <summary> RU: Техническое название  <para> EN: Technical name </para></summary>
            [JsonProperty("tag")]
            public string Tag;
            /// <summary> RU: Масса в килограммах. Только для оборудования <para> EN: Weight in kilos. Used for equipment only.  </para></summary>
            [JsonProperty("weight")]
            public int Weight;
            /// <summary> RU: Идентификатор оборудования или снаряжения <para> EN: Equipment or consumables ID  </para></summary>
            [JsonProperty("provision_id")]
            public int ProvisionID;
            /// <summary> RU: Стоимость в кредитах <para> EN: Cost in credits </para></summary>
            [JsonProperty("price_credit")]
            public int PriceCredit;
            /// <summary> RU: Тип: снаряжение или оборудование <para> EN: Type: consumable or equipment </para></summary>
            [JsonProperty("type")]
            public string Type;
            /// <summary> RU: Описание снаряжения или оборудования <para> EN: Consumables or equipment description </para></summary>
            [JsonProperty("description")]
            public string Description;
        }
    }
}
