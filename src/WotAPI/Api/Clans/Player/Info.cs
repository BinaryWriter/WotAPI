using Newtonsoft.Json;

namespace WotAPI.Api.Clans.Player;

[Response("https://{region_site}/wot/clans/accountinfo/?account_id={search}", true)]
public class Info : ResponseClass<Info.Data>
{
	public class Data
	{
		[JsonProperty("search")] public Member? Member;
	}

	public class Member : Clans.ClanMember
	{
		/// <summary>
		///     RU: Краткая информация о клане
		///     <para> EN: Short clan info </para>
		/// </summary>
		[JsonProperty("clan")] public Clans.Clan? Clan;
	}
}