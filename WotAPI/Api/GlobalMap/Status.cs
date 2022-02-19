using Newtonsoft.Json;

namespace WotAPI.Api.GlobalMap
{
    [Response("https://api.worldoftanks.ru/wot/globalmap/info/")]
    public class Status : ResponseClass<Status.Data>
    {
        public partial class Data
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
