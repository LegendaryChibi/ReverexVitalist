using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.UIElements;
using UnityEngine;

//Name: Joshua Varghese
//Date: 11/27/2023
//Purpose: To manage minigames currently playing on screen

public class MinigameManager : MonoBehaviour
{
    [SerializeField]
    private Minigame[] minigames;

    [SerializeField]
    private Minigame[] popups;

    private List<int> queue = new List<int>();

    [SerializeField]
    private int popupFrequency;

    private void Awake()
    {
        StartCoroutine(popUpTimer());
    }

    private void FixedUpdate()
    {
        if (!activeGame())
        {
            clearList();
        }
    }

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

    private IEnumerator popUpTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(popupFrequency);
            if (!popups.Contains(activeGame())) {
                int num = Random.Range(0, popups.Length);
                queue.Add(num);
            }
        }
    }

    private void clearList()
    {
        if (queue.Count > 0)
        {
            popups[queue[0]].gameObject.SetActive(true);
            queue.RemoveAt(0);
        }
    }
}
