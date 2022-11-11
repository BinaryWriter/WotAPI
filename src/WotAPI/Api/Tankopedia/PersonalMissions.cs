using Newtonsoft.Json;

namespace WotAPI.Api.Tankopedia;

[Response("https://{region_site}/wot/encyclopedia/personalmissions/")]
public class PersonalMissions : ResponseClass<PersonalMissions.Data>
{
	public class Data
	{
		[JsonProperty("1")] public Campaign? FirstCampaign;
	}

	public class Campaign
	{
		/// <summary>
		///     RU: Идентификатор кампании
		///     <para> EN: Campaign ID </para>
		/// </summary>
		[JsonProperty("campaign_id")] public int? CampaignId;

		/// <summary>
		///     RU: Описание компании
		///     <para> EN: Campaign description </para>
		/// </summary>
		[JsonProperty("description")] public string? Description;

		/// <summary>
		///     RU: Название компании
		///     <para> EN: Campaign name </para>
		/// </summary>
		[JsonProperty("name")] public string? Name;

		/// <summary>
		///     RU: Операции кампании
		///     <para> EN: Operations </para>
		/// </summary>
		[JsonProperty("operations")] public Dictionary<string, Operation>? Operations = new();
	}

	public class Operation
	{
		/// <summary>
		///     RU: Описание операции
		///     <para> EN: Operation description </para>
		/// </summary>
		[JsonProperty("description")] public string? Description;

		/// <summary>
		///     RU: Ссылка на изображение операции
		///     <para> EN: Link to an operation image </para>
		/// </summary>
		[JsonProperty("image")] public string? Image;

		/// <summary>
		///     RU: Задачи операции
		///     <para> EN: Operation missions </para>
		/// </summary>
		[JsonProperty("missions")] public Dictionary<string, Mission>? Missions = new();

		/// <summary>
		///     RU: Количество задач в ветке
		///     <para> EN: Number of missions in the branch </para>
		/// </summary>
		[JsonProperty("missions_in_set")] public int? MissionsInSet;

		/// <summary>
		///     RU: Название операции
		///     <para> EN: Operation name </para>
		/// </summary>
		[JsonProperty("name")] public string? Name;

		/// <summary>
		///     RU: Идентификатор следующей операции
		///     <para> EN: Next operation ID </para>
		/// </summary>
		[JsonProperty("next_id")] public int? NextId;

		/// <summary>
		///     RU: Идентификатор операции
		///     <para> EN: Operation ID </para>
		/// </summary>
		[JsonProperty("operation_id")] public int? OperationId;

		/// <summary>
		///     RU:
		///     <para> EN: </para>
		/// </summary>
		[JsonProperty("reward")] public OperationReward? Reward;

		/// <summary>
		///     RU: Количество веток задач операции
		///     <para> EN: Number of mission branches of the operation </para>
		/// </summary>
		[JsonProperty("sets_count")] public int? SetsCount;

		/// <summary>
		///     RU: Количество веток до следующей операции
		///     <para> EN: Number of branches until the next operation </para>
		/// </summary>
		[JsonProperty("sets_to_next")] public int? SetsToNext;
	}

	public class OperationReward
	{
		/// <summary>
		///     RU: Слоты
		///     <para> EN: Slots </para>
		/// </summary>
		[JsonProperty("slots")] public int? Slots;

		/// <summary>
		///     RU: Идентификаторы техники
		///     <para> EN: Vehicle IDs </para>
		/// </summary>
		[JsonProperty("tanks")] public int[]? Tanks;
	}

	public class Mission
	{
		/// <summary>
		///     RU: Описание задачи
		///     <para> EN: Mission description </para>
		/// </summary>
		[JsonProperty("description")] public string? Description;

		/// <summary>
		///     RU: Советы
		///     <para> EN: Hints </para>
		/// </summary>
		[JsonProperty("hint")] public string? Hint;

		/// <summary>
		///     RU: Максимальный уровень техники
		///     <para> EN: Maximum vehicle Tier </para>
		/// </summary>
		[JsonProperty("max_level")] public int? MaxLevel;

		/// <summary>
		///     RU: Минимальный уровень техники
		///     <para> EN: Minimum vehicle Tier </para>
		/// </summary>
		[JsonProperty("min_level")] public int? MinLevel;

		/// <summary>
		///     RU: Идентификатор задачи
		///     <para> EN: Mission ID </para>
		/// </summary>
		[JsonProperty("mission_id")] public int? MissionId;

		/// <summary>
		///     RU: Название задачи
		///     <para> EN: Mission name </para>
		/// </summary>
		[JsonProperty("name")] public string? Name;

		/// <summary>
		///     RU: Награды, сгруппированые по условию задачи
		///     <para> EN: Rewards grouped by mission conditions </para>
		/// </summary>
		[JsonProperty("rewards")] public MissionRewards? Rewards;

		/// <summary>
		///     RU: Идентификатор ветки задач
		///     <para> EN: Mission branch ID </para>
		/// </summary>
		[JsonProperty("set_id")] public int? SetId;

		/// <summary>
		///     RU: Теги задачи
		///     <para> EN: Mission tags </para>
		/// </summary>
		[JsonProperty("tags")] public string[]? Tags;
	}

	public class MissionRewards
	{
		/// <summary>
		///     RU:
		///     <para> EN: </para>
		/// </summary>
		[JsonProperty("primary")] public MissionReward? Primary;

		/// <summary>
		///     RU:
		///     <para> EN: </para>
		/// </summary>
		[JsonProperty("secondary")] public MissionReward? Secondary;
	}

	public class MissionReward
	{
		/// <summary>
		///     RU: Места в казарме
		///     <para> EN: Bunks in Barracks </para>
		/// </summary>
		[JsonProperty("berths")] public int? Berths;

		/// <summary>
		///     RU: Условия задачи
		///     <para> EN: Mission conditions </para>
		/// </summary>
		[JsonProperty("conditions")] public string? Conditions;

		/// <summary>
		///     RU: Кредиты
		///     <para> EN: Credits </para>
		/// </summary>
		[JsonProperty("credits")] public int? Credits;

		/// <summary>
		///     RU: Свободный опыт
		///     <para> EN: Free Experience </para>
		/// </summary>
		[JsonProperty("free_xp")] public int? FreeXp;

		/// <summary>
		///     RU: Список оборудования или расходников в формате идентификатор - количество единиц
		///     <para> EN: List of equipment or consumables in the following format: ID – number of items </para>
		/// </summary>
		[JsonProperty("items")] public Dictionary<string, int> Items = new();

		/// <summary>
		///     RU: Дни премиум аккаунта
		///     <para> EN: Days of Premium Account </para>
		/// </summary>
		[JsonProperty("premium")] public int? Premium;

		/// <summary>
		///     RU: Слоты
		///     <para> EN: Slots </para>
		/// </summary>
		[JsonProperty("slots")] public int? Slots;

		/// <summary>
		///     RU: Токены
		///     <para> EN: Tokens </para>
		/// </summary>
		[JsonProperty("tokens")] public int? Tokens;
	}
}