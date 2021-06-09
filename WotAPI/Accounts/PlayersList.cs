using Newtonsoft.Json;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Accounts
{
    public class PlayersList : IResponse<PlayersList.Player[]>
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
