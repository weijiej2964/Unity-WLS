using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetPlan : MonoBehaviour
{
    public Sprite dumbell; 
    public void buttonClicked()
    {
        for(int i = PlanManager.getExerciseList().Count-1; i >= 0; i--)
        {
            PlanManager.Instance.Remove(PlanManager.getExerciseList()[i]);
        }
        GameObject First = GameObject.Find("FirstExercise/Icon");
        GameObject Second = GameObject.Find("SecondExercise/Icon");
        GameObject Third = GameObject.Find("ThirdExercise/Icon");

        First.GetComponent<Image>().sprite = dumbell;
        Second.GetComponent<Image>().sprite = dumbell;
        Third.GetComponent<Image>().sprite = dumbell;
    }
}
