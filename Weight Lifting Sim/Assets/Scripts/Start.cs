using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{

    public void ModeButton()
    {
        InitStat.weight = Random.Range(100,200);
        print(InitStat.weight);

        InitStat.determination = Random.Range(0, 100);
        print(InitStat.determination);

        InitStat.day = 1;

        InitStat.bodyFat = Random.Range(2, 26);

        InitStat.muscleMass = Random.Range(1, 45);

        InitStat.metabolism = Random.Range(800, 3000);


        SceneManager.LoadScene("GamePlay");
    }

    
}
