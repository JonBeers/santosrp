using Sandbox;

public class PlayerData
{
  public string FirstName {get; set;}
  public string LastName {get; set;}
  public string Gender {get; set;}
  public float Age {get; set;}
  public static PlayerData SelectedCharacter { get; set; }

  public static void Save(List<PlayerData> characters, ulong steamId)
  {
    FileSystem.Data.WriteJson($"characters_{steamId}.json", characters);
  }

  public static List<PlayerData> Load(ulong steamId)
  {
      var path = $"characters_{steamId}.json";

      if (!FileSystem.Data.FileExists(path))
          return new List<PlayerData>();

      return FileSystem.Data.ReadJson<List<PlayerData>>(path);
  }
  
}