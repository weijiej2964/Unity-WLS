using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnBulkOn : MonoBehaviour
{
    public GameObject bulkOn;
    public GameObject bulkOff;
    // Start is called before the first frame update
    void Start()
    {
        
    }



    public void buttonClick (){
        bulkOn.SetActive(true);
        bulkOff.SetActive(false);
    }
}
