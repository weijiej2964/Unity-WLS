using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//create RandomEvent Class
public class RandomEvents(){
    //create variables for the changes to each stat
    double weight, bodyfat, musclemass;
    int metabolism, determination;
    string text;
    Player player = InitStat.getPlayer();

    //create a constructor
    public RandomEvents(double w, double fat, double muscle, int meta, int deter, string text)
    {
        //set the param to variable
    }

    public void changeStat()
    {
        player.setValue(weight, musclemass, bodyfat, determination, metabolism);
    }
}
