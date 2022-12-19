using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldOverclockUpgrade : MonoBehaviour
{
    public GameObject button;
    public GameObject btotal;
    public GameObject text;
    public GameObject costb;

    public void onClick() {
          if(BCoinClick.b >= 100){
            Overclock.max -= 20;
            BCoinClick.b -= 100;
            BCoinClick.cost = 1 + (1.06 * BCoinClick.b);
            btotal.GetComponent<Text>().text = BCoinClick.b.ToString();
            costb.GetComponent<Text>().text = BCoinClick.cost.ToString();
            text.GetComponent<Text>().text = "MAXED OUT";
            Button upgrade = button.GetComponent<Button>();
            upgrade.interactable = false;
        }
    }
}