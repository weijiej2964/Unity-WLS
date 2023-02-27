using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Diet", menuName = "Diet/Create New Diet")]

public class Diet : ScriptableObject
{
    public int id;
    public string DietName;
    public int Calories;
    public Sprite icon;


}
