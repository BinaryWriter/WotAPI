using Newtonsoft.Json;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Api.Response
{
    public class IResponse<T>
    {
        [JsonProperty("status")]
        public string Status;
        [JsonProperty("meta")]
        public Meta Meta;
        [JsonProperty("data")]
        public T Data;
    }
    public class Meta
    {
        [JsonProperty("count")]
        public int Count;
        [JsonProperty("total")]
        public int Total;
    }
}
