using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DietManager : MonoBehaviour
{
    public static DietManager Instance;
    public static List<Diet> Diets = new List<Diet>();


    private void Awake()
    {
        Instance = this;
    }

    public void Add(Diet Diet)
    {
        if (Diets.Count < 3)
        {
            Diets.Add(Diet);
        }
        else return;
    }

    public void Remove(Diet Diet)
    {
        Diets.Remove(Diet);
    }

    public static List<Diet> getDietList()
    {
        return Diets;
    }


}
