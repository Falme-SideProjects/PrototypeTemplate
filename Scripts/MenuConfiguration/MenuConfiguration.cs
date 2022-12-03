using TMPro;
using UnityEngine;

public abstract class MenuConfiguration : MonoBehaviour
{
    
	protected void CallMenuInputType(TextMeshProUGUI inputRequestText, string postInputRequestText)
	{
		MenuInputType inputType = GetComponent<MenuInputType>();
		if (inputType == null)
		{
			Debug.LogError("No [MenuInputType] Class Component was implemented");
			return;
		}

		inputType.SetInputText(inputRequestText, postInputRequestText);
	}
}
