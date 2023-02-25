using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DisplayDay : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI dayText;
    void Start()
    {
        dayText.text = "Day " + InitStat.day;
    }


}
