using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TransitionThing : MonoBehaviour
{

    public TextMeshProUGUI dayNum;
    int counter;
    public GameObject playerImage;
    public Image playerbody;
    
    Player player;
    List<Diet> diets;
    List<Exercise> exercises;
    int extraCal;
    float muscleGrowthIndex;

    double dailyMuscleGrowth;
    double dailyWeightGrowth;
    double dailyFatGrowth;
    double dailyMetabolismChange;
    int dailyDeterminationChange;

    public GameObject GameOverPanel; 
    private void Start()
    {
        player = InitStat.getPlayer();
        
        diets = DietManager.Diets;
        exercises = PlanManager.Exercises;
        counter = 1;
        dayNum.text = "Week " + counter;

        playerbody = playerImage.GetComponent<Image>();
        TheMoods.Normal();
        TheMoods.getRandomMood();
        TheEvents.Normal();
        TheEvents.getRandomEvent();
        playerbody.sprite = player.getCurrentPlayerBody();
    }

    public void buttonClick(){
       
        extraCal = 0;
        counter++;
        dayNum.text = "Week " + counter;

        //calculate total calories
        foreach(Diet d in diets)
        {
            extraCal += d.getCal();
            
        }

        foreach(Exercise e in exercises)
        {
            extraCal -= e.CaloriesBurned;
            muscleGrowthIndex += e.MuscleMassIncrease;

            if(e.id == 2)
            {
                dailyDeterminationChange -= 2; 
            }
        }

        extraCal -= (int)(player.getMetabolism());
        //change metabolism
        dailyWeightGrowth = extraCal/100;

        //change fat & muscle
        if (extraCal >= 0)
        {
            if(muscleGrowthIndex > 0 && extraCal > 500)
            {
                dailyMuscleGrowth = (500 * .75) / 250;
                dailyFatGrowth = (500 * .25) / 120;
                extraCal -= 500;
                dailyDeterminationChange += 2;
            }
            else if(muscleGrowthIndex <= 0 && extraCal > 500)
            {
                dailyMuscleGrowth = (500 * .2) / 250;
                dailyFatGrowth = (500 * .8) / 120;
                extraCal -= 500;
                dailyDeterminationChange += 2;
            }
            else if(muscleGrowthIndex > 0 && extraCal <= 500)
            {
                dailyMuscleGrowth = (extraCal * .75) / 250;
                dailyFatGrowth = (extraCal * .25) / 120;
                extraCal = 0;
                dailyDeterminationChange += extraCal/200;
            }
            else if(muscleGrowthIndex < 0 && extraCal <= 500)
            {
                dailyMuscleGrowth = (extraCal * .2) / 250;
                dailyFatGrowth = (extraCal * .8) / 120;
                extraCal = 0;
                dailyDeterminationChange += extraCal/200;
            }
            dailyMuscleGrowth += (extraCal * .1) / 200;
            dailyFatGrowth += (extraCal * .9) / 120;
            dailyDeterminationChange -= extraCal / 200; 
        }else if(extraCal < 0)
        {
            if (muscleGrowthIndex > 0 && extraCal < -500)
            {
                dailyMuscleGrowth = (-500 * .25) / 250;
                dailyFatGrowth = (-500 * .75) / 120;
                extraCal += 500;
                dailyDeterminationChange += 2;
            }
            else if (muscleGrowthIndex <= 0 && extraCal < -500)
            {
                dailyMuscleGrowth = (-500 * .8) / 250;
                dailyFatGrowth = (-500 * .2) / 120;
                extraCal += 500;
                dailyDeterminationChange += 2;
            }
            else if (muscleGrowthIndex > 0 && extraCal >= -500)
            {
                dailyMuscleGrowth = (extraCal * .25) / 250;
                dailyFatGrowth = (extraCal * .75) / 120;
                extraCal = 0;
                dailyDeterminationChange += Mathf.Abs(extraCal) / 200;
            }
            else if (muscleGrowthIndex <= 0 && extraCal >= -500)
            {
                dailyMuscleGrowth = (extraCal * .8) / 250;
                dailyFatGrowth = (extraCal * .2) / 120;
                extraCal = 0;
                dailyDeterminationChange += Mathf.Abs(extraCal) / 200;
            }
            dailyMuscleGrowth += (extraCal * .9) / 250;
            dailyFatGrowth += (extraCal * .1) / 120;
            dailyDeterminationChange -= Mathf.Abs(extraCal) / 200;
        }
        // change mood
        TheMoods.getRandomMood();
        TheMoods.getCurrent().changeStat();
        
        TheEvents.getRandomEvent();
        TheEvents.getCurrent().changeStat();

        playerbody.sprite = player.getCurrentPlayerBody();
        dailyMetabolismChange = (dailyMuscleGrowth * 10);

        
        print(dailyMuscleGrowth + " " + dailyWeightGrowth + " " + dailyFatGrowth + " " + dailyDeterminationChange + " " + dailyMetabolismChange);
        player.setValues(dailyMuscleGrowth, dailyMuscleGrowth, dailyFatGrowth, dailyDeterminationChange, dailyMetabolismChange);

      

        if(player.getDetermination() < 0)
        {
            GameOverPanel.SetActive(true);
        }
    }

   
}
