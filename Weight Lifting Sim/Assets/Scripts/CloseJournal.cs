using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseJournal : MonoBehaviour
{
    public GameObject Journal;
    public GameObject CloseButton;
    public GameObject OpenButton;
    public void ButtonClicked()
    {
        Journal.SetActive(false);
        CloseButton.SetActive(false);
        OpenButton.SetActive(true);
    }
}
