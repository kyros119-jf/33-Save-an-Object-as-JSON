using System.Text.Json;

PlayerSettings settings = new PlayerSettings
{
    PlayerName = "Jeremy",
    Volume = 75,
    FullScreen = true
};

string json = JsonSerializer.Serialize(settings);

File.WriteAllText("settings.json", json);