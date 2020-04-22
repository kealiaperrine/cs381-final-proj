using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Command
{
    public Monster monster;
    public bool isRunning = false;
    //public bool isRunning = false;

    public Command(Monster mon)
    {
        monster = mon;
    }

    // Start is called before the first frame update
    public virtual void Init()
    {

    }

    // Update is called once per frame
    public virtual void Tick()
    {

    }

    public virtual bool IsDone()
    {
        return false;
    }

    public virtual void Stop()
    {

    }
}
