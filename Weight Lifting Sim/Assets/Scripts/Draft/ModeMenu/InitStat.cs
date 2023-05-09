using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitStat : MonoBehaviour
{
    private static Player player;

  

    public Sprite LowfLowm, lowfMidm, lowfHighm, MidfLowm, MidfMidm, MidfHighm, HighfLowm, HighfMidm, HighfHighm;
    public void NormalMode()
    {
        player = new Player(Random.Range(100f, 300f), Random.Range(.33f, .39f), Random.Range(.08f, .19f), Random.Range(50, 100), Random.Range(1200, 1800), LowfLowm, lowfMidm, lowfHighm, MidfLowm, MidfMidm, MidfHighm, HighfLowm, HighfMidm, HighfHighm);
        SceneManager.LoadScene("GamePlay");
      
    }

    public static Player getPlayer()
    {
        return player;
    }

}
