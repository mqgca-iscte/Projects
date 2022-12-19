using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BronzeIntervalUpgrade : MonoBehaviour
{
    private float[] intervals = new float[] {5.5f, 4, 3, 2, 1};
    private int[] costs = new int[] {100, 125, 175, 200, 225};
    public static int tier = 0;
    public GameObject button;
    public GameObject rtotal;
    public GameObject text;
    public GameObject costr;
    public GameObject itv;
    public GameObject cost;

    public void onClick() {
        if(RCoinClick.r >= costs[tier] && tier != costs.Length - 1){
            RCoinClick.interval = intervals[tier];
            RCoinClick.r -= costs[tier];
            RCoinClick.cost = 1 + (1.06 * RCoinClick.r);
            rtotal.GetComponent<Text>().text = RCoinClick.r.ToString();
            costr.GetComponent<Text>().text = RCoinClick.cost.ToString();
            tier++;
            if(tier == costs.Length){
                text.GetComponent<Text>().text = "MAXED OUT";
                Button upgrade = button.GetComponent<Button>();
                upgrade.interactable = false;
            }else{
                text.GetComponent<Text>().text = "Income Interval Upgrade (Tier " + (tier + 1) + ")";
                itv.GetComponent<Text>().text = intervals[tier].ToString() + "s";
                cost.GetComponent<Text>().text = costs[tier].ToString();
            }
        }
    }
}
