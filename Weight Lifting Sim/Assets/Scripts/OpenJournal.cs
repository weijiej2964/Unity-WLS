using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenJournal : MonoBehaviour
{
    public GameObject Journal;
    public GameObject CloseButton;
    public GameObject OpenObject;

    public GameObject BulkOn;

    public GameObject BulkOff;


    [SerializeField] private Image Background;
    [SerializeField] private Color BackgroundColor;

    private void Start()
    {
        BackgroundColor.a = 1; 
    }
  

   
    public void ButtonClicked()
    {
        Journal.SetActive(true);
        CloseButton.SetActive(true);
        OpenObject.SetActive(false);
        BulkOn.SetActive(false);
        BulkOff.SetActive(false);
        Background.color = BackgroundColor; 
    }
   
}
