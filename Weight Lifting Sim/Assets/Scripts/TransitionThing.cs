using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TransitionThing : MonoBehaviour
{

    public TextMeshProUGUI dayNum;
    int counter;


 
    public void buttonClick(){
        counter++;
        dayNum.text = "Day " + counter;
    }


}
