using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageElement : MonoBehaviour 
{
	private Text textComponent;

	private void Awake() 
	{
		textComponent = GetComponent<Text>();
	}

	void Start () 
	{
		// Currently, this is just valid for Text Components. 
		// A solution might be having a private member for each of the possible Components with a text property,
		// and then checking here which one is present.
		var value = LanguageService.GetValue(textComponent.text);
		textComponent.text = value;
	}
}
