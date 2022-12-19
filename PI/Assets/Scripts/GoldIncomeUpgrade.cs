using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldIncomeUpgrade : MonoBehaviour
{
    private double[] multipliers = new double[] {2.3, 2.5, 2.7, 2.9, 3.2};
    private int[] costs = new int[] {200, 225, 230, 275, 300};
    public static int tier = 0;
    public GameObject button;
    public GameObject btotal;
    public GameObject text;
    public GameObject costb;
    public GameObject mult;
    public GameObject cost;

    public void onClick() {
        if(BCoinClick.b >= costs[tier] && tier != costs.Length - 1){
            BCoinClick.upgrade = multipliers[tier];
            BCoinClick.b -= costs[tier];
            BCoinClick.cost = 1 + (1.06 * BCoinClick.b);
            btotal.GetComponent<Text>().text = BCoinClick.b.ToString();
            costb.GetComponent<Text>().text = BCoinClick.cost.ToString();
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
