using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheMoods : MonoBehaviour
{
    static List<RandomMood> randomMoods = new List<RandomMood>();
    static RandomMood currentMood;
    static Player player = InitStat.getPlayer();

    public TheMoods()
    {
        
    }

    public static void Normal()
    {
      randomMoods.Add(new RandomMood(0, 0, 0, -10, 0, "Tired"));
      randomMoods.Add(new RandomMood(0, 0, 0, 10, 0, "Energetic"));
      randomMoods.Add(new RandomMood(0, 0, 0, 15, 0, "Determined"));
      randomMoods.Add(new RandomMood(0, 0, 0, -15, 0, "Lazy"));                                       

    }

    public static void getRandomMood()
    {
        currentMood = randomMoods[Random.Range(0, randomMoods.Count)];
    }

    public static RandomMood getCurrent()
    {
        return currentMood;
    }
}
