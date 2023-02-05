using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExerciseButtonPressed : MonoBehaviour
{
    public Exercise Exercise;
    public Image image;
    public GameObject plan;
    public Image planImage;
    

    public void ButtonPressed()
    {
        PlanManager.Instance.Add(Exercise);



        for(int i = 0; i < PlanManager.getExerciseList().Count; i++)
        {
            switch (i)
            {
                case 0:
                    Exercise temp = PlanManager.getExerciseList()[0];
                    planImage = GameObject.Find("ExercisePlan/FirstExercise/Icon").GetComponent<Image>();
                    planImage.sprite = temp.icon;
                    break;
                case 1:
                    Exercise temp1 = PlanManager.getExerciseList()[1];
                    planImage = GameObject.Find("ExercisePlan/SecondExercise/Icon").GetComponent<Image>();
                    planImage.sprite = temp1.icon;
                    break;
                case 2:
                    Exercise temp2 = PlanManager.getExerciseList()[2];
                    planImage = GameObject.Find("ExercisePlan/ThirdExercise/Icon").GetComponent<Image>();
                    planImage.sprite = temp2.icon; 
                    break;
            }
        }


    }

   

}
