using System.Reflection;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace WotAPI;

public class ResponseClass<TDataClass>
{
	[JsonProperty("error")] public ErrorClass? Error;

	[JsonProperty("meta")] public MetaClass? Meta;

	[JsonProperty("data")] public TDataClass? Result;

	[JsonProperty("status")] public string? Status;

	public static TDataClass Get(object? search = null, int? pageNumber = 1,
		Dictionary<string, object>? parameters = null)
	{
		return GetAll(search, pageNumber, parameters).Result!;
	}

	public static ResponseClass<TDataClass> GetAll(object? search = null, int? pageNumber = 1,
		Dictionary<string, object>? parameters = null)
	{
		var api = WotApi.Current;

		if (api == null)
			throw new Exception($"Before calling this method, create a new instance of {nameof(WotApi)}");

		var tDataClassType = typeof(TDataClass);

		var tClassType = Assembly
			.GetExecutingAssembly()
			.GetTypes()
			.FirstOrDefault(type => type.GetNestedTypes().Contains(tDataClassType.HasElementType ? tDataClassType.GetElementType() : tDataClassType));

		if (tClassType == null)
			throw new Exception($"Response class by name ({tDataClassType!.Name}) not found");

		var attribute = tClassType.GetCustomAttribute<ResponseAttribute>();

		if (attribute?.Url == null)
			throw new Exception(
				$"Attribute {nameof(ResponseAttribute)} not found in this class ({tClassType.Namespace}.{tClassType.Name})");

		var url = attribute.Url + (attribute.Url.EndsWith("/")
			? $"?application_id={api.ApplicationId}&page_no{pageNumber}"
			: $"&application_id={api.ApplicationId}&page_no={pageNumber}");

        if (parameters != null)
			url += $"&{string.Join("&", parameters.Select(parameter => $"{parameter.Key}={parameter.Value}"))}";

        //url = url.Replace(".ru/", $".{api.Region}/");
        if (api.Region == $"{WotApi.WotApiRegion.RuBy}".ToLower())
            url = url.Replace("{region_site}", "api.tanki.su");
        else
            url = url.Replace("{region_site}", $"api.worldoftanks.{api.Region}");

        if (search != null)
		{
			url = url.Replace("{search}", search.ToString());
		}
		else
		{
			var matches = new Regex("[?|&].*?={search}").Matches(url).Where(match => match.Success);

			url = matches.Aggregate(url, (current, match) => current.Replace(match.Value, string.Empty));
		}

		var responseText = api.HttpClient.GetStringAsync(url).Result;

		if (responseText == null)
			throw new Exception($"Failed to get data from link: {url}");

		if (attribute.ReplaceSearchInJson)
			responseText = responseText.Replace($"\"{search}\"", "\"search\"");

		var response = JsonConvert.DeserializeObject(responseText, tClassType);

		if (response == null)
			throw new JsonSerializationException($"Error while deserializing result: {responseText}");

		return (ResponseClass<TDataClass>) response;
	}

	public class MetaClass
	{
		[JsonProperty("count")] public int? Count;

		[JsonProperty("total")] public int? Total;
	}

	public class ErrorClass
	{
		[JsonProperty("code")] public int? Code;

		[JsonProperty("field")] public string? Field;

		[JsonProperty("message")] public string? Message;
	}
}