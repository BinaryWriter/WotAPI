using Newtonsoft.Json;

namespace WotAPI.Api.GlobalMap.Clan;

[Response("https://{region_site}/wot/globalmap/claninfo/?clan_id={search}", true)]
public class Info : ResponseClass<Info.Data>
{
	public class Data
	{
		[JsonProperty("search")] public Details? Info;
	}

	public class Details
	{
		/// <summary>
		///     RU: Идентификатор клана
		///     <para> EN: Clan ID </para>
		/// </summary>
		[JsonProperty("clan_id")] public int? ClanId;

		/// <summary>
		///     RU: Название клана
		///     <para> EN: Clan name </para>
		/// </summary>
		[JsonProperty("name")] public string? Name;

		/// <summary>
		///     RU: Рейтинг клана на Глобальной карте
		///     <para> EN: Clan rating on the Global Map </para>
		/// </summary>
		[JsonProperty("ratings")] public Ratings? Ratings;

		/// <summary>
		///     RU: Статистика клана на Глобальной карте
		///     <para> EN: Clan statistics on the Global Map </para>
		/// </summary>
		[JsonProperty("statistics")] public Statistics? Statistics;

		/// <summary>
		///     RU: Тег клана
		///     <para> EN: Clan tag </para>
		/// </summary>
		[JsonProperty("tag")] public string? Tag;
	}

	public class Ratings
	{
		/// <summary>
		///     RU: Рейтинг Эло клана в абсолютном дивизионе
		///     <para> EN: Clan Elo rating in Absolute division </para>
		/// </summary>
		[JsonProperty("elo_10")] public int? Elo10;

		/// <summary>
		///     RU: Рейтинг Эло клана в среднем дивизионе
		///     <para> EN: Clan Elo rating in Medium division </para>
		/// </summary>
		[JsonProperty("elo_6")] public int? Elo6;

		/// <summary>
		///     RU: Рейтинг Эло клана в чемпионском дивизионе
		///     <para> EN: Clan Elo rating in Champion division </para>
		/// </summary>
		[JsonProperty("elo_8")] public int? Elo8;

		/// <summary>
		///     RU: Время обновления рейтингов
		///     <para> EN: Ratings update time </para>
		/// </summary>
		[JsonProperty("updated_at")] public long? UpdatedAt;
	}

	public class Statistics
	{
		/// <summary>
		///     RU: Количество боёв
		///     <para> EN: Battles fought </para>
		/// </summary>
		[JsonProperty("battles")] public int? Battles;

		/// <summary>
		///     RU: Количество боёв в Абсолютном дивизионе
		///     <para> EN: Battles fought in Absolute division </para>
		/// </summary>
		[JsonProperty("battles_10_level")] public int? Battles10Level;

		/// <summary>
		///     RU: Количество боёв Среднем дивизионе
		///     <para> EN: Battles fought in Medium division </para>
		/// </summary>
		[JsonProperty("battles_6_level")] public int? Battles6Level;

		/// <summary>
		///     RU: Количество боёв Чемпионском дивизионе
		///     <para> EN: Battles fought in Champion division </para>
		/// </summary>
		[JsonProperty("battles_8_level")] public int? Battles8Level;

		/// <summary>
		///     RU: Общее количество провинций, захваченных кланом
		///     <para> EN: Total number by provinces captured by clan </para>
		/// </summary>
		[JsonProperty("captures")] public int? Captures;

		/// <summary>
		///     RU: Количество поражений
		///     <para> EN: Defeats </para>
		/// </summary>
		[JsonProperty("losses")] public int? Losses;

		/// <summary>
		///     RU: Текущее количество захваченных провинций
		///     <para> EN: Current number of captured provinces </para>
		/// </summary>
		[JsonProperty("provinces_count")] public int? ProvincesCount;

		/// <summary>
		///     RU: Количество побед клана
		///     <para> EN: Victories </para>
		/// </summary>
		[JsonProperty("wins")] public int? Wins;

		/// <summary>
		///     RU: Количество побед в Абсолютном дивизионе
		///     <para> EN: Victories in Absolute division </para>
		/// </summary>
		[JsonProperty("wins_10_level")] public int? Wins10Level;

		/// <summary>
		///     RU: Количество побед в Среднем дивизионе
		///     <para> EN: Victories in Medium division </para>
		/// </summary>
		[JsonProperty("wins_6_level")] public int? Wins6Level;

		/// <summary>
		///     RU: Количество побед в Чемпионском дивизионе
		///     <para> EN: Victories in Champion division </para>
		/// </summary>
		[JsonProperty("wins_8_level")] public int? Wins8Level;
	}
}