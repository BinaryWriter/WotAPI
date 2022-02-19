using Newtonsoft.Json;

namespace WotAPI.Api.GlobalMap
{
    [Response("https://api.worldoftanks.ru/wot/globalmap/fronts/")]
    public class Fronts : ResponseClass<Fronts.Front[]>
    {
        public partial class Front
        {
            /// <summary> RU: Название фронта <para> EN: Front name </para></summary>
            [JsonProperty("front_name")]
            public string FrontName;
            /// <summary> RU: Максимальное количество техники в дивизионе <para> EN: Maximum number of vehicles in division </para></summary>
            [JsonProperty("max_tanks_per_division")]
            public int MaxTanksPerDivision;
            /// <summary> RU: Показывает, присутствует ли Туман войны <para> EN: Indicates presence of Fog of War </para></summary>
            [JsonProperty("fog_of_war")]
            public bool FogOfWar;
            /// <summary> RU: Стоимость покупки дивизии <para> EN: Division cost </para></summary>
            [JsonProperty("division_cost")]
            public int DivisionCost;
            /// <summary> RU: Минимальный уровень техники <para> EN: Minimum vehicle Tier </para></summary>
            [JsonProperty("min_vehicle_level")]
            public int MinVehicleLevel;
            /// <summary> RU: Средний уровень кланов <para> EN: Average clans rating </para></summary>
            [JsonProperty("avg_clans_rating")]
            public int AvgClansRating;
            /// <summary> RU: Показывает, активна ли карта <para> EN: Indicates if a map is active </para></summary>
            [JsonProperty("is_active")]
            public bool IsActive;
            /// <summary> RU: Показывает, присутствует ли блокировка техники <para> EN: Indicates if vehicles blocking is active </para></summary>
            [JsonProperty("vehicle_freeze")]
            public bool VehicleFreeze;
            /// <summary> RU: Средняя выигрышная ставка <para> EN: Average winning bid </para></summary>
            [JsonProperty("avg_won_bet")]
            public int AvgWonBet;
            /// <summary> RU: Количество провинций <para> EN: Amount of Provinces </para></summary>
            [JsonProperty("provinces_count")]
            public int ProvincesCount;
            /// <summary> RU: Доступные модули <para> EN: Available modules </para></summary>
            [JsonProperty("available_extensions")]
            public AvailableExtension[] AvailableExtensions;
            /// <summary> RU: Максимальный уровень техники <para> EN: Maximum vehicle Tier </para></summary>
            [JsonProperty("max_vehicle_level")]
            public int MaxVehicleLevel;
            /// <summary> RU: Минимальное количество техники в дивизионе <para> EN: Minimum number of vehicles in division </para></summary>
            [JsonProperty("min_tanks_per_division")]
            public int MinTanksPerDivision;
            /// <summary> RU: Максимальное время боя в минутах <para> EN: Maximum battle duration in minutes </para></summary>
            [JsonProperty("battle_time_limit")]
            public int BattleTimeLimit;
            /// <summary> RU: Показывает тип карты: обычная карта или карта события <para> EN: Indicates the map type: regular map or events map </para></summary>
            [JsonProperty("is_event")]
            public bool IsEvent;
            /// <summary> RU: Средняя минимальная ставка <para> EN: Average minimum bid </para></summary>
            [JsonProperty("avg_min_bet")]
            public int AvgMinBet;
            /// <summary> RU: Идентификатор фронта <para> EN: Front ID </para></summary>
            [JsonProperty("front_id")]
            public string FrontID;
        }

        public partial class AvailableExtension
        {
            /// <summary> RU: Стоимость содержания модулей <para> EN: Modules upkeep cost </para></summary>
            [JsonProperty("wage")]
            public int Wage;
            /// <summary> RU: Локализованое название cнаряжения <para> EN: Localized consumable name </para></summary>
            [JsonProperty("name")]
            public string Name;
            /// <summary> RU: Локализованое описание тактического эффекта <para> EN: Localized description of tactical effect </para></summary>
            [JsonProperty("description_tactical")]
            public string DescriptionTactical;
            /// <summary> RU: Стоимость покупки модулей <para> EN: Cost of modules </para></summary>
            [JsonProperty("cost")]
            public int Cost;
            /// <summary> RU: Локализованое описание стратегического эффекта <para> EN: Localized description of strategic effect </para></summary>
            [JsonProperty("description_strategic")]
            public string DescriptionStrategic;
            /// <summary> RU: Идентификатор расходника <para> EN: Consumable ID </para></summary>
            [JsonProperty("extension_id")]
            public string ExtensionID;
        }
    }
}
