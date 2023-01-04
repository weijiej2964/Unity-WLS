using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseJournal : MonoBehaviour
{
    public GameObject Journal;
    public void ButtonClicked()
    {
        Journal.SetActive(false);
    }
}
