using Newtonsoft.Json;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.GlobalMap
{
    public class GlobalMapInfo : IResponse<GlobalMapInfo.GlobalMapInfoData>
    {
        public partial class GlobalMapInfoData
        {
            /// <summary> RU: Номер последнего рассчитанного хода <para> EN: Number of last calculated turn </para></summary>
            [JsonProperty("last_turn")]
            public int LastTurn;
            /// <summary> RU: Время создания последнего рассчитанного хода в UTC <para> EN: Creation time of the last calculated turn in UTC </para></summary>
            [JsonProperty("last_turn_created_at")]
            public long LastTurnCreatedAt;
            /// <summary> RU: Время расчёта последнего хода в UTC <para> EN: Calculation time of the last turn in UTC </para></summary>
            [JsonProperty("last_turn_calculated_at")]
            public long LastTurnCalculatedAt;
            /// <summary> RU: Состояние карты: active - активна, frozen - заморожена, turn_calculation_in_progress - происходит расчёт хода <para> EN: Map status: active, frozen, turn_calculation_in_progress </para></summary>
            [JsonProperty("state")]
            public string State;
        }
    }
}
