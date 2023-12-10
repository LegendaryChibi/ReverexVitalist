using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//Name: Joshua Varghese
//Date: 11/27/2023
//Purpose: To display minigames to the screen

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI screen;

    [SerializeField]
    private Button adrenalineBtn;
    [SerializeField]
    private Button steroidsBtn;
    [SerializeField]
    private Button eyeDropBtn;
    [SerializeField]
    private Button painKillersBtn;

    [SerializeField]
    private GameObject adrenalineGame;
    [SerializeField]
    private GameObject steroidsGame;
    [SerializeField]
    private GameObject eyeDropGame;
    [SerializeField]
    private GameObject painKillersGame;

    [SerializeField]
    private MinigameManager manager;

    private void Awake()
    {
        adrenalineBtn.onClick.AddListener(adrenaline);
        steroidsBtn.onClick.AddListener(steroids);
        eyeDropBtn.onClick.AddListener(eyeDrop);
        painKillersBtn.onClick.AddListener(painKillers);
    }

    private void Update()
    {
        SetScreenText();
    }

    private void SetScreenText()
    {
        screen.text = "Tasks:" + "\n" + manager.tasktInstructions() + " " + manager.taskTimer();
    }

    private void adrenaline()
    {
        if (manager.isRunning()) { return; }
        adrenalineGame.SetActive(true);
    }

    private void steroids()
    {
        if (manager.isRunning()) { return; }
        steroidsGame.SetActive(true);
    }

    private void eyeDrop()
    {
        if (manager.isRunning()) { return; }
        eyeDropGame.SetActive(true);
    }

    private void painKillers()
    {
        if (manager.isRunning()) { return; }
        painKillersGame.SetActive(true);
    }
}
