using Newtonsoft.Json;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Strongholds
{
    public class StrongholdsClanInfo : IResponse<StrongholdsClanInfo.StrongholdsClanInfoData>
    {
        public partial class StrongholdsClanInfoData
        {
            [JsonProperty("search")]
            public Info Info;
        }

        public partial class Info
        {
            /// <summary> RU: Идентификатор карты, привязанный стройплощадке командного центра <para> EN: Map ID associated with the Command Center construction site </para> </summary>
            [JsonProperty("command_center_arena_id")]
            public string CommandCenterArenaID;
            /// <summary> RU: Суммарный уровень строений Укрепрайона <para> EN: Total level of the Stronghold's structures </para> </summary>
            [JsonProperty("stronghold_buildings_level")]
            public int StrongholdBuildingsLevel;
            /// <summary> RU: Статистика вылазок клана <para> EN: Clan's skirmish statistics </para> </summary>
            [JsonProperty("skirmish_statistics")]
            public SkirmishStatistics SkirmishStatistics;
            /// <summary> RU: Статистика по наступлениям на Укрепрайон клана <para> EN: Statistics for skirmishes against the clan's Stronghold </para> </summary>
            [JsonProperty("battles_series_for_strongholds_statistics")]
            public StrongholdsStatistics BattlesSeriesForStrongholdsStatistics;
            /// <summary> RU: Статистика сражений клана в режиме «Укрепрайон» <para> EN: Statistics for the clan's battles in the Stronghold mode </para> </summary>
            [JsonProperty("battles_for_strongholds_statistics")]
            public StrongholdsStatistics BattlesForStrongholdsStatistics;
            /// <summary> RU: Название клана <para> EN: Clan name </para> </summary>
            [JsonProperty("clan_name")]
            public string ClanName;
            /// <summary> RU: Тег клана <para> EN: Clan tag </para> </summary>
            [JsonProperty("clan_tag")]
            public string ClanTag;
            /// <summary> RU: Уровень Укрепрайона <para> EN: Stronghold's level </para> </summary>
            [JsonProperty("stronghold_level")]
            public int StrongholdLevel;
            /// <summary> RU: Идентификатор клана <para> EN: Clan ID </para> </summary>
            [JsonProperty("clan_id")]
            public int ClanID;
            /// <summary> RU: Информация о стройплощадках Укрепрайона <para> EN: Information about the Stronghold's construction sites </para> </summary>
            [JsonProperty("building_slots")]
            public BuildingSlot[] BuildingSlots;
        }

        public partial class StrongholdsStatistics
        {
            /// <summary> RU: Количество побед на технике X уровня <para> EN: Number of victories on Tier X vehicles </para></summary>
            [JsonProperty("win_10")]
            public long Win10;
            /// <summary> RU: Общее количество боёв на технике X уровня <para> EN: Total number of battles on Tier X vehicles </para></summary>
            [JsonProperty("total_10")]
            public long Total10;
            /// <summary> RU: Общее количество боёв на технике X уровня за 28 дней <para> EN: Total number of battles on Tier X vehicles within the last 28 days </para></summary>
            [JsonProperty("total_10_in_28d")]
            public long Total10In28D;
            /// <summary> RU: Количество побед на технике X уровня за 28 дней <para> EN: Number of victories on Tier X vehicles within the last 28 days </para></summary>
            [JsonProperty("win_10_in_28d")]
            public long Win10In28D;
            /// <summary> RU: Время окончания последнего боя, проведённого на технике X уровня <para> EN: End time of the last battle held on Tier X vehicles </para></summary>
            [JsonProperty("last_time_10")]
            public long LastTime10;
            /// <summary> RU: Количество поражений на технике X уровня <para> EN: Number of defeats on Tier X vehicles </para></summary>
            [JsonProperty("lose_10")]
            public long Lose10;
        }

        public partial class BuildingSlot
        {
            /// <summary> RU: Название плацдарма <para> EN: Bridgehead's name </para></summary>
            [JsonProperty("direction")]
            public string Direction;
            /// <summary> RU: Идентификатор карты, привязанный к текущей стройплощадке <para> EN: Map ID associated with the current construction site </para></summary>
            [JsonProperty("arena_id")]
            public string ArenaID;
            /// <summary> RU: Название Резерва, заработанного в строении, расположенном на текущей стройплощадке <para> EN: Name of the Reserve earned in the structure located on the current construction site</para></summary>
            [JsonProperty("reserve_title")]
            public string ReserveTitle;
            /// <summary> RU: Уровень строения, расположенного на текущей стройплощадке <para> EN: Level of the structure located on the current construction site</para></summary>
            [JsonProperty("building_level")]
            public int BuildingLevel;
            /// <summary> RU: Позиция стройплощадки <para> EN: Position of the construction site </para></summary>
            [JsonProperty("position")]
            public string Position;
            /// <summary> RU: Название строения, расположенного на текущей стройплощадке <para> EN: Name of the structure located on the current construction site </para></summary>
            [JsonProperty("building_title")]
            public string BuildingTitle;
        }

        public partial class SkirmishStatistics
        {
            /// <summary> RU: Количество побед на технике X уровня <para> EN: Number of victories on Tier X vehicles </para></summary>
            [JsonProperty("win_10")]
            public int Win10;
            /// <summary> RU: Общее количество боёв на технике VI уровня <para> EN: Total number of battles on Tier VI vehicles </para></summary>
            [JsonProperty("total_6")]
            public int Total6;
            /// <summary> RU: Общее количество боёв на технике X уровня <para> EN: Total number of battles on Tier X vehicles </para></summary>
            [JsonProperty("total_10")]
            public int Total10;
            /// <summary> RU: Количество побед на технике VI уровня <para> EN: Number of victories on Tier VI vehicles </para></summary>
            [JsonProperty("win_6")]
            public int Win6;
            /// <summary> RU: Общее количество боёв на технике X уровня за 28 дней <para> EN: Total number of battles on Tier X vehicles within the last 28 days </para></summary>
            [JsonProperty("total_10_in_28d")]
            public int Total10In28d;
            /// <summary> RU: Количество побед на технике VIII уровня за 28 дней <para> EN: Number of victories on Tier VIII vehicles within the last 28 days </para></summary>
            [JsonProperty("win_8_in_28d")]
            public int Win8In28d;
            /// <summary> RU: Количество поражений на технике VIII уровня <para> EN: Number of defeats on Tier VIII vehicles </para></summary>
            [JsonProperty("lose_8")]
            public int Lose8;
            /// <summary> RU: Количество поражений на технике VI уровня <para> EN: Number of defeats on Tier VI vehicles </para></summary>
            [JsonProperty("lose_6")]
            public int Lose6;
            /// <summary> RU: Общее количество боёв на технике VIII уровня <para> EN: Total number of battles on Tier VIII vehicles </para></summary>
            [JsonProperty("total_8")]
            public int Total8;
            /// <summary> RU: Время окончания последнего боя, проведённого на технике VI уровня <para> EN: End time of the last battle held on Tier VI vehicles </para></summary>
            [JsonProperty("last_time_6")]
            public int LastTime6;
            /// <summary> RU: Время окончания последнего боя, проведённого на технике X уровня <para> EN: End time of the last battle held on Tier X vehicles </para></summary>
            [JsonProperty("last_time_10")]
            public int LastTime10;
            /// <summary> RU: Количество поражений на технике X уровня <para> EN: Number of defeats on Tier X vehicles </para></summary>
            [JsonProperty("lose_10")]
            public int Lose10;
            /// <summary> RU: Общее количество боёв на технике VI уровня за 28 дней <para> EN: Total number of battles on Tier VI vehicles within the last 28 days </para></summary>
            [JsonProperty("total_6_in_28d")]
            public int Total6In28d;
            /// <summary> RU: Общее количество боёв на технике VIII уровня за 28 дней <para> EN: Total number of battles on Tier VIII vehicles within the last 28 days </para></summary>
            [JsonProperty("total_8_in_28d")]
            public int Total8In28d;
            /// <summary> RU: Количество побед на технике VI уровня за 28 дней <para> EN: Number of victories on Tier VI vehicles within the last 28 days </para></summary>
            [JsonProperty("win_6_in_28d")]
            public int Win6In28d;
            /// <summary> RU: Количество побед на технике X уровня за 28 дней <para> EN: Number of victories on Tier X vehicles within the last 28 days </para></summary>
            [JsonProperty("win_10_in_28d")]
            public int Win10In28d;
            /// <summary> RU: Время окончания последнего боя, проведённого на технике VIII уровня <para> EN: End time of the last battle held on Tier VIII vehicles </para></summary>
            [JsonProperty("last_time_8")]
            public int LastTime8;
            /// <summary> RU: Количество побед на технике VIII уровня <para> EN: Number of victories on Tier VIII vehicles </para></summary>
            [JsonProperty("win_8")]
            public int Win8;
        }
    }
}
