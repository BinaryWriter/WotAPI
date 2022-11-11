using Newtonsoft.Json;

namespace WotAPI.Api.Tankopedia.Vehicle;

[Response("https://{region_site}/wot/encyclopedia/vehicleprofile/?tank_id={search}", true)]
public class Profile : ResponseClass<Profile.Data>
{
	public class Data
	{
		[JsonProperty("search")] public Info.TankProfile? Profile;
	}
}