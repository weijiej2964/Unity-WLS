using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DietButtonPressed : MonoBehaviour
{
    public Diet Diet;
    public Image image;
    public GameObject plan;
    public Image planImage;


    public void ButtonPressed()
    {
        DietManager.Instance.Add(Diet);



        for (int i = 0; i < DietManager.getDietList().Count; i++)
        {
            switch (i)
            {
                case 0:
                    Diet temp = DietManager.getDietList()[0];
                    planImage = GameObject.Find("DietPlan/FirstDiet/Icon").GetComponent<Image>();
                    planImage.sprite = temp.icon;
                    break;
                case 1:
                    Diet temp1 = DietManager.getDietList()[1];
                    planImage = GameObject.Find("DietPlan/SecondDiet/Icon").GetComponent<Image>();
                    planImage.sprite = temp1.icon;
                    break;
                case 2:
                    Diet temp2 = DietManager.getDietList()[2];
                    planImage = GameObject.Find("DietPlan/ThirdDiet/Icon").GetComponent<Image>();
                    planImage.sprite = temp2.icon;
                    break;
            }
        }


    }



}
