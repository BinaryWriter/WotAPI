using Newtonsoft.Json;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Tankopedia.Tanks
{
    public class TankCharacteristic : IResponse<TankCharacteristic.TankData>
    {
        public partial class TankData
        {
            [JsonProperty("search")]
            public TankInfo.TankProfile Characteristic;
        }
    }
}
