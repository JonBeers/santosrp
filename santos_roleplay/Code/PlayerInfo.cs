using Sandbox;

public sealed class PlayerInfo : Component
{
	[Property, ReadOnly] public string FirstName {get; set;}
	[Property, ReadOnly] public string LastName {get; set;}
	[Property, ReadOnly] public float Age {get; set;}
	[Property, ReadOnly] public string Gender {get; set;}


	protected override void OnAwake()
	{
		// we should load the selected character
		var character = PlayerData.SelectedCharacter;

		FirstName = character.FirstName;
		LastName = character.LastName;
		Age = character.Age;
		Gender = character.Gender;
	}


}
