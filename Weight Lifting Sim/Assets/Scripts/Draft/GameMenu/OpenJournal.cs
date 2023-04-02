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
        statText.text = "Name : " + player.getName() + " \nWeight: " + player.getWeight() + " \nDetermination: " + player.getDetermination() + " \nBody Fat: " + player.getBodyFat() + 
        " \nMuscle Mass: " + player.getMuscleMass() + " \nMetabolism: " + player.getMetabolism() + " \nMood: " + mood.getMood();

    }
   
}
