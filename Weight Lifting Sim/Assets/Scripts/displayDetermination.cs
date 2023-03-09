using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class displayDetermination : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI determinationText;
    void Start()
    {
        determinationText.text = "Determination " + InitStat.determination;
    }

}
