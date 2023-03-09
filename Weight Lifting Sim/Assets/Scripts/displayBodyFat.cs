using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayBodyFat : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI bodyFatText;
    void Start()
    {
        bodyFatText.text = "Body Fat = " + InitStat.bodyFat + "%";
    }
}
