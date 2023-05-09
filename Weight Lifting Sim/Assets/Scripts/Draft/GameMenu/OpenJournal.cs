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



    private void Start()
    {
        player = InitStat.getPlayer();
    
        BackgroundColor.a = 1; 
    }
  
   
    public void ButtonClicked()
    {
        Background.color = BackgroundColor;
        print(player.getBodyFat());
        statText.text = "Name : " + player.getName() + " \nWeight: " + (int)player.getWeight() + "Lbs \nDetermination: " + player.getDetermination() + " \nBody Fat: " + (int)player.getBodyFat() + 
        "Lbs \nMuscle Mass: " + (int)player.getMuscleMass() + "Lbs \nMetabolism: " + (int)player.getMetabolism() + "Cal \nMood: " + TheMoods.getCurrent().getText() + "\n\n" + TheEvents.getCurrent().getText();

    }
   
}
