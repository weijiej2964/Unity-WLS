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
        RandomEvents.Add(new RandomEvents(0, 0, 0, -5, 0, "You watch too much sad videos, lose motivation"));//bad
        RandomEvents.Add(new RandomEvents(0, 0, 0, 5, 0, "You watch a lot of anime, increase motivation"));//good
        RandomEvents.Add(new RandomEvents(0, -5, 10, 0, 0, " You want to work out over time, increase muslces and lose fat"));//good
        RandomEvents.Add(new RandomEvents(5, 5, 0, 0, 0, "When to a food festival and ate a lot, increase fat"));//bad
        RandomEvents.Add(new RandomEvents(-2,-10, 0, 0, 0," Doing only cardio workout, you lose fat and weight"));// good 
        RandomEvents.Add(new RandomEvents(10, 5, 0, 0, 0, "went to a eating competition and 65 hot dogs, you gain a lot of fat));//bad
                                          
        //RandomEvents.Add(new RandomEvents(Random.Range(-5,5), Random.Range(-1, 1),Random.Range(-0.2f, 0.2f), 0, 0, "Your friend came to visit, you skip your routine today"));

        //Determination based
        DeterminationBasedEvents.Add(new RandomEvents(2, 2, 0, 0, 0, "You Lost control and stuffed yourself with junk"));
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
