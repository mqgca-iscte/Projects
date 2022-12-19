using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BronzeOverclockUpgrade : MonoBehaviour
{
    public GameObject button;
    public GameObject rtotal;
    public GameObject text;
    public GameObject costr;

    public void onClick() {
          if(RCoinClick.r >= 100){
            Overclock.max -= 20;
            RCoinClick.r -= 100;
            RCoinClick.cost = 1 + (1.06 * RCoinClick.r);
            rtotal.GetComponent<Text>().text = RCoinClick.r.ToString();
            costr.GetComponent<Text>().text = RCoinClick.cost.ToString();
            text.GetComponent<Text>().text = "MAXED OUT";
            Button upgrade = button.GetComponent<Button>();
            upgrade.interactable = false;
        }
    }
}