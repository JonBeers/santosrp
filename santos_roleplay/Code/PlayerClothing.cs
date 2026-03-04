using System;
using System.IO;
using Sandbox;

public class PlayerClothing
{
	public static void LoadClothing(string category, List<Clothing> clothing)
	{
		if (category == null || clothing == null)
		{
            Log.Info("Could not find category or list");
			return;
		}

		var clothes = ResourceLibrary.GetAll<Clothing>()
            .Where(c => c.Category.ToString().StartsWith(category))
            .ToList();
	
		clothing.AddRange(clothes);

        foreach (var c in clothing)
        {
            Log.Info($"Added item {c}");
        }
	}

}