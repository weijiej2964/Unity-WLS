using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Exercise",menuName ="Exercise/Create New Exercise")]

public class Exercise : ScriptableObject
{
    public int id;
    public string ExerciseName;
    public int value;
    public Sprite icon; 


}
