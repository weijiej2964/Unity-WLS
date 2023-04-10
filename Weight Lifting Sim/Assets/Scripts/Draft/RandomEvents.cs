using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEvents
{
  //create variables for the changes to each stat
  double weight, bodyfat, musclemass;
    int metabolism, determination;
    string text;
    Player player = InitStat.getPlayer();

    //create a constructor
    public RandomEvents(double w, double fat, double muscle, int meta, int deter, string text)
    {
        weight = w;
        bodyfat = fat;
        musclemass = muscle;
        metabolism = meta;
        determination = deter;
        this.text = text; 
    }

    public void changeStat()
    {
        player.setValues(weight, musclemass, bodyfat, determination, metabolism);
    }
    
    public string getText()
    {
        return text;
    }
}


