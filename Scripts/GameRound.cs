using UnityEngine;

public enum ROUND_PHASE
{
    HOLD = 0,
    CPU_CHOOSING = 1,
    CPU_PERFORMING = 2,
    PLAYER_CHOOSING = 3,
}

public class GameRound : MonoBehaviour
{
    [SerializeField] private Character cpu;
    [SerializeField] private Character player;

    private ROUND_PHASE roundPhase = ROUND_PHASE.HOLD;

    void Start()
    {
        
    }


    void Update()
    {
        switch(roundPhase)
        {
            case ROUND_PHASE.HOLD:
                roundPhase = ROUND_PHASE.CPU_CHOOSING;
                break;
            case ROUND_PHASE.CPU_CHOOSING:
                cpu.AddNewMove();
                StartCoroutine(cpu.PerformMoves());
                roundPhase = ROUND_PHASE.CPU_PERFORMING;
                break;
            case ROUND_PHASE.CPU_PERFORMING:
                
                break;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
}
