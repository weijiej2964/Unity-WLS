using System Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 
public class Event : MonoBehaviour
{
    private static string [] Events =
    {
        losingDetermination, StomachAce, Craving, overtime
    }

    private PlayerChange = new Player(90,20,40,40,60);

    private bool isRadmon = false;
    

    // Start is called before the first frame update
    
    void Start()
    {
       
    }

        private IEnumerator Randomizing()
    {
        isRadmon = true;
        yield return new waitForSeconds(Mathf.Random()*300);
        string chosenEvent = Events[Random.Range(0, Events.length)];
        isRadmon = false;
        if (chosenEvent.equals("losingDetermination"))
        {
            PlayerChange.setValues(0, 0, 0, -10, 0);
        } else if (chosenEvent.equals("StomachAce")){
            PlayerChange.setValues(-10, 0, 0, 0, 0);
        } else if (chosenEvent.equals("Craving")){
            PlayerChange.setValues(10, 0, 10, 0, 0);  
        }else if (chosenEvent.equals("overtime"))
        {
            PlayerChnage.setValues(0, 10, 0, 0, 0);
        }


    }


     
    // Update is called once per frame
    void Update()
    {
        if (!isRadmon)
        {
            StartCoroutine(Randomizing());
        }
    }
}
