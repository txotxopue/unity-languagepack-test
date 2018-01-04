using System.Reflection;
using UnityEngine;

public static class LanguageService 
{
	// In this case we don't need to access static members on the language pack. Every word in the pack will be a public instance variable.	
	private static readonly BindingFlags FLAGS = BindingFlags.Public | BindingFlags.Instance /* | BindingFlags.Static */;
	private static ScriptableLanguagePack languagePack;

	public static void SetLanguagePack(ScriptableLanguagePack pLanguagePack) 
	{
		languagePack = pLanguagePack;
	}


	/// <summary>
	/// Giving a key, this returns the corresponding value in the loaded language pack.
	/// </summary>
	/// <param name="key"> a string that is a unique identifier for a word in the language pack</param>
	/// <returns> a string containing the value of the word in the language pack</returns>
	public static string GetValue(string key) 
	{
		// Load class fields through reflection.
		FieldInfo[] fields = languagePack.GetType().GetFields(FLAGS);
		// Try to retrieve the field named as our key.
		foreach (FieldInfo fieldInfo in fields)
		{
			// If found, return the value in the loaded language pack.
			if (fieldInfo.Name.Equals(key)) return fieldInfo.GetValue(languagePack).ToString();
		}
		// Otherwise return an Error String or throw an excetion or whatever.
		return "[ERROR: String key not found]";
	}
}
