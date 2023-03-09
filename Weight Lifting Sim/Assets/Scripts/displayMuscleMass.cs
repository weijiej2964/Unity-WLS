using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayMuscleMass : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI muscleMassText;
    void Start()
    {
        muscleMassText.text = "Muscle Mass = " + InitStat.muscleMass + "%";
    }
}
