using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BronzeCoinGenerator : MonoBehaviour
{
    private int[] coins = new int[] {1, 2, 3, 4, 5};
    private int[] costs = new int[] {50, 75, 90, 125, 150};
    public static int tier = -1;
    public static int rgens = 0;
    public GameObject button;
    public GameObject rtotal;
    public GameObject genstotal;
    public GameObject text;
    public GameObject costr;
    public GameObject coinstext;
    public GameObject cost;

    void generateCoin() {
        RCoinClick.r += rgens * coins[tier];
        rtotal.GetComponent<Text>().text = RCoinClick.r.ToString();
        Invoke("generateCoin", 10);
    }

    public void onClick() {
        if(RCoinClick.r >= costs[tier + 1] && tier != costs.Length - 1){
            RCoinClick.r -= costs[tier + 1];
            RCoinClick.cost = 1 + (1.06 * RCoinClick.r);
            rtotal.GetComponent<Text>().text = RCoinClick.r.ToString();
            costr.GetComponent<Text>().text = RCoinClick.cost.ToString();
            if(tier == -1){
                rgens++;
                tier++;
                genstotal.GetComponent<Text>().text = rgens.ToString() + "/" + SilverCoinGenerator.mgens.ToString() + "/" + GoldCoinGenerator.bgens.ToString();
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
