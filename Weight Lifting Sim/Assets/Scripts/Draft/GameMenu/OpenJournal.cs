using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpenJournal : MonoBehaviour
{
    [SerializeField] private Image Background;
    [SerializeField] private Color BackgroundColor;
    public TextMeshProUGUI statText;
    Player player;

    moodChanger mood;

    private void Start()
    {
        player = InitStat.getPlayer();
        mood = InitStat.getMood();
        BackgroundColor.a = 1; 
    }
  
   
    public void ButtonClicked()
    {
        Background.color = BackgroundColor;
        print(player.getBodyFat());
        statText.text = "Name : " + player.getName() + " \nWeight: " + (int)player.getWeight() + "Lbs \nDetermination: " + player.getDetermination() + " \nBody Fat: " + (int)player.getBodyFat() + 
        "Lbs \nMuscle Mass: " + (int)player.getMuscleMass() + "Lbs \nMetabolism: " + (int)player.getMetabolism() + "Cal \nMood: " + mood.getMood() + "\n\n" + TheEvents.getCurrent().getText();

    }
   
}
