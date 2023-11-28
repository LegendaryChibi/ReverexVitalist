using Mono.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IV : Minigame
{

    [SerializeField]
    private int timeLimit = 5;
    [SerializeField]
    private string instructions = "IV Game Here";


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
