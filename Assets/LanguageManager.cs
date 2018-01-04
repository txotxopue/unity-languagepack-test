using System.Reflection;
using UnityEngine;

public class LanguageManager : MonoBehaviour 
{
	public ScriptableLanguagePack languagePack;

	private void Awake() 
	{
		// Provide the language pack to the LanguageService.
		// This is the part that you will not use, since you will be retrieving the languagePack name through PlayerPrefs, not by a gameObject reference.
		LanguageService.SetLanguagePack(languagePack);
	}

	private void Start() 
	{
		// Get a word from the language pack. Just for testing. Delete this if it's OK.
		Debug.Log(LanguageService.GetValue("String1"));
	}	

}
