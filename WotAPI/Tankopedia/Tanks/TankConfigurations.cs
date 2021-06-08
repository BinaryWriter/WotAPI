using Newtonsoft.Json;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Tankopedia.Tanks
{
    public class TankConfigurations : IResponse<TankConfigurations.Configuration[]>
    {
        public partial class Configuration
        {
            [JsonProperty("is_default")]
            public bool IsDefault;
            [JsonProperty("profile_id")]
            public string ProfileID;
            [JsonProperty("price_credit")]
            public int PriceCredit;
            [JsonProperty("tank_id")]
            public int TankID;
        }
    }
}
