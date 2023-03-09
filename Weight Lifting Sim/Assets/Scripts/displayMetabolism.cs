using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayMetabolism : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI metabolismText;
    void Start()
    {
        metabolismText.text = "Metabolism = " + InitStat.metabolism + " cal";
    }
}
