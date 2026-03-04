using System.Runtime.CompilerServices;
using Sandbox;

public sealed class PlayerInfo : Component
{
	[Property] SkinnedModelRenderer SkinnedModel {get; set;}
	[Property, ReadOnly, Sync] public string FirstName {get; set;}
	[Property, ReadOnly, Sync] public string LastName {get; set;}
	[Property, ReadOnly, Sync] public float Age {get; set;}
	[Property, ReadOnly, Sync] public string Gender {get; set;}


	protected override void OnAwake()
	{
		if (IsProxy) return;
		var character = PlayerData.SelectedCharacter;

		FirstName = character.FirstName;
		LastName = character.LastName;
		Age = character.Age;
		Gender = character.Gender;
		SetGenderModel();
	}

	private void SetGenderModel()
	{
		if (Gender == null) return;

		if (Gender == "male")
		{
			SkinnedModel.Model = Model.Load("models/citizen_human/citizen_human_male.vmdl");
		}
		else if (Gender == "female")
		{
			SkinnedModel.Model = Model.Load("models/citizen_human/citizen_human_female.vmdl");
		}
	}


}
