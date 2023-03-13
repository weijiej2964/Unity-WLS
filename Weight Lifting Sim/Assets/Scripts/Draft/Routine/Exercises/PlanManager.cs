using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanManager: MonoBehaviour
{
    public static PlanManager Instance;
    public static List<Exercise> Exercises = new List<Exercise>();


    private void Awake()
    {
        Instance = this; 
    }

    public void Add(Exercise Exercise)
    {
        if (Exercises.Count < 3)
        {
            Exercises.Add(Exercise);
        }
        else return;
    }

    public void Remove(Exercise Exercise)
    {
        Exercises.Remove(Exercise);
    }

    public static List<Exercise> getExerciseList()
    {
        return Exercises;
    }
   

}
