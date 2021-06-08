using Newtonsoft.Json;
using System.Collections.Generic;
using WotAPI.Api.Response;

/*
 * @author: BinaryWriter
 */

namespace WotAPI.Tankopedia
{
    public class TankopediaInfo : IResponse<TankopediaInfo.Info>
    {
        public partial class Info
        {
            /// <summary> RU: Версия игрового клиента <para> EN: Game client version </para></summary>
            [JsonProperty("game_version")]
            public string GameVersion;
            /// <summary> RU: Cписок поддерживаемых языков <para> EN: List of supported languages </para></summary>
            [JsonProperty("languages")]
            public Dictionary<string, string> Languages = new Dictionary<string, string>();
            /// <summary> RU: Время обновления информации о технике в энциклопедии <para> EN: Time when vehicles details in Tankopedia were updated </para></summary>
            [JsonProperty("tanks_updated_at")]
            public long TanksUpdatedAt;
            /// <summary> RU: Возможные специальности экипажа <para> EN: Available crew qualifications </para></summary>
            [JsonProperty("vehicle_crew_roles")]
            public Dictionary<string, string> VehicleCrewRoles = new Dictionary<string, string>();
            /// <summary> RU: Доступные нации <para> EN: Nations available </para></summary>
            [JsonProperty("vehicle_nations")]
            public Dictionary<string, string> VehicleNations = new Dictionary<string, string>();
            /// <summary> RU: Возможные типы техники <para> EN: Available vehicle types </para></summary>
            [JsonProperty("vehicle_types")]
            public Dictionary<string, string> VehicleTypes = new Dictionary<string, string>();
            /// <summary> RU: Разделы наград <para> EN: Award sections </para></summary>
            [JsonProperty("achievement_sections")]
            public Dictionary<string, AchivementSelection> AchchievementSections = new Dictionary<string, AchivementSelection>();
        }
        public partial class AchivementSelection
        {
            /// <summary> RU: Название раздела наград <para> EN: Award section name </para></summary>
            [JsonProperty("name")]
            public string Name;
            /// <summary> RU: Порядок раздела наград <para> EN: Award section order </para></summary>
            [JsonProperty("order")]
            public int Order;
        }
    }
}
