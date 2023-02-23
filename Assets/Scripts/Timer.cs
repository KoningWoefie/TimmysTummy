using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{
    private float seconds;

    private bool started;
    private bool paused;
    private bool stopped;

    public Timer()
    {
        seconds = 0;
        started = false;
        paused = false;
        stopped = false;
    }

    // Update is called once per frame
    public void StartTimer()
    {
        started = true;
        paused = false;
        stopped = false;
    }

    public void PauseTimer()
    {
        paused = true;
    }

    public void StopTimer()
    {
        stopped = true;
        started = false;
        paused = false;
    }

    public float Seconds()
    {
        return seconds;
    }

    public void Update(float deltaTime)
    {
        if(started && !paused && !stopped)
        {
            seconds += deltaTime;
        }
        if(stopped)
        {
            seconds = 0;
        }
    }
}
