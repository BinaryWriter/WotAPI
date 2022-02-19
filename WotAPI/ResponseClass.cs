using Newtonsoft.Json;

namespace WotAPI
{
    public class ResponseClass<T>
    {
        [JsonProperty("status")]
        public string Status;
        [JsonProperty("meta")]
        public Meta Meta;
        [JsonProperty("data")]
        public T Result;
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
