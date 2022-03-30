using Newtonsoft.Json;

namespace WotAPI.Api.Clans.Clan;

[Response("https://api.worldoftanks.ru/wot/clans/info/?clan_id={search}", true)]
public class Info : ResponseClass<Info.Data>
{
	public class Data
	{
		[JsonProperty("search")] public Details? Details;
	}

	public class Details : Clans.Clan
	{
		/// <summary>
		///     RU: Клан может приглашать игроков
		///     <para> EN: Clan can invite players </para>
		/// </summary>
		[JsonProperty("accepts_join_requests")] public bool? AcceptsJoinRequests;

		/// <summary>
		///     RU: Идентификатор игрока, создавшего клан
		///     <para> EN: Clan creator ID </para>
		/// </summary>
		[JsonProperty("creator_id")] public long? CreatorId;

		/// <summary>
		///     RU: Имя игрока, создавшего клан
		///     <para> EN: Clan creator's name </para>
		/// </summary>
		[JsonProperty("creator_name")] public string? CreatorName;

		/// <summary>
		///     RU: Описание клана
		///     <para> EN: Clan description </para>
		/// </summary>
		[JsonProperty("description")] public string? Description;

		/// <summary>
		///     RU: Описание клана в HTML
		///     <para> EN: Clan description in HTML </para>
		/// </summary>
		[JsonProperty("description_html")] public string? DescriptionHtml;

		/// <summary>
		///     RU: Клан удалён. Информация об удалённом клане содержит актуальные значения только для следующих полей: clan_id,
		///     is_clan_disbanded, updated_at.
		///     <para>
		///         EN: Clan has been deleted. The deleted clan data contains valid values for the following fields only:
		///         clan_id, is_clan_disbanded, updated_at.
		///     </para>
		/// </summary>
		[JsonProperty("is_clan_disbanded")] public bool IsClanDisbanded;

		/// <summary>
		///     RU: Идентификатор Командующего клана
		///     <para> EN: Clan Commander ID </para>
		/// </summary>
		[JsonProperty("leader_id")] public long? LeaderId;

		/// <summary>
		///     RU: Имя Командующего
		///     <para> EN: Commander's name </para>
		/// </summary>
		[JsonProperty("leader_name")] public string? LeaderName;

		/// <summary>
		///     RU: Информация об игроках клана.Формат поля зависит от входящего параметра members_key
		///     <para> EN: Information on clan members. Field format depends on members_key input parameter. </para>
		/// </summary>
		[JsonProperty("members")] public Clans.ClanMember[]? Members;

		/// <summary>
		///     RU: Девиз клана
		///     <para> EN: Clan motto </para>
		/// </summary>
		[JsonProperty("motto")] public string? Motto;

		/// <summary>
		///     RU: Старое название клана
		///     <para> EN: Old clan name </para>
		/// </summary>
		[JsonProperty("old_name")] public string? OldName;

		/// <summary>
		///     RU: Старый тег клана
		///     <para> EN: Old clan tag </para>
		/// </summary>
		[JsonProperty("old_tag")] public string? OldTag;

		/// <summary>
		///     RU: Время последнего переименования клана в UTC
		///     <para> EN: Time (UTC) when clan name was changed </para>
		/// </summary>
		[JsonProperty("renamed_at")] public long? RenamedAt;

		/// <summary>
		///     RU: Время обновления информации о клане
		///     <para> EN: Time when clan details were updated </para>
		/// </summary>
		[JsonProperty("updated_at")] public long? UpdatedAt;
	}
}