using Newtonsoft.Json;

namespace WotAPI.Api.Tankopedia;

[Response("https://{region_site}/wot/encyclopedia/achievements/")]
public class Achievements : ResponseClass<Dictionary<string, Achievements.Achievement>>
{
	public class Achievement
	{
		/// <summary>
		///     RU: Условие
		///     <para> EN: Condition </para>
		/// </summary>
		[JsonProperty("condition")] public string? Condition;

		/// <summary>
		///     RU: Описание достижения
		///     <para> EN: Achievement description </para>
		/// </summary>
		[JsonProperty("description")] public string? Description;

		/// <summary>
		///     RU: Историческая справка
		///     <para> EN: Historical reference </para>
		/// </summary>
		[JsonProperty("hero_info")] public string? HeroInfo;

		/// <summary>
		///     RU: Ссылка на изображение
		///     <para> EN: URL to image </para>
		/// </summary>
		[JsonProperty("image")] public string? Image;

		/// <summary>
		///     RU: Изображение 180x180px
		///     <para> EN: 180x180px image </para>
		/// </summary>
		[JsonProperty("image_big")] public string? ImageBig;

		/// <summary>
		///     RU: Локализованное поле name
		///     <para> EN: Localized name field </para>
		/// </summary>
		[JsonProperty("name_i18n")] public string? LocalizatedName;

		/// <summary>
		///     RU: Название достижения
		///     <para> EN: Achievement name </para>
		/// </summary>
		[JsonProperty("name")] public string? Name;

		/// <summary>
		///     RU: Достижения
		///     <para> EN: Service Record </para>
		/// </summary>
		[JsonProperty("options")] public Options? Options;

		/// <summary>
		///     RU: Порядок отображения достижений в разделе. Достижения с меньшим значением поля «Порядок» отображены выше
		///     достижений с большим значением Тип
		///     <para>
		///         EN: Achievement order in this section. Achievements with a lesser value of the Order field are displayed
		///         above achievements with a greater value
		///     </para>
		/// </summary>
		[JsonProperty("order")] public int? Order;

		/// <summary>
		///     RU: Раздел
		///     <para> EN: Section </para>
		/// </summary>
		[JsonProperty("selection")] public string? Selection;

		/// <summary>
		///     RU: Порядок отображения разделов достижений. Разделы с меньшим значением поля «Порядок отображения раздела»
		///     отображены выше разделов с большим значением
		///     <para>
		///         EN: Section order. Sections with a lesser value of the Section order field are displayed above sections with
		///         a greater value
		///     </para>
		/// </summary>
		[JsonProperty("selection_order")] public int? SelectionOrder;

		/// <summary>
		///     RU: Тип
		///     <para> EN: Type </para>
		/// </summary>
		[JsonProperty("type")] public string? Type;
	}

	public class Options
	{
		/// <summary>
		///     RU: Описание достижения
		///     <para> EN: Achievement description </para>
		/// </summary>
		[JsonProperty("description")] public string? Description;

		/// <summary>
		///     RU: Ссылка на изображение
		///     <para> EN: URL to image </para>
		/// </summary>
		[JsonProperty("image")] public string? Image;

		/// <summary>
		///     RU: Изображение 180x180px
		///     <para> EN: 180x180px image </para>
		/// </summary>
		[JsonProperty("image_big")] public string? ImageBig;

		/// <summary>
		///     RU: Локализованное поле name
		///     <para> EN: Localized name field </para>
		/// </summary>
		[JsonProperty("name_i18n")] public string? LocalizatedName;

		/// <summary>
		///     RU: Информация об эмблемах наций
		///     <para> EN: Information about nation emblems </para>
		/// </summary>
		[JsonProperty("nation_images")] public NationImages? NationImages;
	}

	public class NationImages
	{
		/// <summary>
		///     RU: Перечень ссылок на эмблемы 180x180 px
		///     <para> EN: List of links to 180x180 px emblems </para>
		/// </summary>
		[JsonProperty("x180")] public string[]? X180;

		/// <summary>
		///     RU: Перечень ссылок на эмблемы 67x71 px
		///     <para> EN: List of links to 67x71 px emblems </para>
		/// </summary>
		[JsonProperty("x71")] public string[]? X71;

		/// <summary>
		///     RU: Перечень ссылок на эмблемы 95x85 px
		///     <para> EN: List of links to 95x85 px emblems </para>
		/// </summary>
		[JsonProperty("x85")] public string[]? X85;
	}
}