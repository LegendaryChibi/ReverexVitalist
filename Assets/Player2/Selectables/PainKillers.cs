using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Name: Joshua Varghese
//Date: 11/27/2023
//Purpose: The pain killer tertiary minigame will run and end here

public class PainKillers : Minigame
{

    [SerializeField]
    private int timeLimit = 5;
    [SerializeField]
    private string instructions = "Pain Killers Game Here";


    private void Update()
    {
        if (taskTime() <= 0)
        {
            gameObject.SetActive(false);
        }
        countDown();
    }

    private void OnEnable()
    {
        isStarted();
        setTime(timeLimit);
        setText(instructions);
    }
}
