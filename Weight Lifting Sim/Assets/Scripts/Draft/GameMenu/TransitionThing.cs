using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TransitionThing : MonoBehaviour
{

    public TextMeshProUGUI dayNum;
    int counter;

    Player player;
    List<Diet> diets;
    List<Exercise> exercises;
    int extraCal;
    float muscleGrowthIndex;

    double dailyMuscleGrowth;
    double dailyWeightGrowth;
    double dailyFatGrowth;
    int dailyMetabolismChange;
    int dailyDeterminationChange;
    private void Start()
    {
        player = InitStat.getPlayer();
        diets = DietManager.Diets;
        exercises = PlanManager.Exercises;
        counter = 1;
        dayNum.text = "Day " + counter; 
    }

    public void buttonClick(){
       
        extraCal = 0;
        counter++;
        dayNum.text = "Day " + counter;

        //calculate total calories
        foreach(Diet d in diets)
        {
            extraCal += d.getCal();
            
        }

        foreach(Exercise e in exercises)
        {
            extraCal -= e.CaloriesBurned;
            muscleGrowthIndex += e.MuscleMassIncrease;
        }

        extraCal -= player.getMetabolism();
        //change metabolism
        dailyMetabolismChange = extraCal / 100; 
        
        //change fat & muscle
        if(extraCal >= 0)
        {
            if(muscleGrowthIndex > 0 && extraCal > 500)
            {
                dailyMuscleGrowth = (500 * .75) / 2500;
                dailyFatGrowth = (500 * .25) / 1200;
                extraCal -= 500;
                dailyDeterminationChange = 5;
            }
            else if(muscleGrowthIndex <= 0 && extraCal > 500)
            {
                dailyMuscleGrowth = (500 * .2) / 2500;
                dailyFatGrowth = (500 * .8) / 1200;
                extraCal -= 500;
                dailyDeterminationChange = 5;
            }
            else if(muscleGrowthIndex > 0 && extraCal <= 500)
            {
                dailyMuscleGrowth = (extraCal * .75) / 2500;
                dailyFatGrowth = (extraCal * .25) / 1200;
                extraCal = 0;
                dailyDeterminationChange = extraCal/100;
            }
            else if(muscleGrowthIndex < 0 && extraCal <= 500)
            {
                dailyMuscleGrowth = (extraCal * .2) / 2500;
                dailyFatGrowth = (extraCal * .8) / 1200;
                extraCal = 0;
                dailyDeterminationChange = extraCal/100;
            }
            dailyMuscleGrowth += (extraCal * .1) / 2500;
            dailyFatGrowth += (extraCal * .9) / 1200;
            dailyDeterminationChange -= extraCal / 100; 
        }else if(extraCal < 0)
        {
            if (muscleGrowthIndex > 0 && extraCal < -500)
            {
                dailyMuscleGrowth = (-500 * .25) / 2500;
                dailyFatGrowth = (-500 * .75) / 1200;
                extraCal += 500;
                dailyDeterminationChange = 5;
            }
            else if (muscleGrowthIndex <= 0 && extraCal < -500)
            {
                dailyMuscleGrowth = (-500 * .8) / 2500;
                dailyFatGrowth = (-500 * .2) / 1200;
                extraCal += 500;
                dailyDeterminationChange = 5;
            }
            else if (muscleGrowthIndex > 0 && extraCal >= -500)
            {
                dailyMuscleGrowth = (extraCal * .25) / 2500;
                dailyFatGrowth = (extraCal * .75) / 1200;
                extraCal = 0;
                dailyDeterminationChange = Mathf.Abs(extraCal) / 100;
            }
            else if (muscleGrowthIndex <= 0 && extraCal >= -500)
            {
                dailyMuscleGrowth = (extraCal * .8) / 2500;
                dailyFatGrowth = (extraCal * .2) / 1200;
                extraCal = 0;
                dailyDeterminationChange = Mathf.Abs(extraCal) / 100;
            }
            dailyMuscleGrowth += (extraCal * .9) / 2500;
            dailyFatGrowth += (extraCal * .1) / 1200;
            dailyDeterminationChange -= Mathf.Abs(extraCal) / 100;
        }
     
        dailyWeightGrowth = dailyFatGrowth + dailyMuscleGrowth ;

        print(dailyMuscleGrowth + " " + dailyWeightGrowth + " " + dailyFatGrowth + " " + dailyDeterminationChange + " " + dailyMetabolismChange);
        player.setValues(dailyMuscleGrowth, dailyMuscleGrowth, dailyFatGrowth, dailyDeterminationChange, dailyMetabolismChange);

    }


}
