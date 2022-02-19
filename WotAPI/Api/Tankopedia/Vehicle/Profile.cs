using Newtonsoft.Json;

namespace WotAPI.Api.Tankopedia.Vehicle
{
    [Response("https://api.worldoftanks.ru/wot/encyclopedia/vehicleprofile/?tank_id={search}", true)]
    public class Profile : ResponseClass<Profile.Data>
    {
        public partial class Data
        {
            [JsonProperty("search")]
            public Info.TankProfile Profile;
        }
    }
}
