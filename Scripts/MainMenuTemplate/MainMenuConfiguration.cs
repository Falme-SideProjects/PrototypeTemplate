using UnityEngine;
using TMPro;

public class MainMenuConfiguration : MenuConfiguration
{

	[Header("Wait For Player Input text")]

    [SerializeField] private TextMeshProUGUI inputRequestText;
    [SerializeField] private string postInputRequestText;


    void Start()
    {
        LoadInputRequestType();
    }

	private void LoadInputRequestType()
	{
		if (inputRequestText == null)
		{
			Debug.LogError("No inputRequestText [TMPro] was implemented");
			return;
		}

		CallMenuInputType(inputRequestText, postInputRequestText);
	}

}
