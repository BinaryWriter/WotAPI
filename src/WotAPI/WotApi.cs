namespace WotAPI;

public class WotApi
{
	public enum WotApiRegion
	{
		Ru,
		Eu,
		Com,
		Asia,
		RuBy
	}

	public static WotApi? Current;
	
	public readonly HttpClient HttpClient = new();
	public readonly string? ApplicationId;
	public readonly string? Region;

	public static void Create(string? applicationId, WotApiRegion region)
	{
		Current = new WotApi(applicationId, region);
	}

	private WotApi(string? applicationId, WotApiRegion region)
	{
		ApplicationId = applicationId;
		Region = region.ToString().ToLower();
	}
}