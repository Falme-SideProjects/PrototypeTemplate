using UnityEngine;

public class MenuInputTypeEnter : MenuInputType
{
	protected override void Awake()
	{
		base.Awake();
        instructions = "Press Enter ";
	}

	protected override void Update()
	{
		base.Update();
        if(Input.GetKeyDown(KeyCode.Return)) GoToGameplay();
	}
}
