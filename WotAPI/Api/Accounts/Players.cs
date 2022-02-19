using Newtonsoft.Json;

namespace WotAPI.Api.Accounts
{
    [Response("https://api.worldoftanks.ru/wot/account/list/?search={search}")]
    public class Players : ResponseClass<Players.Player[]>
    {
        public partial class Player
        {
            [JsonProperty("nickname")]
            public string Nickname;
            [JsonProperty("account_id")]
            public long AccountID;
        }
    }
}
