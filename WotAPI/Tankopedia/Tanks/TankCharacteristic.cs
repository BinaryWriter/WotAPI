using Newtonsoft.Json;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Tankopedia.Tanks
{
    public class TankCharacteristic : IResponse<TankCharacteristic.TankCharacteristicData>
    {
        public partial class TankCharacteristicData
        {
            [JsonProperty("search")]
            public TankInfo.TankProfile Characteristic;
        }
    }
}
