using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandonEvent : MonoBehaviour
{
    //create RandomEvent Class
    public class RandomEvents
    {
        //create variables for the changes to each stat
        double weight, bodyfat, musclemass;
        int metabolism, determination;
        string text;
        public Player player = InitStat.getPlayer();

        //create a constructor
        public RandomEvents(double w, double fat, double muscle, int meta, int deter, string text)
        {
            text = "";
            weight = w;
            bodyfat = fat;
            musclemass = muscle;
            determination = deter;
            metabolism = meta;
        }

        public void changeStat()
        {
            player.setValue(weight, musclemass, bodyfat, determination, metabolism);
        }
    }
}


