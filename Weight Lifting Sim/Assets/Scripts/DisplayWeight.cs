using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayWeight : MonoBehaviour
{
    public TextMeshProUGUI weightText;
    void Start(){
        weightText.text = "Weight = " + InitStat.weight; 
    }
}
