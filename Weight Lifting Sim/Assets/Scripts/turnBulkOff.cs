using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnBulkOff : MonoBehaviour
{

    
    public GameObject bulkOn;
    public GameObject bulkOff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonClick(){
        bulkOff.SetActive(true);
        bulkOn.SetActive(false);
        InitStat.determination = (int)(InitStat.determination * 0.9);
    }
}
