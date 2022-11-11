using Newtonsoft.Json;

namespace WotAPI.Api.Clans.Clan;

[Response("https://{region_site}/wot/clans/glossary/")]
public class Glossary : ResponseClass<Glossary.Data>
{
	public class Data
	{
		/// <summary>
		///     RU: Возможные должности игроков в клане
		///     <para> EN: Available clan positions </para>
		/// </summary>
		[JsonProperty("clans_roles")] public Dictionary<string, string>? Roles = new();
	}
}