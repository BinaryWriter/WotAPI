namespace WotAPI;

public class ResponseAttribute : Attribute
{
	public readonly bool ReplaceSearchInJson;
	public readonly string? Url;

	public ResponseAttribute(string? url, bool replaceSearchInJson = false)
	{
		Url = url;
		ReplaceSearchInJson = replaceSearchInJson;
	}
}