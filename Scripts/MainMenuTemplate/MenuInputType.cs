using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public abstract class MenuInputType : MonoBehaviour
{
    [SerializeField] protected Object sceneToGoOnInput;

    protected string instructions = "";

    public virtual void SetInputText(TextMeshProUGUI inputText, string postText = "") 
    {
        inputText.text = string.Concat(instructions, postText);
    }

    protected virtual void Awake() { }

    protected virtual void Update() { }

    protected void GoToGameplay()
    {
        SceneManager.LoadScene(sceneToGoOnInput.name);
    }
}
