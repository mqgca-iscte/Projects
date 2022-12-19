using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldClickUpgrade : MonoBehaviour
{
    public GameObject button;
    public GameObject btotal;
    public GameObject text;
    public GameObject costb;
    public void onClick() {
        if(BCoinClick.b >= 25){
            MouseClick.mult = 2.5;
            BCoinClick.b -= 25;
            BCoinClick.cost = 1 + (1.06 * BCoinClick.b);
            btotal.GetComponent<Text>().text = BCoinClick.b.ToString();
            costb.GetComponent<Text>().text = BCoinClick.cost.ToString();
            text.GetComponent<Text>().text = "MAXED OUT";
            Button upgrade = button.GetComponent<Button>();
            upgrade.interactable = false;
        }
    }
}
