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

        SceneManager.LoadScene("GamePlay");
    }

    
}
