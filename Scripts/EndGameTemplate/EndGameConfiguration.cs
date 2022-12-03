using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public enum END_SCREEN_TYPE
{
    INFINITE = 0,
    WIN = 1,
    LOSE = 2,
}

public class EndGameConfiguration : MenuConfiguration
{
	private const string SCREEN_NAME = "EndGame";
	public static END_SCREEN_TYPE screenType = END_SCREEN_TYPE.INFINITE;

    [Header("Ending Information Data")]
    [SerializeField] private EndScreenInfoScriptableObject[] endScreenInfos;

    [Header("Text References")]
    [SerializeField] private TextMeshProUGUI statusText;
    [SerializeField] private TextMeshProUGUI descriptionText;
    [SerializeField] private TextMeshProUGUI keyToPressText;
    

    void Start()
    {
        FindEndScreenInfo();
    }

    private void FindEndScreenInfo()
    {
        for(int a=0; a<endScreenInfos.Length; a++)
            if(EndGameConfiguration.screenType == endScreenInfos[a].endScreenType)
            {
                statusText.text = endScreenInfos[a].statusEnding;
                descriptionText.text = endScreenInfos[a].descriptionEnding;
                CallMenuInputType(keyToPressText, endScreenInfos[a].waitingInputTextEnding);
                break;
            }
    }

    public static void GoToEndScene(END_SCREEN_TYPE screenType)
    {
        EndGameConfiguration.screenType = screenType;
        SceneManager.LoadScene(SCREEN_NAME);
    }
}
