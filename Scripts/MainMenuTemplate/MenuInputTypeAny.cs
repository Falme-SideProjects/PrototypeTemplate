using UnityEngine;

public class MenuInputTypeAny : MenuInputType
{
	protected override void Awake()
	{
		base.Awake();
        instructions = "Press any key ";
	}

	protected override void Update()
	{
		base.Update();
        if(Input.anyKeyDown) GoToGameplay();
	}
}
