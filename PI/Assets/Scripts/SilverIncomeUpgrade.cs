using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SilverIncomeUpgrade : MonoBehaviour
{
    private double[] multipliers = new double[] {1.7, 1.8, 1.9, 2, 2.2};
    private int[] costs = new int[] {200, 225, 230, 275, 300};
    public static int tier = 0;
    public GameObject button;
    public GameObject mtotal;
    public GameObject text;
    public GameObject costm;
    public GameObject mult;
    public GameObject cost;

    public void onClick() {
        if(MCoinClick.m >= costs[tier] && tier != costs.Length - 1){
            MCoinClick.upgrade = multipliers[tier];
            MCoinClick.m -= costs[tier];
            MCoinClick.cost = 1 + (1.06 * MCoinClick.m);
            mtotal.GetComponent<Text>().text = MCoinClick.m.ToString();
            costm.GetComponent<Text>().text = MCoinClick.cost.ToString();
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
