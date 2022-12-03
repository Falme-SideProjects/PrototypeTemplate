using System.Collections;
using UnityEngine;


public class CPU : Character
{
	public override IEnumerator PerformMoves()
	{
		for(int a=0; a<this.listOfActions.Count; a++)
        {
            CallColor(this.listOfActions[a]);
            yield return new WaitForSeconds(1f);
        }

        CallColor(DIRECTION.NONE);
	}
    
	public override void AddNewMove()
	{
		this.listOfActions.Add((DIRECTION)Random.Range(0,4));
	}

}
