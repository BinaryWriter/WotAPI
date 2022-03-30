using Newtonsoft.Json;

namespace WotAPI.Api.Tankopedia;

[Response("https://api.worldoftanks.ru/wot/encyclopedia/arenas/")]
public class Maps : ResponseClass<Maps.Map>
{
	public class Map
	{
		/// <summary>
		///     RU: Идентификатор карты
		///     <para> EN: Map ID </para>
		/// </summary>
		[JsonProperty("arena_id")] public string? ArenaId;

		/// <summary>
		///     RU: Тип карты
		///     <para> EN: Map type </para>
		/// </summary>
		[JsonProperty("camouflage_type")] public string? CamouflageType;

		/// <summary>
		///     RU: Краткое описание карты
		///     <para> EN: Short map description </para>
		/// </summary>
		[JsonProperty("description")] public string? Description;

		/// <summary>
		///     RU: Локализованное название карты
		///     <para> EN: Localized map name </para>
		/// </summary>
		[JsonProperty("name_i18n")] public string? LocalizatedName;
	}
}