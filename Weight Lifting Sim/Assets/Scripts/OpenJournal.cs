using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenJournal : MonoBehaviour
{
    public GameObject Journal;
    public GameObject CloseButton;
    public GameObject OpenObject;
    public void ButtonClicked()
    {
        Journal.SetActive(true);
        CloseButton.SetActive(true);
        OpenObject.SetActive(false);
    }
}
