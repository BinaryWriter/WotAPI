using Newtonsoft.Json;

namespace WotAPI.Api.Accounts.Player
{
    [Response("https://api.worldoftanks.ru/wot/account/tanks/?account_id={search}", true)]
    public class Vehicles : ResponseClass<Vehicles.Data>
    {
        public partial class Data
        {
            [JsonProperty("search")]
            public Vehicle[] Vehicles;
        }

        public partial class Vehicle
        {
            /// <summary> RU: Статистика машины <para> EN: Vehicle statistics </para> </summary>
            [JsonProperty("statistics")]
            public VehicleStatistic Statistic;
            /// <summary> RU: Знаки классности <para> EN: Mastery Badges </para> </summary>
            [JsonProperty("mark_of_mastery")]
            public int MarkOfMastery;
            /// <summary> RU: Идентификатор техники <para> EN: Vehicle statistics </para> </summary>
            [JsonProperty("tank_id")]
            public int TankID;
        }

        public partial class VehicleStatistic
        {
            /// <summary> RU: Победы <para> EN: Victories </para> </summary>
            [JsonProperty("wins")]
            public int Wins;
            /// <summary> RU: Проведено боёв <para> EN: Battles fought </para> </summary>
            [JsonProperty("battles")]
            public int Battles;
        }
    }
}
