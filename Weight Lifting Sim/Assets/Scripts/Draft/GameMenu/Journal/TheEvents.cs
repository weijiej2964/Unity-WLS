using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEvents 
{
    static List<RandomEvents> RandomEvents = new List<RandomEvents>();
    static List<RandomEvents> DeterminationBasedEvents = new List<RandomEvents>();
    static RandomEvents CurrentEvent;
    static Player player = InitStat.getPlayer();

    public TheEvents()
    {
        
    }

    public static void Normal()
    {
        // Random
        RandomEvents.Add(new RandomEvents(0, 0, 0, -5, 0, "You watch too much sad videos, lose motivation"));
        RandomEvents.Add(new RandomEvents(Random.Range(-5,5), Random.Range(-1, 1),Random.Range(-0.2f, 0.2f), 0, 0, "Your friend came to visit, you skip your routine today"));

        //Determination based
        DeterminationBasedEvents.Add(new RandomEvents(4, 1, 0, 0, 0, "You Lost control and stuffed yourself with junk"));
        DeterminationBasedEvents.Add(new RandomEvents(0, 0, 0, -5, 0, "You reflect on your progress so far, felt disappionted "));
    }

    public static void getRandomEvent()
    {
        if (Random.Range(0, 100) > player.getDetermination())
        {
            CurrentEvent = DeterminationBasedEvents[Random.Range(0, DeterminationBasedEvents.Count)];
        }
        else
        {
            CurrentEvent = RandomEvents[Random.Range(0, RandomEvents.Count)];
        }
    }

    public static RandomEvents getCurrent()
    {
        return CurrentEvent;
    }
}
