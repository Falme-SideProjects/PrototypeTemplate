using UnityEngine;
using TMPro;

public class TextObserver : MonoBehaviour, IObserver
{
    [SerializeField] private string prename;
    private TextMeshProUGUI text;
    private int value = 0;

    private void Awake() {
        text = GetComponent<TextMeshProUGUI>();
    }

	void IObserver.Update()
	{
		value++;
        text.text = string.Concat(prename, value);
	}
}
