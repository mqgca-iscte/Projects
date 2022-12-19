using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SilverCoinGenerator : MonoBehaviour
{
    private int[] coins = new int[] {1, 2, 3, 4, 5};
    private int[] costs = new int[] {50, 75, 90, 125, 150};
    public static int tier = -1;
    public static int mgens = 0;
    public GameObject button;
    public GameObject mtotal;
    public GameObject genstotal;
    public GameObject text;
    public GameObject costm;
    public GameObject coinstext;
    public GameObject cost;

    void generateCoin() {
        MCoinClick.m += mgens * coins[tier];
        mtotal.GetComponent<Text>().text = MCoinClick.m.ToString();
        Invoke("generateCoin", 10);
    }

    public void onClick() {
        if(MCoinClick.m >= costs[tier + 1] && tier != costs.Length - 1){
            MCoinClick.m -= costs[tier + 1];
            MCoinClick.cost = 1 + (1.06 * MCoinClick.m);
            mtotal.GetComponent<Text>().text = MCoinClick.m.ToString();
            costm.GetComponent<Text>().text = MCoinClick.cost.ToString();
            if(tier == -1){
                mgens++;
                tier++;
                genstotal.GetComponent<Text>().text = BronzeCoinGenerator.rgens.ToString() + "/" + mgens.ToString() + "/" + GoldCoinGenerator.bgens.ToString();
                generateCoin();
            }else{
                tier++;
            }
            if(tier == costs.Length - 1){
                text.GetComponent<Text>().text = "MAXED OUT";
                Button upgrade = button.GetComponent<Button>();
                upgrade.interactable = false;
            }else{
                text.GetComponent<Text>().text = "Coin Generator (Tier " + (tier + 2) + ")";
                coinstext.GetComponent<Text>().text = coins[tier + 1].ToString();
                cost.GetComponent<Text>().text = costs[tier + 1].ToString();
            }
        }
    }
}
