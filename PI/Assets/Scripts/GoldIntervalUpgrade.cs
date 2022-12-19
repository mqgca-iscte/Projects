using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldIntervalUpgrade : MonoBehaviour
{
    private float[] intervals = new float[] {5.5f, 4, 3, 2, 1};
    private int[] costs = new int[] {100, 125, 175, 200, 225};
    public static int tier = 0;
    public GameObject button;
    public GameObject btotal;
    public GameObject text;
    public GameObject costb;
    public GameObject itv;
    public GameObject cost;

    public void onClick() {
        if(BCoinClick.b >= costs[tier] && tier != costs.Length - 1){
            BCoinClick.interval = intervals[tier];
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
                text.GetComponent<Text>().text = "Income Interval Upgrade (Tier " + (tier + 1) + ")";
                itv.GetComponent<Text>().text = intervals[tier].ToString() + "s";
                cost.GetComponent<Text>().text = costs[tier].ToString();
            }
        }
    }
}
