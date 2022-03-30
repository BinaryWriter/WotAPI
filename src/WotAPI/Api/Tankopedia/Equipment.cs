using Newtonsoft.Json;

namespace WotAPI.Api.Tankopedia;

[Response("https://api.worldoftanks.ru/wot/encyclopedia/provisions/")]
public class Equipment : ResponseClass<Equipment.Data>
{
	public class Data
	{
		/// <summary>
		///     RU: Описание снаряжения или оборудования
		///     <para> EN: Consumables or equipment description </para>
		/// </summary>
		[JsonProperty("description")] public string? Description;

		/// <summary>
		///     RU: Ссылка на изображение
		///     <para> EN: Image link </para>
		/// </summary>
		[JsonProperty("image")] public string? Image;

		/// <summary>
		///     RU: Название снаряжения или оборудования
		///     <para> EN: Consumables or equipment name </para>
		/// </summary>
		[JsonProperty("name")] public string? Name;

		/// <summary>
		///     RU: Стоимость в кредитах
		///     <para> EN: Cost in credits </para>
		/// </summary>
		[JsonProperty("price_credit")] public int? PriceCredit;

		/// <summary>
		///     RU: Стоимость в золоте
		///     <para> EN: Cost in gold </para>
		/// </summary>
		[JsonProperty("price_gold")] public int? PriceGold;

		/// <summary>
		///     RU: Идентификатор оборудования или снаряжения
		///     <para> EN: Equipment or consumables ID  </para>
		/// </summary>
		[JsonProperty("provision_id")] public int? ProvisionId;

		/// <summary>
		///     RU: Техническое название
		///     <para> EN: Technical name </para>
		/// </summary>
		[JsonProperty("tag")] public string? Tag;

		/// <summary>
		///     RU: Тип: снаряжение или оборудование
		///     <para> EN: Type: consumable or equipment </para>
		/// </summary>
		[JsonProperty("type")] public string? Type;

		/// <summary>
		///     RU: Масса в килограммах. Только для оборудования
		///     <para> EN: Weight in kilos. Used for equipment only.  </para>
		/// </summary>
		[JsonProperty("weight")] public int? Weight;
	}
}