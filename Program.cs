using System.Net.Http;

HttpClient client = new HttpClient();

string url = "https://wttr.in/Nancy?format=j1";

string response = await client.GetStringAsync(url);




WeatherResponse? weather = System.Text.Json.JsonSerializer.Deserialize<WeatherResponse>(response);

if (weather == null || weather.current_condition.Count == 0)
{
    Console.WriteLine("Impossible de récupérer la météo.");
    return;
}

var current = weather.current_condition[0];

Console.WriteLine($"Température actuelle : {current.temp_C}°C");
Console.WriteLine($"Humidité : {current.humidity}%");
Console.WriteLine($"Conditions : {current.weatherDesc[0].value}");




public class WeatherResponse
{
    public List<CurrentCondition> current_condition { get; set; } = new();
}

public class CurrentCondition
{
    public string temp_C { get; set; } = "";
    public string humidity { get; set; } = "";
    public List<WeatherDesc> weatherDesc { get; set; } = new();
}

public class WeatherDesc
{
    public string value { get; set; } = "";
}