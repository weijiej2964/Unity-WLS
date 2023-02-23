using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DietReset : MonoBehaviour
{
    public Sprite dumbell;
    public void buttonClicked()
    {
        for (int i = DietManager.getDietList().Count - 1; i >= 0; i--)
        {
            DietManager.Instance.Remove(DietManager.getDietList()[i]);
        }
        GameObject First = GameObject.Find("FirstDiet/Icon");
        GameObject Second = GameObject.Find("SecondDiet/Icon");
        GameObject Third = GameObject.Find("ThirdDiet/Icon");

        First.GetComponent<Image>().sprite = dumbell;
        Second.GetComponent<Image>().sprite = dumbell;
        Third.GetComponent<Image>().sprite = dumbell;
    }
}
