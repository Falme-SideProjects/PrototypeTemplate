using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DIRECTION
{
    UP = 0,
    RIGHT = 1,
    DOWN = 2,
    LEFT = 3,
    NONE = 4,
}

public class Character : MonoBehaviour
{
    protected SpriteRenderer spriteRenderer;

    protected List<DIRECTION> listOfActions;

    void Awake()
    {
        listOfActions = new List<DIRECTION>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    protected void CallColor(DIRECTION direction)
    {
        switch(direction)
        {
            case DIRECTION.UP:
                spriteRenderer.color = Color.cyan;
                break;
            case DIRECTION.RIGHT:
                spriteRenderer.color = Color.grey;
                break;
            case DIRECTION.DOWN:
                spriteRenderer.color = Color.red;
                break;
            case DIRECTION.LEFT:
                spriteRenderer.color = Color.yellow;
                break;
            default:
                spriteRenderer.color = Color.white;
                break;
        }
    }

	public virtual IEnumerator PerformMoves()
	{
        yield return null;
	}

	public virtual void AddNewMove()
	{
        
	}
}
