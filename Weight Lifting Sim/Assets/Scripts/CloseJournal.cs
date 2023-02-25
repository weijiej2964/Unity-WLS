using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseJournal : MonoBehaviour
{
    public GameObject Journal;
    public GameObject CloseButton;
    public GameObject OpenButton;

    public GameObject BulkOn;

    public GameObject BulkOff;

    public GameObject nextButton;

    public GameObject dayText;

    [SerializeField] private Image Background;
    [SerializeField] private Color BackgroundColor;

    private void Start()
    {
        BackgroundColor.a = 1;
    }
    public void ButtonClicked()
    {
        Journal.SetActive(false);
        CloseButton.SetActive(false);
        OpenButton.SetActive(true);
        BulkOn.SetActive(true);
        BulkOff.SetActive(true);
        Background.color = BackgroundColor;
        nextButton.SetActive(true);
        dayText.SetActive(true);
    }
}
