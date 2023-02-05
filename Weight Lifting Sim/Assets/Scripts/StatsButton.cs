using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsButton : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject StatPage;
    public GameObject RoutinePage; 
    public void OnButtonClick()
    {
        StatPage.SetActive(true);
        RoutinePage.SetActive(false);
    }
}
