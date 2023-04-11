using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEvents 
{
    static List<RandomEvents> RandomEvents = new List<RandomEvents>(); 
    static RandomEvents CurrentEvent; 

    public TheEvents()
    {
    }

    public static void Normal()
    {
        RandomEvents.Add(new RandomEvents(4, 1, 0, 0, 0, "You Lost control and stuffed yourself with junk"));
        RandomEvents.Add(new RandomEvents(0, 0, 0, -5, 0, "You felt unmotivated to do any exercise"));
        RandomEvents.Add(new RandomEvents(0, 0, 0, 0, 0, "Your friend came to visit, you skip your routine today"));
    }

    public static void getRandomEvent()
    {
        CurrentEvent = RandomEvents[Random.Range(0,RandomEvents.Count)];
    }

    public static RandomEvents getCurrent()
    {
        return CurrentEvent;
    }
}
