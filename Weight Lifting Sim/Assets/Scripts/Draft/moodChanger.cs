using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moodChanger
{


    public string mood;

    public Player player = InitStat.getPlayer();

    


    public string[] moodTypes = {"excited", "fatigued", "determined" ,"lazy"};

    public moodChanger() {
        int num = Random.Range(0, 3);
        mood = moodTypes[num];
    }

    public string getMood(){
        return mood;
    }

    public void changeMood(){
        int num = Random.Range(0, 3);
        mood = moodTypes[num]; 

        if(mood == "excited"){
            if(player.getDetermination() < 90){
                player.determination += 10;
            } else if (player.getDetermination() < 100){
                player.determination += 1;
            }            
        } else if (mood == "fatigued"){
            if(player.getDetermination() > 25){
                player.determination -= 5;
            } else if(player.getDetermination() > 0){
                player.determination -= 1;
            }
        } else if(mood == "determined"){
            if(player.getDetermination() < 80){
                player.determination += 20;
            } else if (player.getDetermination() < 100){
                player.determination += 1;
            }
        } else if(mood == "lazy"){
            if(player.getDetermination() > 50){
                player.determination -= 10;
            } else if(player.getDetermination() > 25){
                player.determination -= 5;
            } else if(player.getDetermination() > 0){
                player.determination -= 1;
            }
        }
    }



}
