using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BronzeIncomeUpgrade : MonoBehaviour
{
    private double[] multipliers = new double[] {1.5, 1.6, 1.7, 1.8, 2};
    private int[] costs = new int[] {200, 225, 230, 275, 300};
    public static int tier = 0;
    public GameObject button;
    public GameObject rtotal;
    public GameObject text;
    public GameObject costr;
    public GameObject mult;
    public GameObject cost;

    public void onClick() {
        if(RCoinClick.r >= costs[tier] && tier != costs.Length - 1){
            RCoinClick.upgrade = multipliers[tier];
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
                text.GetComponent<Text>().text = "Income Upgrade (Tier " + (tier + 1) + ")";
                mult.GetComponent<Text>().text = multipliers[tier].ToString();
                cost.GetComponent<Text>().text = costs[tier].ToString();
            }
        }
    }
}
