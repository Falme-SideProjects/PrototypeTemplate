using UnityEngine;


public class Player : Character
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)) CallColor(DIRECTION.UP);
        else if(Input.GetKeyDown(KeyCode.RightArrow)) CallColor(DIRECTION.RIGHT);
        else if(Input.GetKeyDown(KeyCode.DownArrow)) CallColor(DIRECTION.DOWN);
        else if(Input.GetKeyDown(KeyCode.LeftArrow)) CallColor(DIRECTION.LEFT);

        if(Input.GetKeyDown(KeyCode.Space)) CallColor(DIRECTION.NONE);
    }
}
