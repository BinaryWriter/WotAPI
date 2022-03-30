using Newtonsoft.Json;

namespace WotAPI.Api.Accounts;

[Response("https://api.worldoftanks.ru/wot/account/list/?search={search}")]
public class Players : ResponseClass<Players.Player[]>
{
	public class Player
	{
		[JsonProperty("account_id")] public long? AccountId;

		[JsonProperty("nickname")] public string? Nickname;
	}
}