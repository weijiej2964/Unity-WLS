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
        print(extraCal);
        if(extraCal >= 0)
        {
            dailyMetabolismChange += 1;
            dailyDeterminationChange += 1;
        }else if(extraCal < 0)
        {
            dailyMetabolismChange -= 1;
            dailyDeterminationChange -= 1;
        }

        //gain muscle
        if(muscleGrowthIndex > 0)
        {
            print(((extraCal % 500) * .75f));
            dailyMuscleGrowth = ((extraCal % 500) * .75)/3750;
            dailyFatGrowth = ((extraCal % 500) * .25)/3750;
            if(extraCal >= 500)
            {
                extraCal -= 500;
            }
            else
            {
                extraCal = 0;
            }
        }
        else
        {
            dailyMuscleGrowth += ((extraCal % 500) * .20) / 3750;
            dailyFatGrowth += ((extraCal % 500) * .80) / 3750;
            if (extraCal >= 500)
            {
                extraCal -= 500;
            }
            else
            {
                extraCal = 0;
            }
        }

        dailyFatGrowth += extraCal / 3750;
        dailyWeightGrowth = dailyFatGrowth + dailyMuscleGrowth;

        print(dailyMuscleGrowth + " " + dailyWeightGrowth + " " + dailyFatGrowth + " " + dailyDeterminationChange + " " + dailyMetabolismChange);
        player.setValues(dailyMuscleGrowth, dailyMuscleGrowth, dailyFatGrowth, dailyDeterminationChange, dailyMetabolismChange);

        print(player.getWeight());
    }


}
