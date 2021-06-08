using Newtonsoft.Json;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Accounts
{
    public class PlayerVehicles : IResponse<PlayerVehicles.PlayerVehiclesData>
    {

        public partial class PlayerVehiclesData
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
            public int Mark_Of_Mastery;
            /// <summary> RU: Идентификатор техники <para> EN: Vehicle statistics </para> </summary>
            [JsonProperty("tank_id")]
            public int Tank_ID;

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
}
