using Newtonsoft.Json;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Api.Response
{
    public class IResponse<T>
    {
        public string JsonCode;

        [JsonProperty("status")]
        public string Status;
        [JsonProperty("meta")]
        public Meta Meta;
        [JsonProperty("data")]
        public T Data;
        [JsonProperty("error")]
        public Error Error;
    }
    public class Meta
    {
        [JsonProperty("count")]
        public int Count;
        [JsonProperty("total")]
        public int Total;
    }

    public class Error
    {
        [JsonProperty("field")]
        public string Field;
        [JsonProperty("message")]
        public string Message;
        [JsonProperty("code")]
        public int Code;
    }
}
