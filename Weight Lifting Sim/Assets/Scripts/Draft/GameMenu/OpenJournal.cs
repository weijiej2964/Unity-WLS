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
        statText.text = "Name : " + player.getName() + " \nWeight: " + player.getWeight();
    }
   
}
