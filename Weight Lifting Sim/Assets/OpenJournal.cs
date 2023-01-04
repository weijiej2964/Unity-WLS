using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenJournal : MonoBehaviour
{
    public GameObject Journal;
    public void ButtonClicked()
    {
        Journal.SetActive(true);
    }
}
