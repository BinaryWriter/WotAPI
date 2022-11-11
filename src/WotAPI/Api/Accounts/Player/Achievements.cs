using Newtonsoft.Json;

namespace WotAPI.Api.Accounts.Player;

[Response("https://{region_site}/wot/account/achievements/?account_id={search}", true)]
public class Achievements : ResponseClass<Achievements.Data>
{
	public class Data
	{
		[JsonProperty("search")] public Dictionaries? Achievements { get; set; }
	}

	public class Dictionaries
	{
		/// <summary>
		///     RU: Заработанные достижения
		///     <para> EN: Achievements earned </para>
		/// </summary>
		[JsonProperty("achievements")] public Dictionary<string, int>? Achievements = new();

		/// <summary>
		///     RU: Прогресс достижений
		///     <para> EN: Achievement progress </para>
		/// </summary>
		[JsonProperty("frags")] public Dictionary<string, int>? Frags = new();

		/// <summary>
		///     RU: Максимальные значения серийных достижений
		///     <para> EN: Maximum values of achievement series </para>
		/// </summary>
		[JsonProperty("max_series")] public Dictionary<string, int>? MaxSeries = new();
	}
}