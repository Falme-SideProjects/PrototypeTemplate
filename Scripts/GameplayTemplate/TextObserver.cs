using UnityEngine;
using TMPro;

public class TextObserver : Observer
{
    [SerializeField] private bool doubleIt = false;
    [SerializeField] private string prename;
    private TextMeshProUGUI text;
    private int value = 0;

    private void Awake() {
        text = GetComponent<TextMeshProUGUI>();
    }

	public override void Refresh()
	{
        if(doubleIt) value+=2;
		else value++;
        text.text = string.Concat(prename, value);
    }
}
