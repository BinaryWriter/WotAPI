using Newtonsoft.Json;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Tankopedia.Tanks
{
    public class TankProfiles : IResponse<TankProfiles.Profile[]>
    {
        public partial class Profile
        {
            /// <summary> RU: Базовая комплектация <para> EN: Standard configuration </para></summary>
            [JsonProperty("is_default")]
            public bool IsDefault;
            /// <summary> RU: Идентификатор комплектации техники <para> EN: Vehicle Configuration ID </para></summary>
            [JsonProperty("profile_id")]
            public string ProfileID;
            /// <summary> RU: Стоимость в кредитах <para> EN: Cost in credits </para></summary>
            [JsonProperty("price_credit")]
            public int PriceCredit;
            /// <summary> RU: Идентификатор комплектации техники <para> EN: Vehicle ID </para></summary>
            [JsonProperty("tank_id")]
            public int TankID;
        }
    }
}
