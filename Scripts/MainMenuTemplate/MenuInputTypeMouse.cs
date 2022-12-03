using UnityEngine;

public class MenuInputTypeMouse : MenuInputType
{
    
	protected override void Awake()
	{
		base.Awake();
        instructions = "Click ";
	}

	protected override void Update()
	{
		base.Update();
        if(Input.GetKeyDown(KeyCode.Mouse0)) GoToGameplay();
	}
}