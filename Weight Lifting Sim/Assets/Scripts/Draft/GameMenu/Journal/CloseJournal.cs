using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseJournal : MonoBehaviour
{
    [SerializeField] private Image Background;
    [SerializeField] private Color BackgroundColor;

    private void Start()
    {
        BackgroundColor.a = 1;
    }
    public void ButtonClicked()
    {
        Background.color = BackgroundColor;
    }
}
