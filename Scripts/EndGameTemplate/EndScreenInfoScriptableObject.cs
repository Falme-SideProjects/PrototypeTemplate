using UnityEngine;

[CreateAssetMenu(fileName = "EndScreenInfoData_", menuName = "ScriptableObjects/EndScreenInfoScriptableObject", order = 1)]
public class EndScreenInfoScriptableObject : ScriptableObject
{
    public END_SCREEN_TYPE endScreenType;
    public string statusEnding;
    public string descriptionEnding;
    public string waitingInputTextEnding;
}
