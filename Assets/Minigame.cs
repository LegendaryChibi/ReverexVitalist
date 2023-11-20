using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Minigame : MonoBehaviour
{
    protected float time = 0;
    protected bool running;
    protected string text;

    protected void isFinished()
    {
        running = false;
    }

    protected void isStarted()
    {
        running = true;
    }

    protected void setText(string text)
    {
        this.text = text;
    }

    protected void setTime(int time)
    {
        this.time = time;
    }

    public bool inProgress()
    {
        return running;
    }

    protected float countDown()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            return time;
        }
        isFinished();
        return 0;
    }

    public string taskText()
    {
        if (running)
        {
            return text;
        }
        return null;
    }

    public float taskTime()
    {
        if (running)
        {
            return time;
        }
        return 0;
    }
}
