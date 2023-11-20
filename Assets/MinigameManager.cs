using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameManager : MonoBehaviour
{
    [SerializeField]
    private Minigame[] minigames;

    public bool isRunning()
    {
        for (int i = 0; i < minigames.Length; i++)
        {
            if (minigames[i].inProgress())
            {
                return true;
            }
        }
        return false;
    }

    private Minigame activeGame()
    {
        for (int i = 0; i < minigames.Length; i++)
        {
            if (minigames[i].inProgress())
            {
                return minigames[i];
            }
        }
        return null;
    }

    public string tasktInstructions()
    {
        if (activeGame())
        {
            return activeGame().taskText();
        }
        return null;
    }

    public float taskTimer()
    {
        if (activeGame())
        {
            return activeGame().taskTime();
        }
        return 0;
    }
}
